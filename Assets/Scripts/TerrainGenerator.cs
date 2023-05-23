using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject[] hazards;
    public int hazardCount;
    public float startWait;
    public float spawnWait;
    public float waveWait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        for(int i = 0; i < hazardCount; i++){
            GameObject hazard = hazards[Random.Range(0, hazards.Length)];
            Vector3 spawnPosition = new Vector3(Random.Range(-16.0f, 16.0f),Random.Range(-4.0f, 4.0f), 15.0f);
            Instantiate(hazard, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
        }
        yield return new WaitForSeconds(waveWait);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
