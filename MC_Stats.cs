using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Xml.Linq;


namespace DarkestBone {
    public class MC_Stats : MonoBehaviour
    {
        public GameObject MC;
        Monster_Stats Monster_Stats = new Monster_Stats();



        public string MC_Name;
        public int MC_Health;
        public int MC_Willpower;
        public int MC_Body;
        public int MC_Strength;
        public int MC_Speed;
        public int MC_Skill;
        public int MC_Intuition;
        public int MC_Faith;
            

        public void Start()
    {

        XDocument Xdoc = XDocument.Load("D:\\unity projects\\DarkestBone\\Assets\\MC_Stats.xml");
        XElement Stats = Xdoc.Element("Stats");
        foreach (XElement EStats in Stats.Elements("EStats"))
        {
            /*Reference
            //              __
            //              ||  
            //              ||
            //              \/
            //
            //XElement Name = EStats.Element("Name");
            //Debug.Log(Name.Value);
            */

            XElement Name = EStats.Element("Name");
            XElement HP = EStats.Element("Health");
            XElement WIL = EStats.Element("Willpower");
            XElement BDY = EStats.Element("Body");
            XElement STR = EStats.Element("Strength");
            XElement SPD = EStats.Element("Speed");
            XElement SKL = EStats.Element("Skill");
            XElement INT = EStats.Element("Intuition");
            XElement FTH = EStats.Element("Faith");
            MC_Name = Name.Value;
            int.TryParse(HP.Value, out MC_Health);
            int.TryParse(STR.Value, out MC_Strength);
            int.TryParse(WIL.Value, out MC_Willpower);
            int.TryParse(BDY.Value, out MC_Body);
            int.TryParse(SPD.Value, out MC_Speed);
            int.TryParse(SKL.Value, out MC_Skill);
            int.TryParse(INT.Value, out MC_Intuition);
            int.TryParse(FTH.Value, out MC_Faith);
        }
                {
             //"Unit test"
             Debug.Log($" MC name = {MC_Name}.\n Health = {MC_Health}");
            }

        

    }
    public void Attack()
    {
           
            bool check=false;
            //if (MC_Strength == 3)
            { Monster_Stats.Monster_Health = Monster_Stats.Monster_Health - MC_Strength;
                //Debug.Log($" {MC_Name} attacking {Monster_Stats.name} and deal {MC_Strength} damage. {Monster_Stats.Monster_Name} have {Monster_Stats.Monster_Health} HP now.");
                Debug.Log($"{MC_Strength} and {Monster_Stats.Monster_Strength}"); 
            }
    }
    
    public void Update()
    {

    }
}
}