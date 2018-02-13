using System;
using UnityEngine;
using UnityStateMachine;

public class StateS2 : State
{
	private int previousTickCount;
	private int currentTickCount;


	public StateS2()
    {
    }

    public override void Enter()
    {
		previousTickCount = Environment.TickCount;
		Debug.Log("StateS2::Enter[" + previousTickCount + "]");
		Debug.Log("StateS2.OwnerStateMachine[" + this.OwnerStateMachine + "]");
    }

    public override void Execute()
    {
		currentTickCount = Environment.TickCount;
		if (currentTickCount - previousTickCount > 1000)
		{
			previousTickCount = currentTickCount;
			Debug.Log("StateS2::Execute");
		}
    }

    public override void Exit()
    {
        Debug.Log("StateS2::Execute()");
    }
}
