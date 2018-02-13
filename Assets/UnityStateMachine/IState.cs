using System;
using UnityEngine;

namespace UnityStateMachine
{
    public interface IState
    {
		StateMachine OwnerStateMachine
		{
            get;
            set;
		}

        void Enter();

        void Execute();

        void Exit();
    }

    public abstract class State : IState
    {
        private StateMachine ownerStateMachine;

        public StateMachine OwnerStateMachine
        {
            get { return this.ownerStateMachine; }
            set
            {
                this.ownerStateMachine = value;
                Debug.Log("State::OwnerStateMachine=[" + this.ownerStateMachine + "]");
            }
        }

        public State() { }

        public abstract void Enter();

        public abstract void Execute();

        public abstract void Exit();
    }
}
