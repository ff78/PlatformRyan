using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    protected Animator animator;

    protected PlayerStateMachine playerStateMachine;

    protected PlayerInput playerInput;

    protected PlayerController player;
    public void Initialize(Animator animator, PlayerInput playerInput,PlayerController player, PlayerStateMachine playerStateMachine)
    {
        this.animator = animator;
        this.playerInput = playerInput;
        this.player = player;
        this.playerStateMachine = playerStateMachine;
    }

    public virtual void OnEnter()
    {
    }

    public virtual void OnExit()
    {
    }

    public virtual void OnUpdate()
    {
    }

    public virtual void OnFixedUpdate()
    {
    }
}