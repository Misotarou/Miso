using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	public GameObject m_BeePrefab;
	public GameObject m_StrDisp;
	public int m_iCounter;
	
	void DrawFont(int x, int y, string str)
	{
	//	Rect r = new Rect(x, y, 400, 50);
		GUI.Label(new Rect(x, y, 400, 50), str);		
	}
	
	void OnGUI()
	{
		DrawFont(0, 0, "data[" + m_iCounter.ToString() + "]");
		m_iCounter++;
	}

	// Use this for initialization
	void Start () 
	{
		Instantiate(m_StrDisp, transform.position, transform.rotation);
		m_iCounter = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//DrawFont();
	//	Debug.Log("Update");
		if (Input.GetButtonDown("Fire1"))
		{
	//		Debug.Log("up");	
			Vector3 vec = transform.position;
			vec.y += 8.0f;
	       Instantiate (m_BeePrefab, vec, transform.rotation);
	    }
	}
}
