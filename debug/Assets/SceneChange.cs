using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    bool pressed = false;
    public string[] sceneNames;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressed = !pressed;
        }
	}

    private void OnGUI()
    {
        if (pressed)
        {
            for(int i=0;i< sceneNames.Length; i++)
            {
                //Scene scene = SceneManager.GetSceneByName(sceneNames[i]);
                //Debug.Log(sceneNames[i]);
                if (GUI.Button(new Rect(20,20+120*i, 100, 100), new GUIContent("场景"+ sceneNames[i])))
                {
                    SceneManager.LoadScene(sceneNames[i]);
                }
            }
            
        }
    }
}
