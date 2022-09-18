
using UnityEngine;
using UnityEngine.AI;

public class EnemyPath : MonoBehaviour
{

    public NavMeshAgent enemy;
    public Transform playerBase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(playerBase.position);
    }
}
