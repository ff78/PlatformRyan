using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu (menuName = "Data/StateMachine/PlayerState/Idle", fileName = "PlayerState_Idle")]
public class PlayerState_Idle : PlayerState
{
    public override void OnEnter()
    {
        base.OnEnter();
        animator.Play($"Idle");
    }

    public override void OnUpdate()
    {
        if (playerInput.Move)
        {
            playerStateMachine.SwitchState(typeof(PlayerState_Run));
        }
        
    }

    public override void OnFixedUpdate()
    {
        player.SetVelocityX(0f);
    }
}
