// CameraSway.cs
using UnityEngine;

public class CameraSway : MonoBehaviour
{
    public float baseAmplitude = 0.05f;
    public float maxAmplitude = 0.5f;
    public float frequency = 0.8f;

    Vector3 basePos;

    void Start()
    {
        basePos = transform.localPosition;
    }

    void Update()
    {
        float intox = GameManager.I != null ? GameManager.I.GetIntoxicationLevel() : 0f;
        float amp = Mathf.Lerp(baseAmplitude, maxAmplitude, intox);
        float x = Mathf.Sin(Time.time * frequency * (1f + intox)) * amp;
        float y = Mathf.Cos(Time.time * frequency * (1f + intox*0.8f)) * amp * 0.6f;
        transform.localPosition = basePos + new Vector3(x, y, 0);
    }
}
