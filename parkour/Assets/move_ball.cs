using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class move_ball : MonoBehaviour
{
    // Start is called before the first frame update
    //�Զ���ǰ�ƶ�,ǰ����x������
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.02f, 0, 0);
        //GetComponent<Transform>().Translate(2 * Time.deltaTime, 0, 0);
        transform.position +=new Vector3(speed,0,0);
    }
}
