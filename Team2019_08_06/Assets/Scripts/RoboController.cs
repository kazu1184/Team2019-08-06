using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoboController : MonoBehaviour
{
    PhotonView m_photonView = null;

    // Start is called before the first frame update
    void Start()
    {
        m_photonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        // 持ち主でないのなら制御させない
        if (!m_photonView.IsMine)
        {
            Debug.Log("yes");
            return;
        }

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
