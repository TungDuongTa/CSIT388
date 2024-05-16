using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class secretWall : MonoBehaviour {
    [Tooltip ("Object to disable")]
    public GameObject wall;
    [Tooltip ("Books")]
    public XRGrabInteractable book1Interactable;
    public XRGrabInteractable book2Interactable;
    public XRGrabInteractable book3Interactable;
    [Tooltip ("Sockets")]
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public XRSocketInteractor socket3;
    [Tooltip("Sound to play when successfull, optional")]
    public PlayQuickSound sound = null;


    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        if (wall.activeSelf && socket1.interactablesSelected.Contains(book1Interactable) && socket2.interactablesSelected.Contains(book2Interactable) && socket3.interactablesSelected.Contains(book3Interactable)) {
            if (sound != null) {
                sound.Play();
            }
            wall.SetActive(false);
        } else if(!wall.activeSelf && (!socket1.interactablesSelected.Contains(book1Interactable) || !socket2.interactablesSelected.Contains(book2Interactable) || !socket3.interactablesSelected.Contains(book3Interactable))) {
            wall.SetActive(true);
        }
    }
}
