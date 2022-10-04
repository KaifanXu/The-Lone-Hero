
using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyPath : MonoBehaviour
{

    public NavMeshAgent enemy;
    public Transform playerBase;
    // Start is called before the first frame update
    void Start()
    {
        playerBase = GameObject.FindGameObjectWithTag("Base").transform;
    }

    // Update is called once per frame
    void Update()
    {

        enemy.SetDestination(playerBase.position);
    }
}
