﻿using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour{

	// Use this for initialization
	void Start(){
		
	}
	
	// Update is called once per frame
	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
			UnityEditor.EditorApplication.isPlaying = false; // for stoping editor
		}
	}
}
