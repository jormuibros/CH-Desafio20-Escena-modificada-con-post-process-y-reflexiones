using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int  Score;
    public enum typesFood {Apple , Watermelon, Peach, Gold};
    public static event Action<int> onPointsInScreen;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Score =0;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        onPointsInScreen?.Invoke(Score);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController.onDeath += ScoreDisplay;
    }
    public void addScore()
    {
        instance.Score +=1;
        onPointsInScreen?.Invoke(Score);
    }
    public int getScore()
    {
     return instance.Score;
    }

    private void ScoreDisplay()
    {

    }
}
