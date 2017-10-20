using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ChildPrinter : MonoBehaviour {
	private string printStr = "";
	private float step = 0.1f;

	GameObject myCube;
	GameObject mySphere;
	GameObject myCylinder;
	GameObject myQuad;

	private IEnumerator coroutine;

	// Use this for initialization
	void Start () {
		myCube = GameObject.Find("MyCube");
		mySphere = GameObject.Find("MySphere");
		myCylinder = GameObject.Find("MyCylinder");
		myQuad = GameObject.Find("MyQuad");

		print();

		coroutine = hideQuadAfterFiveSeconds();
        StartCoroutine(coroutine);
	}
	
	// Update is called once per frame
	void Update () {
		moveObjects();
	}

	void moveObjects(){
		myCube.transform.Translate(new Vector3(2*step,0,0));
		mySphere.transform.Translate(new Vector3(0,2*step,0));
		myCylinder.transform.Translate(new Vector3(0,0,2*step));
	}

	private IEnumerator hideQuadAfterFiveSeconds(){
        yield return new WaitForSeconds(5);
        myQuad.SetActive(false);
	}
	void print(){
		printRecursion(this.transform,0);
		Debug.Log(printStr);
	}
	void printRecursion(Transform trans, int depth){
		for(int i = 0; i < depth; ++i){
			printStr += "#";
		}
		printStr += trans.gameObject.name;
		printStr += "\n";
		foreach(Transform child in trans){
			printRecursion(child, depth + 1);
		}
	}
}
