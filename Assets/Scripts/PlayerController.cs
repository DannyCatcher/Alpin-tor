// PlayerController.cs
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float touchSensitivity = 1f;
    public bool allowTilt = false;
    public float intoxicationDrift = 0.5f;

    Rigidbody2D rb;
    Vector3 targetPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        targetPos = transform.position;
    }

    void Update()
    {
        Vector3 desired = transform.position;

        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(t.position.x, t.position.y, -Camera.main.transform.position.z));
            desired = new Vector3(worldPos.x, transform.position.y, transform.position.z);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
            desired = new Vector3(worldPos.x, transform.position.y, transform.position.z);
        }
        else if (allowTilt)
        {
            float tilt = Input.acceleration.x;
            desired += new Vector3(tilt * moveSpeed * Time.deltaTime, 0, 0);
        }

        float intox = GameManager.I != null ? GameManager.I.GetIntoxicationLevel() : 0f;
        float drift = (Random.value - 0.5f) * intox * intoxicationDrift;
        desired.x += drift;

        targetPos = Vector3.Lerp(transform.position, desired, Time.deltaTime * moveSpeed);

        float left = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + 0.3f;
        float right = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - 0.3f;
        targetPos.x = Mathf.Clamp(targetPos.x, left, right);

        rb.MovePosition(targetPos);
    }
}
