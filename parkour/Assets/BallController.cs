using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode left=KeyCode.A;
    public KeyCode right=KeyCode.D;

    private bool left_d=false;
    private bool right_d=false;
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        left_d = Input.GetKeyDown(KeyCode.A);
        right_d = Input.GetKeyDown(KeyCode.D);
        if (left_d!=false)
            gameObject.transform.position += new Vector3(0, 0, 3);
        else if (right_d!=false)
            gameObject.transform.position += new Vector3(0, 0, -3);
    }
}
