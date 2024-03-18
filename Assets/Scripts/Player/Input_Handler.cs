using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Input_Handler : MonoBehaviour
{
    [SerializeField] private UnityEvent<Vector2> _onMove = new();
    public Rigidbody rb;
    public bool playerIsOnGround = true;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()

    {

        _onMove?.Invoke(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetKeyDown("space") && playerIsOnGround)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            playerIsOnGround = false;

        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            playerIsOnGround = true;
        }
    }
}
