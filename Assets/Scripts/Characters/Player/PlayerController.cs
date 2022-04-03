using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput _input;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _input.EnablePlayerInput();
    }

    public void Move(float speed)
    {
        SetVelocityX(speed * _input.AxesX);
        if (_input.Move)
        {
            transform.localScale = new Vector3(_input.AxesX, 1);
        }
    }

    public void SetVelocity(Vector3 velocity)
    {
        _rigidbody.velocity = velocity;
    }

    public void SetVelocityX(float velocityX)
    {
        _rigidbody.velocity = new Vector3(velocityX, _rigidbody.velocity.y);
    }

    public void SetVelocityY(float velocityY)
    {
        _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, velocityY);
    }
}