using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver = false;
    public bool isIntermission = false;

    public float score = 0f;
    public float highscore = 0f;

    public float waveLength = 15f;
    public float intermissionLength = 2.5f;
    public int wave = 1;

    public float speedMultiplier = 1f;
    public float speedIncrease = 0.67f;

    public int startObstacleCount = 5;
    public int maxObstacleCount = 20;
    public int obstacleAdd = 3;

    public int sliderAdd = 2;
    public int maxSliders = 12;

    private FallingObjects[] obstacles;
    
    private float waveTimer = 0f;
    private float breakTimer = 0f;
    void Start()
    {
        obstacles = FindObjectsByType<FallingObjects>(FindObjectsSortMode.None);

        wave = 1;
        speedMultiplier = 1f;
        
        SetObstacleCount(startObstacleCount);
        SliderCount();
        RespawnObstacles();
        
        Debug.Log("Game started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

        if (isGameOver) return;
        
        score += Time.deltaTime;
        if (score > highscore)
        {
            highscore = score;
        }

        if (!isIntermission)
        {
            waveTimer += Time.deltaTime;

            if (waveTimer >= waveLength)
            {
                StartPause();
            }
        }
        else
        {
            breakTimer += Time.deltaTime;
            if (breakTimer > intermissionLength)
            {
                NextWave();
            }
        }
    }

    void StartPause()
    {
        isIntermission = true;
        breakTimer = 0f;
        Debug.Log("Next Wave Starting...");
    }

    void NextWave()
    {
        isIntermission = false;
        waveTimer = 0f;

        wave++;
        
        speedMultiplier = 1f + speedIncrease * (wave - 1);
        
        int targetCount = startObstacleCount + obstacleAdd * (wave - 1);
        targetCount = Mathf.Min(targetCount, maxObstacleCount);
        SetObstacleCount(targetCount);

        SliderCount();

        RespawnObstacles();

        Debug.Log("Wave " + wave);
    }

    void SetObstacleCount(int count)
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].gameObject.SetActive(i < count);
        }
    }

    void SliderCount()
    {
        int slider = (wave + sliderAdd) * (wave - 1);
        slider = Mathf.Min(slider, maxSliders);

        for (int i = 0; i < obstacles.Length; i++)
        {
            if (!obstacles[i].gameObject.activeSelf) continue;

            obstacles[i].isSlider = (i < slider);
        }
    }

    void RespawnObstacles()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            if (obstacles[i].gameObject.activeSelf)
            {
                obstacles[i].RandomizeObstacle();
            }
        }
    }

    void RestartGame()
    {
        isGameOver = false;
        isIntermission = false;

        score = 0f;
        wave = 1;
        waveTimer = 0f;
        breakTimer = 0f;

        speedMultiplier = 1f;

        SetObstacleCount(startObstacleCount);
        SliderCount();
        RespawnObstacles();

        Debug.Log("Game reset");
    }

    void GameOver()
    {
        isGameOver = true;
        Debug.Log("You Lost! Score: " + Mathf.FloorToInt(score) + "High: " + Mathf.FloorToInt(highscore));
    }
}
