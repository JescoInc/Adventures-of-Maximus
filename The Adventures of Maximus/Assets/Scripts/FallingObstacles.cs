using UnityEngine;
using System.Collections;

public class FallingObstacles : MonoBehaviour
{
    public GameObject hazard;
    private float spawnWait = 1f;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (true)
        {
            var xMinMax = Random.Range(-10f, 10f);
            var zMinMax = Random.Range(-6f, 6f);
            Vector3 spawnPosition = new Vector3(xMinMax, 10f, zMinMax);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(hazard, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
            spawnWait -= 0.01f;
            if (spawnWait < 0.05f) spawnWait = 0.05f;
        }
    }
}