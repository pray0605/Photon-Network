using TMPro;
using Photon.Pun;
using UnityEngine;

public class Controller : MonoBehaviourPun
{
    [SerializeField] float mouseX;
    [SerializeField] float speed;

    [SerializeField] Vector3 direction;
    [SerializeField] Camera temporaryCamera;

    void Start()
    {
        // 현재 플레이어가 나 자신이라면
        if(photonView.IsMine)
        {
            Camera.main.gameObject.SetActive(false);
        }
        else
        {
            temporaryCamera.enabled = false;
            GetComponentInChildren<AudioListener>().enabled = false;
        }
    }

    void Update()
    {
        
    }
}
