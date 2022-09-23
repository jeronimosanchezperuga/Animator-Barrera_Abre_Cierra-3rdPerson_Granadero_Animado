using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreraABEScript : MonoBehaviour
{
    [SerializeField]Animator anim;

    void OnTriggerEnter()
    {
        anim.SetBool("ObjetoEnRango",true);
    }
    void OnTriggerExit()
    {
        anim.SetBool("ObjetoEnRango", false);
    }

}
