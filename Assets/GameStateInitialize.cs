using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStateMachine;

public class GameStateInitialize : MonoBehaviour {

    private int startTickCount;
    private Boolean stateChanged;

	// Use this for initialization
	void Start () {

        startTickCount = Environment.TickCount;
        stateChanged = false;

        StateMachine stateMachine = this.GetComponent<StateMachine>();
        if(stateMachine!=null)
        {
            stateMachine.ChangeState(new StateHello());
        }
	}

    void Update()
    {
        if(!stateChanged && (Environment.TickCount - startTickCount>5000))
        {
            stateChanged = true;
            StateMachine stateMachine = this.GetComponent<StateMachine>();
            stateMachine.ChangeState(new StateS2());
        }
    }
}
