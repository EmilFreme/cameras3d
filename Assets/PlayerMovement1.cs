using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public CharacterController cc;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        Vector3 direction = transform.right * x + transform.forward * z ;

        cc.Move(direction * Time.deltaTime * 3);
    }
}
