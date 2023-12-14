using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFood : MonoBehaviour
{
    private Animals _animal;

    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _lifeTime;
    [SerializeField] private Collider _collider;

    private void Awake()
    {
        _animal = GetComponent<Animals>();
    }
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _lifeTime -= Time.deltaTime;
        _rigidbody.velocity = _speed * Time.deltaTime * Vector3.forward;

        if(_lifeTime < 0)
        {
            _lifeTime = 0;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == _collider)
        {
            Debug.Log("HIT");
        }
    }
}
