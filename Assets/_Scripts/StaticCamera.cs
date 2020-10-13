using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCamera : MonoBehaviour
{

    public Camera target;

    private void Start()
    {
        if (Application.isPlaying) GetComponent<Renderer>().enabled = false;
    }

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

    private void OnTriggerStay(Collider other)
    {
        if (Camera.current) return;
        if (other.CompareTag("Player"))
        {
            target.enabled = true;
        }
    }
}
