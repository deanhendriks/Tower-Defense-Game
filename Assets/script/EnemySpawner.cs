using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemyPrefeb;
    public Transform SpawnPoint;
    public AudioSource audioSource;
    public AudioClip AudioClip;
    public float timeBetweenWaves = 5f;
    private float countdown = 3f;
    private int WaveNumber = 1;

    void Start() 
    {
          
    }
    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < WaveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

        WaveNumber++;
        countdown += 5f;
    }

    void SpawnEnemy()
    {
        audioSource.PlayOneShot(AudioClip);
        Instantiate(enemyPrefeb, SpawnPoint.position, SpawnPoint.rotation);
    }

    
}
