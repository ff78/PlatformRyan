using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "PlayerState_Run")]
public class PlayerState_Run : PlayerState
{
    [SerializeField] private float runSpeed = 5f;

    [SerializeField] private float accelration = 5f;

    public override void OnEnter()
    {
        animator.Play($"Run");

        currentSpeed = runSpeed;
    }

    public override void OnUpdate()
    {
        if (!playerInput.Move)
        {
            playerStateMachine.SwitchState(typeof(PlayerState_Idle));
        }

        currentSpeed = Mathf.MoveTowards(currentSpeed, runSpeed, accelration * Time.deltaTime);
    }

    public override void OnFixedUpdate()
    {
        player.Move(currentSpeed);
    }
}