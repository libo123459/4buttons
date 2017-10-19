using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manage : MonoBehaviour {
    public static bool isStarted = false;
    public static bool isFinished = false;
    public static int pressNum = 0;
    public static int xPre = 0;
    public static int yPre = 0;
    public List<TheBTN> BTNs = new List<TheBTN>();
    
    public void PressUpBtn()
    {
        for (int i = 0; i < 4; i++)
        {
            BTNs[i].transform.localScale = new Vector3(1, 1, 1);
            BTNs[i].isSelected = false;
        }
       
        isStarted = false;
        pressNum = 0;
        
    }    

    public static void updateTheXandY(int xPos,int yPos)
    {
        xPre = xPos;
        yPre = yPos;
    }
    // Use this for initialization
    void Start () {
        BTNs[0].xPos = 0;
        BTNs[0].yPos = 0;
        BTNs[0].suit = 1;

        BTNs[1].xPos = 1;
        BTNs[1].yPos = 0;
        BTNs[1].suit = 2;

        BTNs[2].xPos = 0;
        BTNs[2].yPos = 1;
        BTNs[2].suit = 3;

        BTNs[3].xPos = 1;
        BTNs[3].yPos = 1;
        BTNs[3].suit = 4;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
