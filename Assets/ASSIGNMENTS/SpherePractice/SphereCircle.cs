using UnityEngine;

public class SphereCircle : MonoBehaviour
{
    public float radius;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Cos(Time.time) * radius, Mathf.Sin(Time.time) * radius, 0.0f);
    }
}
