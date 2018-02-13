using System;
using UnityEngine;

namespace UnityStateMachine
{
    public interface IState
    {
        void SetOwner(StateMachine owner);

        void Enter();

        void Execute();

        void Exit();
    }

    public abstract class State : IState
    {
        private StateMachine ownerStateMachine;

        public State(){}
        /*
        public State(StateMachine ownerStateMachine)
        {
            this.ownerStateMachine = ownerStateMachine;
            Debug.Log("State::ownerStateMachine[" + ownerStateMachine +"]");
        }*/

        public void SetOwner(StateMachine owner)
        {
			this.ownerStateMachine = owner;
			Debug.Log("State.SetOwner::ownerStateMachine[" + owner + "]");
        }

        public abstract void Enter();

        public abstract void Execute();

        public abstract void Exit();
    }
}
