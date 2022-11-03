using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class IrALobby : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clickeado");
        PhotonNetwork.Destroy(gameObject);
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel("Loading");
    }

    public override void OnLeftRoom()
    {
        Debug.Log("Salio de la room");
        PhotonNetwork.LoadLevel("Loading");
    }
}
