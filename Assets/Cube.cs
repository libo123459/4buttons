using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour {
    public int suit;
    public int color;
    public Text text;
	// Use this for initialization
	void Start () {
        text = this.transform.GetChild(0).GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
