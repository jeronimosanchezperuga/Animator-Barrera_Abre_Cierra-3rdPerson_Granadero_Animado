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

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        Debug.Log("Ingreso detectado");
        anim.SetBool("estaAdentro", true);
    }

    void OnTriggerExit()
    {
        Debug.Log("Salida detectada");
        anim.SetBool("estaAdentro", false);
    }
}
