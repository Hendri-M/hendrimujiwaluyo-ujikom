using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
 
    [SerializeField] private GameObject _shootingPoint;
    [SerializeField] private GameObject _foodPrefabs;
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            _audioSource.PlayOneShot(_audioClip);
            _animator.SetBool("IsThrow", true);
            Instantiate(_foodPrefabs, _shootingPoint.transform.position, Quaternion.identity);
            return;
        }
        _animator.SetBool("IsThrow", false);
    }
}
