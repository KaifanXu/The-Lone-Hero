using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{

    private GameObject player_cube;
    // Start is called before the first frame update
    void Start()
    {
        player_cube = GameObject.FindGameObjectWithTag("Player");
        Physics.IgnoreCollision(player_cube.GetComponent<Collider>(), GetComponent<Collider>());
    }

    
}
