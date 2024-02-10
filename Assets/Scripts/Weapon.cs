using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] float _throwSpeed;

    private bool _throw;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_throw)
        {
            _rigidbody.AddForce(Vector2.up*_throwSpeed);
            _throw = false;
        }
    }

    public void Throw()
    {
        _throw = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(_rigidbody);
        transform.position = collision.contacts[0].point;
        transform.SetParent(collision.transform);
    }
}
