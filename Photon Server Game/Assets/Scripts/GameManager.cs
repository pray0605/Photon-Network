using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEditor.Experimental.GraphView;

public class GameManager : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject prefabs;

    public void Awake()
    {
        Create();   
    }

    void Start()
    {
        
    }

    public void Create()
    {
        PhotonNetwork.Instantiate
        (
            "Character",
            RandomPosition(5),
            Quaternion.identity
        );
    }

    public Vector3 RandomPosition(int value)
    {
        Vector3 direction = Random.insideUnitSphere.normalized;

        direction *= value;

        direction.y = 1;

        return direction;
    }
}
