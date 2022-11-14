using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _height;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _animator.SetBool("runLeft", true);
            _spriteRenderer.flipX = true;
        }
        else
        {
            _animator.SetBool("runLeft", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _animator.SetBool("runRight", true);
            _spriteRenderer.flipX = false;
        }
        else
        {
            _animator.SetBool("runRight", false);
        }

        if (Input.GetKey(KeyCode.E))
        {
            _animator.SetBool("hardFlex", true);
        }
        else
        {
            _animator.SetBool("hardFlex", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, _height * Time.deltaTime, 0);
        }
    }
}
