using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class circleCreater : MonoBehaviour {

	private Vector3 centerPos;   //你围绕那个点 就用谁的角度  
	private float radius = 6;     //物理离 centerPos的距离  
	private float angleDiff = 10;      //偏移角度    

	void Start()  
	{  
		CreateCubeAngle30();  
	}  

	public void CreateCubeAngle30()  
	{  
		centerPos = GameObject.Find ("SphereRoller").transform.position; 
		Debug.Log ("SphereRoller: " + centerPos);
		//20度生成一个圆  
		for (float angle = 0; angle < 360; angle += angleDiff)  
		{  
			//先解决你物体的位置的问题  
			// x = 原点x + 半径 * 邻边除以斜边的比例,   邻边除以斜边的比例 = cos(弧度) , 弧度 = 角度 *3.14f / 180f;     
			float x = centerPos.x + radius * Mathf.Cos(angle * 3.14f / 180f);  
			float z = centerPos.z + radius * Mathf.Sin(angle * 3.14f / 180f);  
			// 生成一个圆  
			GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);  
			//设置物体的位置Vector3三个参数分别代表x,y,z的坐标数    
			obj1.transform.localScale = new Vector3(1,2,1);  
			obj1.transform.position = new Vector3(x, obj1.transform.localScale.y, z);  
			obj1.AddComponent<Rigidbody> ();
		}  
	}
	void Update () {
		
	}
}
