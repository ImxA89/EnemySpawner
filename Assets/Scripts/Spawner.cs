using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Mover _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnMobs());
    }

    private IEnumerator SpawnMobs()
    {
        WaitForSeconds _waitForTwoSecond = new WaitForSeconds(2f);
        bool isWorking = true;

        while (isWorking)
        {
            Quaternion rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), Random.Range(0f, 360f));
            Instantiate(_enemyPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, rotation);

            yield return _waitForTwoSecond;
        }
    }
}
