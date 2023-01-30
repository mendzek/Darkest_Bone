using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dices_Roll : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    /* public GameObject Dice1;
    public GameObject Dice2;
    public GameObject Dice3;
    */

    public GameObject DiceWIL;
    public GameObject DiceBDY;
    public GameObject DiceSTR;
    public GameObject DiceSPD;
    public GameObject DiceSKL;
    public GameObject DiceINT;
    public GameObject DiceFTH;
    public GameObject RollButton;
    public GameObject Canvas;
    public Sprite DarkerImage;
    public Sprite OriginalImage;
    public Sprite Click;
    public Vector3 position;
    bool interactWithButton = true;

    void Start()
    {
        Vector3 position = new Vector3(-342, 36, 0);
    }

    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (interactWithButton == true)
        {
            GetComponent<Image>().sprite = DarkerImage;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (interactWithButton == true)
        {
            GetComponent<Image>().sprite = OriginalImage;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (interactWithButton == true)
        {
            RollTheDice1();
            RollTheDice2();
            RollTheDice3();
            interactWithButton = false;
            GetComponent<Image>().sprite = OriginalImage;
        }
    }

    public void RollTheDice1()
    {
        float rand = Random.Range(1, 8);
        Debug.Log(rand);
        if (rand == 1) { GameObject DiceWILnow = Instantiate<GameObject>(DiceWIL, new Vector3(-418f, 13.9f, 0), Quaternion.identity); DiceWILnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 2) { GameObject DiceBDYnow = Instantiate<GameObject>(DiceBDY, new Vector3(-418f, 13.9f, 0), Quaternion.identity); DiceBDYnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 3) { GameObject DiceSTRnow = Instantiate<GameObject>(DiceSTR, new Vector3(-418f, 13.9f, 0), Quaternion.identity); DiceSTRnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 4) { GameObject DiceSPDnow = Instantiate<GameObject>(DiceSPD, new Vector3(-418f, 13.9f, 0), Quaternion.identity); DiceSPDnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 5) { GameObject DiceSKLnow = Instantiate<GameObject>(DiceSKL, new Vector3(-418f, 13.9f, 0), Quaternion.identity); DiceSKLnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 6) { GameObject DiceINTnow = Instantiate<GameObject>(DiceINT, new Vector3(-418f, 13.9f, 0), Quaternion.identity); DiceINTnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 7) { GameObject DiceFTHnow = Instantiate<GameObject>(DiceFTH, new Vector3(-418f, 13.9f, 0), Quaternion.identity); DiceFTHnow.transform.SetParent(Canvas.transform, false); }
    }
    public void RollTheDice2()
    {
        float rand = Random.Range(1, 8);
        Debug.Log(rand);
        if (rand == 1) { GameObject DiceWILnow = Instantiate<GameObject>(DiceWIL, new Vector3(-351f, 13.9f, 0), Quaternion.identity); DiceWILnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 2) { GameObject DiceBDYnow = Instantiate<GameObject>(DiceBDY, new Vector3(-351f, 13.9f, 0), Quaternion.identity); DiceBDYnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 3) { GameObject DiceSTRnow = Instantiate<GameObject>(DiceSTR, new Vector3(-351f, 13.9f, 0), Quaternion.identity); DiceSTRnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 4) { GameObject DiceSPDnow = Instantiate<GameObject>(DiceSPD, new Vector3(-351f, 13.9f, 0), Quaternion.identity); DiceSPDnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 5) { GameObject DiceSKLnow = Instantiate<GameObject>(DiceSKL, new Vector3(-351f, 13.9f, 0), Quaternion.identity); DiceSKLnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 6) { GameObject DiceINTnow = Instantiate<GameObject>(DiceINT, new Vector3(-351f, 13.9f, 0), Quaternion.identity); DiceINTnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 7) { GameObject DiceFTHnow = Instantiate<GameObject>(DiceFTH, new Vector3(-351f, 13.9f, 0), Quaternion.identity); DiceFTHnow.transform.SetParent(Canvas.transform, false); }
    }
    public void RollTheDice3()
    {
        float rand = Random.Range(1, 8);
        Debug.Log(rand);
        if (rand == 1) { GameObject DiceWILnow = Instantiate<GameObject>(DiceWIL, new Vector3(-290.8f, 13.9f, 0), Quaternion.identity); DiceWILnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 2) { GameObject DiceBDYnow = Instantiate<GameObject>(DiceBDY, new Vector3(-290.8f, 13.9f, 0), Quaternion.identity); DiceBDYnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 3) { GameObject DiceSTRnow = Instantiate<GameObject>(DiceSTR, new Vector3(-290.8f, 13.9f, 0), Quaternion.identity); DiceSTRnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 4) { GameObject DiceSPDnow = Instantiate<GameObject>(DiceSPD, new Vector3(-290.8f, 13.9f, 0), Quaternion.identity); DiceSPDnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 5) { GameObject DiceSKLnow = Instantiate<GameObject>(DiceSKL, new Vector3(-290.8f, 13.9f, 0), Quaternion.identity); DiceSKLnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 6) { GameObject DiceINTnow = Instantiate<GameObject>(DiceINT, new Vector3(-290.8f, 13.9f, 0), Quaternion.identity); DiceINTnow.transform.SetParent(Canvas.transform, false); }
        else if (rand == 7) { GameObject DiceFTHnow = Instantiate<GameObject>(DiceFTH, new Vector3(-290.8f, 13.9f, 0), Quaternion.identity); DiceFTHnow.transform.SetParent(Canvas.transform, false); }
    }
}
