using System;
using UnityEngine;
namespace UnityStateMachine
{
    public class StateHello : State
    {
		private int previousTickCount;
		private int currentTickCount;

        public StateHello(){}
        /*
        public StateHello(StateMachine ownerStateMachine) : base(ownerStateMachine)
        {
            Debug.Log("StateHello(StateMachine ownerStateMachine)[" + ownerStateMachine + "]");
        }*/

		
        public override void Enter()
        {
            previousTickCount = Environment.TickCount;
            Debug.Log("StateHello::Enter[" + previousTickCount + "]");
        }

		public override void Execute()
        {
            currentTickCount = Environment.TickCount;
            if(currentTickCount-previousTickCount>1000)
            {
                previousTickCount = currentTickCount;
                Debug.Log("StateHello::Execute");
            }
        }

        public override void Exit()
        {
            Debug.Log("StateHello::Exit");
        }
    }
}
