using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Choosing_enemy : MonoBehaviour
{
    public Material redMaterial;
    public Material originMaterial;
    public GameObject Monster_1;
    public GameObject Monster_2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Monster_line_1")
                {
                    Monster_1.GetComponent<Renderer>().material = redMaterial;


                }
                else if (hit.transform.name != "Monster_line_1" || hit.transform.name != "Monster_line_2") { Monster_1.GetComponent<Renderer>().material = originMaterial; }
                
                if (hit.transform.name == "Monster_line_2")
                {
                    Monster_2.GetComponent<Renderer>().material = redMaterial;


                }
                else if (hit.transform.name != "Monster_line_1" || hit.transform.name != "Monster_line_2") { Monster_2.GetComponent<Renderer>().material = originMaterial; }
            }
        }
    }
}
