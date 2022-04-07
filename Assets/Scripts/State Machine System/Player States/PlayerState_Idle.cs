using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Idle", fileName = "PlayerState_Idle")]
public class PlayerState_Idle : PlayerState
{
    [SerializeField] private float decelaration = 5f;

    public override void OnEnter()
    {
        base.OnEnter();
        animator.Play($"Idle");
        currentSpeed = player.MoveSpeed;
    }

    public override void OnUpdate()
    {
        if (playerInput.Move)
        {
            playerStateMachine.SwitchState(typeof(PlayerState_Run));
        }

        currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, decelaration * Time.deltaTime);
    }

    public override void OnFixedUpdate()
    {
        player.SetVelocityX(currentSpeed * player.transform.localScale.x);
    }
}