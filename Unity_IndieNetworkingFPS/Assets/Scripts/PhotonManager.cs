using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonManager : MonoBehaviour {
    public string gameVersion = "1.0";
    public string mainRoomName = "Main Room";

    public void Connect () {
        PhotonNetwork.ConnectUsingSettings (gameVersion);
        StartCoroutine (WaitForConnect ());
    }

    public IEnumerator WaitForConnect () {

        while (!PhotonNetwork.connectedAndReady) {
            yield return null;
        }

        print ("You did it!");
        RoomManager();
        yield break;
    }

    void RoomManager () {
        RoomOptions roomOptions = new RoomOptions ();
        roomOptions.MaxPlayers = 0;
        roomOptions.IsOpen = true;
        PhotonNetwork.JoinOrCreateRoom (mainRoomName, roomOptions, TypedLobby.Default);
    }

}