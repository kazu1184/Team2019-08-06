using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraContoroller : MonoBehaviour
{
    Transform m_verRot;
    Transform m_horRot;
    PhotonView m_photonView = null;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 持ち主でないのなら制御させない
        if (m_photonView != null && !m_photonView.IsMine)
        {
            Debug.Log("yes");
            return;
        }


        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");

        m_verRot.transform.Rotate(0, X_Rotation, 0);
        m_horRot.transform.Rotate(-Y_Rotation , 0, 0);
    }

    public void InData()
    {
        m_verRot = transform.parent;
        m_horRot = GetComponent<Transform>();

        m_photonView = transform.parent.GetComponent<PhotonView>();
    }
}
