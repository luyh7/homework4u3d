using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlker : MonoBehaviour {
	GameObject[] objs = new GameObject[16];
	Image[] imgs = new Image[16];
	int[] imgSelector = new int[16]{1,2,3,4,5,6,7,8,1,2,3,4,5,6,7,8};
	// Use this for initialization
	void Start () {
		startAGame();
	}
	
	void startAGame(){
		initScence();
	}

	void initScence(){
		selectImage();
		showText();
		showBtn();
	}

	void selectImage(){
		//打乱图片选择顺序(洗牌)
		for(int i = 0; i < imgSelector.Length; ++i){
			int value = Random.Range(0,imgSelector.Length);
			int tmp = imgSelector[value];
			imgSelector[value] = imgSelector[i];
			imgSelector[i] = tmp;
		}
		for(int i = 0; i < imgs.Length; ++i){
			imgs[i].sprite = Resources.Load<Sprite>(imgSelector[i].ToString());
			objs[i].GetComponent("Image") = imgs[i];
			objs[i].transform.SetParent(transform);
		}
	}

	void showText(){

	}

	void showBtn(){

	}

	// Update is called once per frame
	void Update () {
		
	}
}
