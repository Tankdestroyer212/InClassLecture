using UnityEngine;

public class InputLecture : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Button Pressed Down");
        }

        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");
        
        Debug.Log(xAxis);
    }
}
