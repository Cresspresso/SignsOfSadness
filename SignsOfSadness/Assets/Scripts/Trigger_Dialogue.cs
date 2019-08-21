using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Dialogue : MonoBehaviour
{

    public GameObject UIObject;
    void Start()
    {
        UIObject.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            UIObject.SetActive(true);

        }

    }
}