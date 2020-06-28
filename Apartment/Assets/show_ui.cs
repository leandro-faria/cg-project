  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_ui : MonoBehaviour {

    public GameObject uiObject;
    public Text txt;

    void Start()
    {
        uiObject.SetActive(false);
    }

	void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            txt.text = "Game Over D':";
        }
	}
    
}