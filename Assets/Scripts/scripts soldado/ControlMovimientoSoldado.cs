using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ControlMovimientoSoldado : MonoBehaviour
{
    public Animator anim;
    public float velRotacion;

    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                anim.SetBool("camina", true);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("camina", false);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                anim.SetBool("retrocede", true);
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                anim.SetBool("retrocede", false);
            }


            if (!anim.GetBool("camina") && !anim.GetBool("retrocede"))
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    anim.SetBool("giraIzq", true);
                }
                if (Input.GetKeyUp(KeyCode.A))
                {
                    anim.SetBool("giraIzq", false);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    anim.SetBool("giraDer", true);
                }
                if (Input.GetKeyUp(KeyCode.D))
                {
                    anim.SetBool("giraDer", false);
                }
            }
            else
            {
                anim.SetBool("giraDer", false);
                anim.SetBool("giraIzq", false);
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Rotate(0, velRotacion, 0);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Rotate(0, -velRotacion, 0);
                }
            }
        }


    }
}
