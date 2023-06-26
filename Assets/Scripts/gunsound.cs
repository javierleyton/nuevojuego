using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunsound : MonoBehaviour
{
    public AudioSource gunSound;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gunSound.enabled = true;
        }
        else
        {
            gunSound.enabled = false;
        }

    }
}
