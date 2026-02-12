using UnityEngine;

public class PhysicsIntro : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(gameObject.name + " collided with " + other.gameObject.name);
    }
    
    /*
    void OnCollisionStay(Collision other)
    {
        return;
    }

    void OnCollisionExit(Collision other)
    {
        return;
    }

    void OnTriggerEnter(Collider other)
    {
        return;
    }

    void OnTriggerStay(Collider other)
    {
        return;
    }

    void OnTriggerExit(Collider other)
    {
        return;
    }
    */
}
