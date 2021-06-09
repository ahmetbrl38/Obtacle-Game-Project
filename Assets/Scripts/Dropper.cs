using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    float timeToWait;
    float timeToWait2;
    float timeToWait3;

    MeshRenderer renderer;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {

        timeToWait = Random.Range(4f, 9f);
        timeToWait2 = Random.Range(9f, 14f);
        timeToWait3 = 3f;//Random.Range(24f, 35f);

        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.name == "Roller1" || gameObject.name == "Roller2" || gameObject.name == "Dropper1")
        {
            if (Time.time > timeToWait)
            {

                renderer.enabled = true;
                rigidbody.useGravity = true;


            }

        }

        if (gameObject.name == "Dropper2" || gameObject.name == "Roller3")
        {
        
        if (Time.time > timeToWait2)
        {

            renderer.enabled = true;
            rigidbody.useGravity = true;


        }
        }

        if (gameObject.name == "Dropper3" || gameObject.tag == "LastPart")
        {
            if (Time.time > timeToWait3)
            {

                renderer.enabled = true;
                rigidbody.useGravity = true;


            }

        }

        
        
    }
}
