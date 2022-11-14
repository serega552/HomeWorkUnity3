using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private Transform[] _points;
    private int _currentPosition;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _points.Length; i++)
        {
            _points[i] = _path.GetChild(i).transform;
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPosition];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPosition++;
            if (_currentPosition >= _points.Length)
            {
                _spriteRenderer.flipX = true;
                _currentPosition = 0;
            }
            else
            {
                _spriteRenderer.flipX = false;
            }
        }
    }
}
