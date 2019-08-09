using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    GameObject m_camera;
    [SerializeField]
    Vector3 m_cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        m_camera = GameObject.FindWithTag("MainCamera");
        m_camera.GetComponent<CameraContoroller>().enabled = false;

        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override void OnConnectedToMaster()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsVisible = true;
        roomOptions.MaxPlayers = 2;
        PhotonNetwork.JoinOrCreateRoom("room1", roomOptions, TypedLobby.Default);
    }

    // マッチングが成功した時に呼ばれるコールバック
    public override void OnJoinedRoom()
    {
        // マッチング後、ランダムな位置に自分自身のネットワークオブジェクトを生成する
        var v = new Vector3(0,1,0);
        GameObject avatar = PhotonNetwork.Instantiate("SciFiWarriorHP", v, Quaternion.identity);

        m_camera.transform.parent = avatar.transform;
        m_camera.transform.position = m_cameraPos;

        CameraContoroller temp = m_camera.GetComponent<CameraContoroller>();
        temp.enabled = true;
        temp.InData();
    }
}
