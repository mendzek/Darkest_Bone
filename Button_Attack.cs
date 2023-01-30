using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace DarkestBone
{
    public class Button_Attack : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        public Sprite onButton;
        public Sprite originMaterial;
        public Sprite click;
        MC_Stats MC_Stats = new MC_Stats();
        Monster_Stats Monster_Stats = new Monster_Stats();
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
            MC_Stats.Attack();
        }
        void Update()
        {

        }



    }
}
