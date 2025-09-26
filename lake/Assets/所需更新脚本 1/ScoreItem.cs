using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public int scoreValue = 100; // 加分值
    public float rotationSpeed = 30f; // 旋转速度
    public GameObject collectEffect; // 收集特效

    void Update()
    {
        // 让物品旋转，更显眼
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        // 只有玩家可以收集
        if (other.tag == "Player")
        {
            Collect(other.gameObject);
        }
    }

    void Collect(GameObject collector)
    {
        // 通知游戏控制器加分
        Done_GameController gameController = FindObjectOfType<Done_GameController>();
        if (gameController != null)
        {
            gameController.AddScore(scoreValue);
        }

        // 播放收集特效
        if (collectEffect != null)
        {
            Instantiate(collectEffect, transform.position, transform.rotation);
        }

        // 播放音效（如果有）
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
            // 等待音效播放完毕再销毁
            Destroy(gameObject, audio.clip.length);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}