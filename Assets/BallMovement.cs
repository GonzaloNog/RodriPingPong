using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = new Vector2(-1f, _speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Limit"))
        {
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, -_rb.linearVelocity.y);
        }
        else if (collision.CompareTag("Paddle"))
        {
            _rb.linearVelocity = new Vector2(-_rb.linearVelocity.x, _rb.linearVelocity.y);
        }
    }
}
