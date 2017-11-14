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
    public static List<TheBTN> BTNs = new List<TheBTN>();

    void initiBTNs()
    {
        GameObject tmp = GameObject.Find("4BTNS");
        for (int i = 0; i < 4; i++)
        {
            TheBTN b = tmp.transform.GetChild(i).GetComponent<TheBTN>();
            b.suit = i + 1;
            BTNs.Add(b);
        }
    }

    public void PressUpBtn()
    {
        for (int i = 0; i < 4; i++)
        {
            BTNs[i].transform.localScale = new Vector3(1, 1, 1);
            BTNs[i].isSelected = false;
            TargetManage.CubeList[i].transform.localScale = new Vector3(1,1,1);
        }
       
        isStarted = false;
        pressNum = 0;
        
    }    

    public static void updateTheXandY(int xPos,int yPos)
    {
        xPre = xPos;
        yPre = yPos;
    }

    public static void MatchTheBTNs(TheBTN _btn)
    {
        int index = Manage.pressNum;
        if (_btn.suit == TargetManage.CubeList[index].suit)
        {
            if (index < 4)
            {
                TargetManage.CubeList[index].transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
        }
    }
    // Use this for initialization
    void Start () {
        initiBTNs();
        BTNs[0].xPos = 0;
        BTNs[0].yPos = 0;

        BTNs[1].xPos = 1;
        BTNs[1].yPos = 0;

        BTNs[2].xPos = 0;
        BTNs[2].yPos = 1;

        BTNs[3].xPos = 1;
        BTNs[3].yPos = 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
