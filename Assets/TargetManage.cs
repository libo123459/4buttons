using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManage : MonoBehaviour {
    public List<Cube> CubeList = new List<Cube>();
    void updateCubes()
    {
        int suit = Random.Range(1, 5);
        CubeList[0].suit = suit;
        if (suit == 1 || suit == 4)
        {
            CubeList[1].suit = randomFromTwo(2,3);
            CubeList[2].suit = randomFromTwo(1, 4);
            CubeList[3].suit = randomFromTwo(2,3);
        }
        if (suit == 2 || suit == 3)
        {
            CubeList[1].suit = randomFromTwo(1, 4);
            CubeList[2].suit = randomFromTwo(2, 3);
            CubeList[3].suit = randomFromTwo(1, 4);
        }
    }

    void displayCubesText()
    {
        for (int i = 0; i < CubeList.Count; i++)
        {
            CubeList[i].text.text = CubeList[i].suit.ToString();
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
	// Use this for initialization
	void Start () {
        updateCubes();
        displayCubesText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
