using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
	public string app;
	private string app2;
	public Text text;
	public sprite sp;
	public bool b;

	// Use this for initialization
	void Start () {
		Text.text = app;
		app2 = 'hello';
		text.text = app2; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
