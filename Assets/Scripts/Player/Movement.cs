using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Vector3 playerMove = new(move, 0, 0);
        _rigidbody.velocity = _speed * Time.deltaTime * playerMove;

        if (move < 0)
        {
            _animator.SetBool("IsStrafeLeft", true);
            _animator.SetBool("IsStrafeRight", false);
            return;
        }
        if (move > 0)
        {
            _animator.SetBool("IsStrafeLeft", false);
            _animator.SetBool("IsStrafeRight", true);
            return;
        }
        
        _animator.SetBool("IsStrafeLeft", false);
        _animator.SetBool("IsStrafeRight", false);
    }
}
