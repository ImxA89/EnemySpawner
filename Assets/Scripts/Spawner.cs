using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnMobs());
    }

    private IEnumerator SpawnMobs()
    {
        WaitForSeconds _waitForTwoSecond = new WaitForSeconds(2f);
        GameObject enemy;

        while (true)
        {
            enemy = Instantiate(_enemyPrefab);
            enemy.transform.position =_spawnPoints[Random.Range(0, _spawnPoints.Length)].position;
            enemy.transform.Rotate(0,Random.Range(0,360),Random.Range(0,90));

            yield return _waitForTwoSecond;
        }
    }
}
