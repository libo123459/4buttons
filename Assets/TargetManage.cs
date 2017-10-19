using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetManage : MonoBehaviour {
    public List<Cube> CubeList = new List<Cube>();
    Manage manage;
    void updateCubes()
    {
        int suit = Random.Range(1, 5);
        CubeList[0].suit = suit;
        if (suit == 1 || suit == 4)
        {
            CubeList[1].suit = randomFromTwo(2,3);
            CubeList[2].suit = randomFromTwo(1,4);
            CubeList[3].suit = randomFromTwo(2,3);
        }
        if (suit == 2 || suit == 3)
        {
            CubeList[1].suit = randomFromTwo(1, 4);
            CubeList[2].suit = randomFromTwo(2, 3);
            CubeList[3].suit = randomFromTwo(1, 4);
        }
    }

    void displayCubesSuit()
    {
        for (int i = 0; i < CubeList.Count; i++)
        {
            CubeList[i].GetComponent<Image>().sprite = Resources.Load<Sprite>(CubeList[i].suit.ToString());
        }
    }

    int randomFromTwo(int A,int B)
    {
        List<int> array = new List<int>();
        array.Add(A);
        array.Add(B);
        int index = Random.Range(0,2);
        return array[index];
    }

    void MatchTheBTNs(TheBTN _btn)
    {
        int index = Manage.pressNum - 1;
        if (manage.BTNs[index].suit == CubeList[index].suit)
        {
            if (index < 3)
            {
                CubeList[index].transform.localScale = new Vector3(0.7f,0.7f,0.7f);
            }
        }
    }

	// Use this for initialization
	void Start () {
        manage = GameObject.Find("Manage").GetComponent<Manage>();
        updateCubes();
        displayCubesSuit();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
