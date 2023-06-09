using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoulder : MonoBehaviour
{
    public GameObject boulderPrefab;
    public GameObject boulderTarget;
    public float spawnInterval;
    public int spawnRadius;
    private Vector2 spawnCenter;
    
    // Start is called before the first frame update
    void Start() {
       spawnCenter = transform.position;
       StartCoroutine(SpawnBoulders());
       StartCoroutine(ReduceSpawnInterval());
    }

    // Update is called once per frame
    void Update() {
        
    }

    private IEnumerator SpawnBoulders() {
        while(true) {
            yield return new WaitForSeconds(spawnInterval);
            int randomAngle = Random.Range(0, 359);
            float randomAngleRadians = (float)randomAngle * Mathf.Deg2Rad;
            Vector2 randomPos = new Vector2 (
                Mathf.Sin(randomAngleRadians) * spawnRadius,
                Mathf.Cos(randomAngleRadians) * spawnRadius
            );
            Vector2 spawnPos = spawnCenter + randomPos;
            Debug.Log("spawning object at x:" + spawnPos.x  + " y:" + spawnPos.y);
            GameObject boulderObject = Instantiate(boulderPrefab, spawnPos, Quaternion.identity);
            FollowTarget boulder = boulderObject.GetComponent<FollowTarget>();
            boulder.target = boulderTarget;
        }
    }

    private IEnumerator ReduceSpawnInterval() {
        while(true) {
            yield return new WaitForSeconds(3);
            spawnInterval *= 0.95f;
        }
    }
}
