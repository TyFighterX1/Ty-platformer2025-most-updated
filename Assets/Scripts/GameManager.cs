using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int lives = 3;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void DecreaseLives()
    {
        lives--;
    }
    public void Update()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene("Level 1");
            lives = 3;
        }
    }
    public int GetLives()
    {
        return lives;
    }
    
    
}
