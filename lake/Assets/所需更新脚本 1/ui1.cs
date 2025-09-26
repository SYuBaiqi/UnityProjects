using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui1 : MonoBehaviour {
	
	public Text xszdsm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		xszdsm.text = "子弹数目："+sj.syzdsm.ToString () + "/" + sj.yszdsm.ToString ();
	}
}
