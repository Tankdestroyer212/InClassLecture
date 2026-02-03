using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float min_X = -5f;
    public float max_X = 5f;

    // Update is called once per frame
    void Update()
    {
        //float move = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        
        float player_clamp = Mathf.Clamp(transform.position.x, min_X, max_X);
        transform.position = new Vector3(player_clamp, transform.position.y, transform.position.z);
        
    }
}
