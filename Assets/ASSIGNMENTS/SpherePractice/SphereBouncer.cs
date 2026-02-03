using UnityEngine;

public class SphereBouncer : MonoBehaviour
{
    public float speed = 2f;
    public float reverseDistance = 1f;
    public float dir = 1f;

    private GameObject[] spheres;
    private GameObject[] walls;
    
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("Spheres");
        walls = GameObject.FindGameObjectsWithTag("Wall");
    }
    void Update()
    {
        transform.position += new Vector3(dir * speed * Time.deltaTime, 0, 0);

        for (int i = 0; i < spheres.Length; i++)
        {
            
            if (spheres[i] = gameObject) continue;
            
            float distance = Vector3.Distance(transform.position, spheres[i].transform.position);
            if (distance < reverseDistance)
            {
                dir *= -1;
            }
        }
        

        for (int i = 0; i < walls.Length; i++)
        {
            float distance = Vector3.Distance(transform.position, walls[i].transform.position);
            if (distance < reverseDistance)
            {
                dir *= -1;
            }
        }
    }
}