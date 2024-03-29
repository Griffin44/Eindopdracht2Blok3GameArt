using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPromptTrigger : MonoBehaviour
{
    public GameObject text;
    

    void OnTriggerEnter(Collider other)
    {
        //this.gameObject.GetComponent<BoxCollider>().enabled = false;
        text.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
