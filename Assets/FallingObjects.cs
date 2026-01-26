using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    public float fallSpeedmin = 2f;
    public float fallSpeedmax = 5f;
    private float fallSpeed;

    public float scalemin = 0.5f;
    public float scalemax = 1.5f;

    public float resetY = 6f;
    public float killY = -6f;
    public float minX = -5f;
    public float maxX = 5f;
    
    public float hit = 1f;

    public bool isSlider = false;
    public float sliderAmp = 1.2f;
    public float sliderFrequency = 0.5f;
    
    private GameObject player;
    private GameManager gameManager;

    private float spawnX;
    private float sinTime;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.FindObjectOfType<GameManager>();

        RandomizeObstacle();
    }
    
    void Update()
    {
        if (gameManager ==null) return;
        if (gameManager.isGameOver) return;
        if (gameManager.isIntermission) return;

        float currentSpeed = fallSpeed * gameManager.speedMultiplier;
        transform.position += Vector3.down * currentSpeed * Time.deltaTime;

        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < hit)
        {
            Debug.Log("You Lost!");
        }

        if (isSlider)
        {
            sinTime += Time.deltaTime;
            float offset = Mathf.Sin(sinTime * sliderFrequency) * sliderAmp;
            transform.position = new Vector3(spawnX + offset, transform.position.y, 0);
        }
        
        if (transform.position.y < killY)
        {
            RandomizeObstacle();
        }
    }

    public void RandomizeObstacle()
    {
        float randomX = Random.Range(minX, maxX);
        
        float randomScale = Random.Range(scalemin, scalemax);
        transform.localScale = new Vector3(randomScale, randomScale, randomScale);
        
        fallSpeed = Random.Range(fallSpeedmin, fallSpeedmax);
        sinTime = Random.Range(0f, 10f);
        transform.position = new Vector3(randomX, resetY, 0);
    }
}
