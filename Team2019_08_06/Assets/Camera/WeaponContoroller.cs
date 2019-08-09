using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponContoroller : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float yRotation = Input.GetAxis("Mouse Y");

        this.transform.Rotate(0, yRotation, 0);
    }
}
