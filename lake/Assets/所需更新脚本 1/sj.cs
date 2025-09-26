using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sj : MonoBehaviour {
	public GameObject ball;
	public float fireRate;
    public int totalBullets=60;
	private float nextFire;
    
    public GameObject playerExplosion;
	public static int yszdsm=60;
	public static int syzdsm;

    public KeyCode toggleKey = KeyCode.C; // 切换键，默认为C键
    private bool isAutoFire = false; // 是否自动射击
    private bool isFiring = false; // 是否正在持续射击

    // Use this for initialization
    void Start () {
        yszdsm = totalBullets;
		syzdsm = yszdsm;
	}
	
	// Update is called once per frame
	/*void Update () {
		if (Input.GetMouseButtonDown (0)&& Time.time > nextFire && syzdsm>0) {
			nextFire = Time.time + fireRate;
			syzdsm--;
			Instantiate (ball,transform.position,transform.rotation);
			Instantiate (playerExplosion, transform.position, transform.rotation);

        } 
	}*/
    void Update()
    {
        // 切换自动/手动射击模式
        if (Input.GetKeyDown(KeyCode.F))
        {
            Reload(10);
        }
        if (Input.GetKeyDown(toggleKey))
        {
            isAutoFire = !isAutoFire;
            isFiring = false; // 切换时停止射击

            // 可以在这里添加切换提示音效或UI提示
            //Debug.Log("射击模式切换为: " + (isAutoFire ? "自动" : "手动"));
        }

        // 手动射击模式（原逻辑）
        if (!isAutoFire)
        {
            if (Input.GetMouseButtonDown(0) && Time.time > nextFire && syzdsm > 0)
            {
                Fire();
            }
        }
        // 自动射击模式
        else
        {
            // 按下鼠标开始持续射击
            if (Input.GetMouseButtonDown(0) && syzdsm > 0)
            {
                isFiring = true;
            }

            // 松开鼠标停止射击
            if (Input.GetMouseButtonUp(0))
            {
                isFiring = false;
            }

            // 持续射击逻辑
            if (isFiring && Time.time > nextFire && syzdsm > 0)
            {
                Fire();
            }
        }

        // 显示当前模式（可选，用于调试）
        //DisplayFireMode();
    }

    // 射击方法
    void Fire()
    {
        nextFire = Time.time + fireRate;
        syzdsm--;
        Instantiate (ball,transform.position,transform.rotation);
        Instantiate (playerExplosion, transform.position, transform.rotation);

        // 可以在这里添加射击音效
        // GetComponent<AudioSource>().Play();
    }

    // 显示射击模式（可选）
    /*void DisplayFireMode()
    {
        // 在实际游戏中，你可以用UI文本显示模式
        // 这里用Debug.Log作为示例
        if (Input.GetKeyDown(toggleKey))
        {
            Debug.Log("当前模式: " + (isAutoFire ? "自动射击" : "手动射击") + " | 剩余弹药: " + syzdsm);
        }
    }*/

    // 添加重新装弹的方法（可选）
    public void Reload(int amount)
    {
        syzdsm += amount;
        if (syzdsm > yszdsm)
            syzdsm = yszdsm;

       // Debug.Log("装弹完成! 当前弹药: " + syzdsm);
    }
}
