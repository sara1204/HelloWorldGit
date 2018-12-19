using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Console.WriteLine("Hello World"); //keine Ausgabe in Unity Console
        
        Debug.Log("Hello World");
        print("Hello Woorld"); //zweite funktionierende Möglichkeit
        
        //Aufruf Methode
        float number = getRandom();
        Debug.Log("number random: " + number);
	}
    
    //deklaration Methode
    float getRandom(){
         
        return UnityEngine.Random.Range(0f,10f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
