using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _target;

    public void CreatEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab,transform.position, Quaternion.identity);
        enemy.TakeTarget(_target);
    }
}
