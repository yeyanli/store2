using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondscript : MonoBehaviour {
    public int b;
	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
        b = GetComponent<firstscript>().a;
        Debug.Log("second" + b);
       // Debug.Log("secondtset");//先添加的脚本最后执行
        //default time 越小的越先执行
		
	}
}
