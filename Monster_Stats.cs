using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

namespace DarkestBone
{
    public class Monster_Stats : MonoBehaviour
    {

        public string Monster_Name;
        public int Monster_Health;
        public int Monster_Strength;
        

        void Start()
        {
            XDocument Xdoc = XDocument.Load("D:\\unity projects\\DarkestBone\\Assets\\Monster_Stats.xml");
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
                XElement STR = EStats.Element("Strength");
                string Monster_Name = Name.Value;
                int.TryParse(HP.Value, out Monster_Health);
                int.TryParse(STR.Value, out Monster_Strength);
                




                {
                    //"Unit test"
                    Debug.Log($" Monster name = {Monster_Name}.\n Health = {Monster_Health}. \n Strength = {Monster_Strength}.");
                }
            }
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
