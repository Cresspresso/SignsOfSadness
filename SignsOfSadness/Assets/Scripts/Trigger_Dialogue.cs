using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Dialogue : MonoBehaviour
{

    public GameObject UIObject;
    void Start()
    {
        UIObject.SetActive(false);
        StartCoroutine(BeginThings());
    }

    IEnumerator BeginThings()
    {
        yield return new WaitForSeconds(3);
        UIObject.SetActive(true);
    }
}