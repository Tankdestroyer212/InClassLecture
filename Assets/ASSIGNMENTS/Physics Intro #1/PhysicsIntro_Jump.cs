using UnityEngine;

public class PhysicsIntro_Jump : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * forceAmount);
        }
    }
}
