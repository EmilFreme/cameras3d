using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCamera : MonoBehaviour
{

    public Camera target;

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Wololo");
        if (other.CompareTag("Player"))
        {
            target.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target.enabled = true;
        }
    }
}
