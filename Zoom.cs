using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    Vector3 nowVector;
    Vector3 maxVector;
    Vector3 minVector;
    Vector3 originalVector;
    void Start()
    {
        //Vector3 maxVector = new Vector3(-544.5007f, 426.3528f, -39.80762f);
        //Vector3 minVector = new Vector3(-601.6102f, 459.6728f, 15.87002f);
        Vector3 originalVector = new Vector3(3.09f, 4.21f, 2.03f);
        transform.position = originalVector;
    }


    void Update()
    {
        float mw = Input.GetAxis("Mouse ScrollWheel");
        if (mw > 0.1)
        {
            transform.position += transform.forward * Time.deltaTime * 5000;
            mw = 0;
            if (Vector3.Distance(nowVector, originalVector) <= 0f) { transform.position = new Vector3(3.73f, 3.63f, 1.41f); }
        }

        else if (mw < -0.1)
        {
            transform.position -= transform.forward * Time.deltaTime * 5000;
            mw = 0;
            if (Vector3.Distance(nowVector, originalVector) <= 0f) { transform.position = new Vector3(3.09f, 4.21f, 2.03f); }
        }
    }
}
