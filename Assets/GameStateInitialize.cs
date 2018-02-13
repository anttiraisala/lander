using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStateMachine;

public class GameStateInitialize : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StateMachine stateMachine = this.GetComponent<StateMachine>();
        if(stateMachine!=null)
        {
            stateMachine.ChangeState(new StateHello());
        }
	}
}
