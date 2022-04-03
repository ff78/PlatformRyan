using System;
using System.Collections.Generic;
using UnityEngine;

namespace State_Machine_System.Base
{
    public class StateMachine: MonoBehaviour
    {
        private IState currentState;

        protected Dictionary<Type, IState> stateTable;
        
        private void Update()
        {
            currentState.OnUpdate();
        }

        private void FixedUpdate()
        {
            currentState.OnFixedUpdate();
        }

        protected void SwitchOn(IState nextState)
        {
            currentState = nextState;
            currentState.OnEnter();
        }

        public void SwitchState(IState nextState)
        {
            currentState.OnExit();
            SwitchOn(nextState);
        }
        
        public void SwitchState(Type nextStateType)
        {
            SwitchState(stateTable[nextStateType]);
        }
    }
}