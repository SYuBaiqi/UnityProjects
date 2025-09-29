using System;
using System.Collections;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;
using Random = System.Random;


public class randomCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public int rate;
    public int num=0;
    private int nums = 0;

    public GameObject prefab;
    public Vector3 spawnPosition = new Vector3(0, 0, 0);

    void Start()
    {
        //Instantiate(prefab, spawnPosition, Quaternion.identity);
        Update();
      
        
        //GetComponent<Rigidbody>().angularVelocity = rate * UnityEngine.Random.insideUnitSphere;
    }

    // Update is called once per frame
    void Update()
    {
        //随机生成大量硬币
        if (nums++ <= num)
        {
            GameObject coin = prefab;
            spawnPosition.x += 10;
            spawnPosition.z = randnum()*3-3;
            Instantiate(coin, spawnPosition, Quaternion.identity);
        }
        
    }
    int randnum()
    {
        Random random = new Random();
        int n = random.Next(0,3);
        return n;
    }//左中右三选一
}

