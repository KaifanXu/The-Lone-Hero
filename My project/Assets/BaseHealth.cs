using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        
        Destroy(gameObject);
    }
}
