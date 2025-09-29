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

    //�����ı�չʾ
    public Text scoreText;
    
    //��Ϸ�����ı�
    public Text GameOver;

    //ÿ�μӷ���ֵ
    public int addScore;

    //��ʾ�ķ���
    private int score = 0;

    void Start()
    {
        //GameOver.text = "��Ϸ����";
        updateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        //ɾ����������
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void updateText()
    {
        scoreText.text = "��ķ�����:" + score;
    }//����UI

    public void updateScore()
    {
        score += addScore;
        updateText();
    }//�����ø��·���

}
