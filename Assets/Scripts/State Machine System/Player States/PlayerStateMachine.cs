using System;
using System.Collections.Generic;
using State_Machine_System.Base;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateMachine : StateMachine
{
    private Animator _animator;
    private PlayerInput _input;
    private PlayerController _player;
    [SerializeField] private PlayerState[] states;
    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _input = GetComponent<PlayerInput>();
        _player = GetComponent<PlayerController>();
        
        // todo 玩家状态初始化
        stateTable = new Dictionary<Type, IState>(states.Length);
        for (int i = 0; i < states.Length; i++)
        {
            states[i].Initialize(_animator, _input, _player, this);
            stateTable.Add(states[i].GetType(), states[i]);
        }
    }

    private void Start()
    {
        SwitchOn(stateTable[typeof(PlayerState_Idle)]);
    }
}
