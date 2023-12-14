using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningAnimals : MonoBehaviour
{
    [SerializeField] private List<GameObject> _animalprefabs;
    [SerializeField] private float _spawningTime;


    private void Update()
    {
        _spawningTime -= Time.deltaTime;
        if(_spawningTime < 0)
        {
            RandomPosition();
            int random = Random.Range(1, _animalprefabs.Count);
            Instantiate(_animalprefabs[random], transform.position, Quaternion.Euler(0, -180, 0));
            _spawningTime = 2;
        }
    }

    private void RandomPosition()
    {
        float rand = Random.Range(-25, 26);

        transform.position = new (rand, 0, 0);
    }
}
