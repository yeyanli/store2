using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript: MonoBehaviour {
    //生命周期
    //Awake 生命周期开始 脚本被载入的时候调用
    //onEnable 当对象被激活或变为可用的售后执行
    void Awake() { }
    void OnEnable() { }
    public int a;
    // Use this for initialization
    void Start () {//第一次UPdate调用的时候被执行，只执行一次
        Debug.Log("start");
        
	}
    void FixedUpdate() {
       // Debug.Log("FixedUpdate");
    }
    void Update()
    {//时间不固定
        a++;
        Debug.Log(a+"first");
        // Debug.Log("update");
    }
    void LateUpdate() {
    //    Debug.Log("LateUpdate");
    }
    //FixedUpdate 循环调用 固定更新 时间固定 处理刚体和力
    void OnGUI() {
        Debug.Log("OnGUI");
        if(GUI.Button(new Rect(0,0,100,100),"OnDisable")){
            this.enabled = false;
        };
        if (GUI.Button(new Rect(100, 0, 100, 100), "OnDestroy"))
        {
            Destroy(this);
        };
    }

    void OnDisable() {
        Debug.Log("OnDisable");
    }
    void OnDestroy() {
        Debug.Log("OnDesteroy");
    }

    // Update is called once per frame

    //  LateUpdate最后执行
    //OnGUI渲染模块 渲染和处理GUI事件
    //OnDisable当前模块不可用或非激活状态的时候被调用
    //OnDestroy卸载模块 物体被销毁的时候被调用
}
