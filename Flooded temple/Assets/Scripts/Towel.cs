using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towel : MonoBehaviour, IInteractable
{
    public GameObject bathWater;
    public GameObject bathLava;
    public GameObject elemOrb;
    public GameObject scroll;
    public GameObject text;

    public void Interact() {
        Debug.Log("woosh");
        bathWater.GetComponent<Animator>().SetTrigger("BathDrain");
        bathLava.GetComponent<Animator>().SetTrigger("BathDrain");
        elemOrb.GetComponent<Animator>().SetTrigger("BathDrain");
        scroll.GetComponent<Animator>().SetTrigger("BathDrain");
        text.SetActive(false);
    }
}
