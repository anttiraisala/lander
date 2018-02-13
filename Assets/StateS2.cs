using System;
using UnityEngine;
using UnityStateMachine;

public class StateS2 : State
{
    public StateS2()
    {
    }

    public override void Enter()
    {
        Debug.Log("StateS2::Enter()");
        Debug.Log("StateS2.OwnerStateMachine[" + this.OwnerStateMachine + "]");
    }

    public override void Execute()
    {
        Debug.Log("StateS2::Execute()");
    }

    public override void Exit()
    {
        Debug.Log("StateS2::Execute()");
    }
}
