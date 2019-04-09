using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonManager : MonoBehaviour {
    public string gameVersion = "1.0";
    public AnimationClip loadingClip;
    public Animator loadingAnimator;

    public void Connect () {
        PhotonNetwork.ConnectUsingSettings(gameVersion);
        StartCoroutine(WaitForConnect());

    }

    public IEnumerator WaitForConnect() {

        while(!PhotonNetwork.connectedAndReady) {
            yield return null;
        }

        print("You did it!");
        yield break;
    }

}