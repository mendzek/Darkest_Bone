using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class Button_Magic : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Sprite onButton;
    public Sprite originMaterial;
    public Sprite click;
    void Start()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Image>().sprite = onButton;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Image>().sprite = originMaterial;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        GetComponent<Image>().sprite = click;
    }

    void Update()
    {


    }
}
