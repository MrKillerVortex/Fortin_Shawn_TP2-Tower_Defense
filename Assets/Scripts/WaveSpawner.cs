using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform ennemiPrefab1;
    public Transform ennemiPrefab2;
    public Transform ennemiPrefab3;
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
        PlayerStats.Rounds++;
        PlayerStats.Vague++;

        for (int i = 0; i < waveNombre; i++)
        {
            ApparaitreEnnemi1();
            ApparaitreEnnemi2();
            ApparaitreEnnemi3();
            yield return new WaitForSeconds(1f);
        }

    }

    void ApparaitreEnnemi1()
    {
        Instantiate(ennemiPrefab1, spawnPoint.position, spawnPoint.rotation);
    }

    void ApparaitreEnnemi2()
    {
        Instantiate(ennemiPrefab2, spawnPoint.position, spawnPoint.rotation);
    }

    void ApparaitreEnnemi3()
    {
        Instantiate(ennemiPrefab3, spawnPoint.position, spawnPoint.rotation);
    }

}
