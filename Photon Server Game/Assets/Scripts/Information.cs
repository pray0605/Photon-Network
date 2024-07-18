using TMPro;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Information : MonoBehaviourPunCallbacks
{
    public TextMeshProUGUI roominformation;

    public void ConnectRoom()
    {
        PhotonNetwork.JoinRoom(roominformation.text);
    }

    public void RoomData(string name, int currentStaff, int maxStaff)
    {
        roominformation.fontSize = 50;
        roominformation.color = Color.black;
        roominformation.alignment = TextAlignmentOptions.Center;
        roominformation.text = name + " ( " + currentStaff + " / " + maxStaff + ")";
    }
}
