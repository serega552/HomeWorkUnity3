using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawner : MonoBehaviour
{
    [SerializeField] private Transform _pointsCoin;
    [SerializeField] private MoneyPickUp _coin;

    private Transform[] _points;

    void Start()
    {
        _points = new Transform[_pointsCoin.childCount];

        for (int i = 0; i < _pointsCoin.childCount; i++)
        {
            _points[i] = _pointsCoin.GetChild(i);
        }

        for (int i = 0; i < _points.Length; i++)
        {
            Instantiate(_coin, _points[i].position, Quaternion.identity);
        }
    }
}