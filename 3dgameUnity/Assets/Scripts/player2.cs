using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyTree;
    [SerializeField] KeyCode keyFour;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if(Input.GetKey(keyTree))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if(Input.GetKey(keyFour))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
    }
}
