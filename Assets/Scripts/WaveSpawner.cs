using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public Transform ennemiPrefab;
    public Transform spawnPoint;

    public float tempsPourLesWaves = 5f;
    private float cooldown = 2f;
    private int waveNombre = 0;


    void Update()
    {
        if (cooldown <= 0f)
        {
            StartCoroutine(ApparaitreWaves());
            cooldown = tempsPourLesWaves;
        }

        cooldown -= Time.deltaTime;
    }

    IEnumerator ApparaitreWaves()
    {
        waveNombre++;

        for (int i = 0; i < waveNombre; i++)
        {
            ApparaitreEnnemi();
            yield return new WaitForSeconds(0.5f);
        }

    }

    void ApparaitreEnnemi()
    {
        Instantiate(ennemiPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
