using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towel : MonoBehaviour, IInteractable
{
    public GameObject bathWater;

    public void Interact() {
        Debug.Log("woosh");
        bathWater.GetComponent<Animator>().SetTrigger("BathDrain");
    }
}
