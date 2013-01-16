using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {
	
	void DrawFont(int x, int y, string str)
	{
	//	Rect r = new Rect(x, y, 400, 50);
		GUI.Label(new Rect(x, y, 400, 50), str);		
	}	
	bool DrawButton(int x, int y, string str)
	{
		Rect rect = new Rect(x, y, 400, 50);
		bool isClicked = GUI.Button(rect, str);
		if (isClicked)
		{
			print("Stand by Ready!");
			return true;
		}	
		return false;
	}
	void OnGUI()
	{
		
		DrawFont(0, 0, "MisotarouGame");
		if(DrawButton(0, 50, "Title"))   { Application.LoadLevel("TitleGame");  }
		if(DrawButton(0, 100, "Action")) 
		{ 
			Application.LoadLevel("ActionGame"); 
		}
		if(DrawButton(0, 150, "Main"))   { Application.LoadLevel("MainGame");   }
		
	}	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetButton("Fire1")) {
		//	Application.LoadLevel("MainGame");
		//}	
	}
}
