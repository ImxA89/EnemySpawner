using System.Collections;
using UnityEngine;

public class SpawnerRandomizer : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;

    private void Start()
    {
        StartCoroutine(SpawnMobs());
    }

    private IEnumerator SpawnMobs()
    {
        float delayTime = 2f;
        bool isWorking = true;
        WaitForSeconds delay = new WaitForSeconds(delayTime);

        while (isWorking)
        {
            _spawners[Random.Range(0, _spawners.Length)].CreatEnemy();

            yield return delay;
        }
    }
}
