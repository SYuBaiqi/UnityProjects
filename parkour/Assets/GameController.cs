using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameController instance;

    //分数文本展示
    public Text scoreText;
    
    //游戏结束文本
    public Text GameOver;

    //每次加分数值
    public int addScore;

    //显示的分数
    private int score = 0;

    void Start()
    {
        //GameOver.text = "游戏结束";
        updateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        //删除调用物体
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void updateText()
    {
        scoreText.text = "你的分数是:" + score;
    }//更新UI

    public void updateScore()
    {
        score += addScore;
        updateText();
    }//被调用更新分数

}
