using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreraScript : MonoBehaviour
{
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
        

    void OnTriggerEnter()
    {
        anim.SetBool("estaAdentro", true);
    }

    void OnTriggerExit()
    {
        anim.SetBool("estaAdentro", false);
    }
}
