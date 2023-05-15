using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private Vector3 _direction;
    private Rigidbody _physics;

    void Start()
    {
        _physics = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _direction = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        transform.localPosition += _direction * speed * Time.deltaTime;

        transform.localPosition =
            new Vector3(
                Mathf.Clamp(transform.localPosition.x, -1f, 1f),
                transform.localPosition.y,
                transform.localPosition.z);
    }
}