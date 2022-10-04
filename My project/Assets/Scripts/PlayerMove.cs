﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    public float speed = 6f;
    public CharacterController contoller;

    public GameObject wall;
    public int numOfWall = 3, numOfTrap = 100;
    public int wallCapacity = 3;
    public float setWallCoolDown = 1.0f, setTrapCoolDown = 1.0f, dashCoolDown = 5.0f;
    public float wallExistTime = 6.0f;
    public float trapExistTime = 10.0f;
    private float wallTimer = 2.0f;
    private float trapTimer = 6.0f;
    public GameObject wallHolder;

    public navMeshSurface[] surfaces;
    // Update is called once per frame
    void Update()
    {
        float movingX = Input.GetAxis("Horizontal");
        float movingY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movingX, 0.0f, movingY).normalized;

        if (movement.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            contoller.Move(movement * speed * Time.deltaTime);
        };
        NewSetWall();
    }

    void NewSetWall()
    {

        
            wallTimer += Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.J) && numOfWall > 0)
            {
                if (wallHolder.transform.childCount >= wallCapacity)
                {
                    Destroy(wallHolder.transform.GetChild(0).gameObject);
                };

                GameObject go = Instantiate(wall, transform.position, Quaternion.identity);
                go.transform.parent = wallHolder.transform;
                numOfWall--;

                for (int i = 0; i < surfaces.Length; i++)
                {
                    surfaces[i].BuildNavMesh();
                };

        };
        
    }
}
