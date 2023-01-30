using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choosing : MonoBehaviour
{
    public Material greenMaterial;
    public Material originMaterial;
    public GameObject Char;

    void Start()
    {


    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "MC_line")
                {
                    GetComponent<Renderer>().material = greenMaterial;


                }
                else if (hit.transform.name != "MC_line") { GetComponent<Renderer>().material = originMaterial; }
            }
        }
    }
}
