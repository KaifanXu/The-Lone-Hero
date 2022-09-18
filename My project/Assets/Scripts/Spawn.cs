
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Prefab;


    //public float spawnDelayMin;
    //public float spawnDelayMax;
    public int enemyNum;
    public float spawnTime;
    public float spawnDelay;

    private float spawnTimer;
    private Transform spawnPoint;

    private void Awake()
    {
        //spawnTimer = Random.Range(spawnDelayMin, spawnDelayMax);
        spawnTimer = spawnTime;
        spawnPoint = transform;
    }

    // Update is called once per frame
    void Update()
    {

        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0 && enemyNum > 0)
        {
            Instantiate(Prefab, spawnPoint.position, spawnPoint.rotation);
            //spawnTimer = Random.Range(spawnDelayMin, spawnDelayMax);
            spawnTimer = spawnTime + spawnDelay;

            enemyNum--;
        }
        if (enemyNum == 0)
            Destroy(this.gameObject);
    }


}