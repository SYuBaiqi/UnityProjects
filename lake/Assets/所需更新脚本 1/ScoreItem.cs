using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public int scoreValue = 100; // �ӷ�ֵ
    public float rotationSpeed = 30f; // ��ת�ٶ�
    public GameObject collectEffect; // �ռ���Ч

    void Update()
    {
        // ����Ʒ��ת��������
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        // ֻ����ҿ����ռ�
        if (other.tag == "Player")
        {
            Collect(other.gameObject);
        }
    }

    void Collect(GameObject collector)
    {
        // ֪ͨ��Ϸ�������ӷ�
        Done_GameController gameController = FindObjectOfType<Done_GameController>();
        if (gameController != null)
        {
            gameController.AddScore(scoreValue);
        }

        // �����ռ���Ч
        if (collectEffect != null)
        {
            Instantiate(collectEffect, transform.position, transform.rotation);
        }

        // ������Ч������У�
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
            // �ȴ���Ч�������������
            Destroy(gameObject, audio.clip.length);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}