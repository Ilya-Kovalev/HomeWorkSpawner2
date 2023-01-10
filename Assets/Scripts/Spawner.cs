using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _startTime;
    [SerializeField] private Enemy _prefab;

    public Transform spawnPoint;

    private float _timeBetweenSpawns = 6;
    private float _totalGameTime = 0;

    private void Start()
    {
        _totalGameTime = _timeBetweenSpawns - _startTime;
    }

    private void Update()
    {
        _totalGameTime += Time.deltaTime;

        if(_totalGameTime >= _timeBetweenSpawns) 
        {
            Instantiate(_prefab, spawnPoint.transform.position, Quaternion.identity);
            _totalGameTime = 0;
        }
    }
}
