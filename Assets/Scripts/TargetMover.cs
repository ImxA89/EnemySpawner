using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private int _speed;

    private Transform[] _waypoints;
    private int _currentPointIndex = 0;

    private void Start()
    {
        _waypoints = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
            _waypoints[i] = _path.GetChild(i);
    }

    private void Update()
    {
        Move();

        if (FindOutWaypointReached())
            ChangeWaypoint();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards
            (transform.position, _waypoints[_currentPointIndex].position, _speed*Time.deltaTime);
    }

    private bool FindOutWaypointReached ()
    {
        bool isReached = false;

        if (transform.position == _waypoints[_currentPointIndex].position)
            isReached = true;

        return isReached;
    }

    private void ChangeWaypoint()
    {
        _currentPointIndex++;
        _currentPointIndex = _currentPointIndex%_waypoints.Length;
    }
}
