using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private uint _speed;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}
