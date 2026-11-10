using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    private bool _isChasing =false;
    private Transform _playerTransform;

    private void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            _playerTransform = player.transform;
        }
    }
    private void Update()
    {
        if (_isChasing && _playerTransform != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed * Time.deltaTime);
        }
    }
    public void StartChasing()
    {
        _isChasing = true;
    }
    public void StopChasing()
    {
        _isChasing = false;
    }
}
