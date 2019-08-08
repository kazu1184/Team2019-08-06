using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Animator>().SetBool("WalkF", true);
            transform.Translate(0, 0, 0.03f);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("WalkF", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Animator>().SetBool("WalkB", true);
            transform.Translate(0, 0, -0.03f);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("WalkB", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Animator>().SetBool("WalkL", true);
            transform.Translate(-0.02f, 0, 0);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("WalkL", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Animator>().SetBool("WalkR", true);
            transform.Translate(0.02f, 0, 0);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("WalkR", false);
        }



    }
}
