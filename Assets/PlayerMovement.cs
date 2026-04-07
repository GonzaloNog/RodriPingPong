using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputPlayer();
    }
    private void InputPlayer()
    {
        float vertical = Input.GetAxis("Vertical");
        _rb.linearVelocity = new Vector2(0.0f, vertical * _speed);
    }
}
