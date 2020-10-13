using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * 150;
        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * 150;

        transform.Rotate(Vector3.up * x);
        transform.Rotate(Vector3.left * y);
    }
}
