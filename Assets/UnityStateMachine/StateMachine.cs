using System;
using UnityEngine;

namespace UnityStateMachine
{
    public class StateMachine : MonoBehaviour
    {
        private IState currentState;

        public StateMachine()
        {
        }

        public void ChangeState(IState nextState)
        {
            if(currentState!=null)
            {
                currentState.Exit();
            }

            currentState = nextState;
            currentState.SetOwner(this);
            currentState.Enter();
        }

        private void FixedUpdate()
        {
			if (currentState != null)
			{
				currentState.Execute();
			}
        }
    }
}
