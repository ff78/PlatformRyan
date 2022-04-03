using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "PlayerState_Run")]
public class PlayerState_Run: PlayerState
{
    [SerializeField] private float runSpeed=5f;
    public override void OnEnter()
    {
        base.OnEnter();
        animator.Play($"Run");
    }

    public override void OnUpdate()
    {
        if (!playerInput.Move)
        {
            playerStateMachine.SwitchState(typeof(PlayerState_Idle));
        }
    }

    public override void OnFixedUpdate()
    {
        player.Move(runSpeed);
    }
}