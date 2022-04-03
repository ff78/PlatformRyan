using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerInputActions _playerInputActions;

    private Vector2 axes => _playerInputActions.Gameplay.Axes.ReadValue<Vector2>();

    public bool Jump => _playerInputActions.Gameplay.Jump.WasPressedThisFrame();
    public bool StopJump => _playerInputActions.Gameplay.Jump.WasReleasedThisFrame();
    public bool Move => axes.x != 0f;
    public float AxesX => axes.x;
    
    private void Awake()
    {
        _playerInputActions = new PlayerInputActions();
    }

    public void EnablePlayerInput()
    {
        _playerInputActions.Gameplay.Enable();
    }
}
