// Flask.cs
using UnityEngine;

public class Flask : MonoBehaviour
{
    Rigidbody2D rb;
    public float lifetimeAfterMiss = 0.5f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Init(float fallSpeed)
    {
        if (rb == null) rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -fallSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerCatcher"))
        {
            if (GameManager.I != null) GameManager.I.OnCaught();
            Destroy(gameObject);
        }
        else if (other.CompareTag("MissZone"))
        {
            if (GameManager.I != null) GameManager.I.OnMissed();
            Destroy(gameObject, lifetimeAfterMiss);
        }
    }
}
