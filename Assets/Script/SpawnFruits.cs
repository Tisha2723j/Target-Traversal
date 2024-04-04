using System.Collections;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2f;

    IEnumerator Start()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnInterval);
        while (true)
        {
            Instantiate(fruitPrefab, spawnPoint.position, Quaternion.identity);
            yield return wait;
        }
    }
}