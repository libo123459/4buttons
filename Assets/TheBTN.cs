using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TheBTN : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerDownHandler,IPointerUpHandler{
    public int xPos = 0;
    public int yPos = 0;
    public bool isSelected = false;
    public Text _text;
    Manage _manage;
    float pressScale = 0.7f;
    public void OnPointerUp(PointerEventData eventData)
    {
        _manage.PressUpBtn();
    }

    public void OnPointerDown(PointerEventData eventData)
    {        
        isSelected = true;

        Manage.isStarted = true;
        Manage.updateTheXandY(xPos,yPos);
        Manage.Nums.Add(_text);
        
        this.transform.localScale = new Vector3(pressScale, pressScale, pressScale);
    }

    public void OnPointerEnter(PointerEventData eventData)//悬停选中
    {

        if (Manage.pressNum < 3)
        {
            if (Manage.isStarted == true && isSelected == false)
            {
                if (this.xPos == Manage.xPre || this.yPos == Manage.yPre)
                {
                    if (this.xPos == Manage.xPre && this.yPos == Manage.yPre)
                    {

                    }
                    else {

                        isSelected = true;
                        
                        this.transform.localScale = new Vector3(pressScale, pressScale, pressScale);

                        Manage.updateTheXandY(xPos, yPos);
                        Manage.Nums.Add(_text);
                        Manage.pressNum++;
                    }
                    
                }
            }
        }        
    }
    
    public void OnPointerExit(PointerEventData eventData)//悬停离开
    {
        isSelected = false;
        this.transform.localScale = new Vector3(1, 1, 1);
    }

    // Use this for initialization
    void Start () {
        _manage = GameObject.Find("Manage").GetComponent<Manage>();
        _text = this.transform.GetChild(0).GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
