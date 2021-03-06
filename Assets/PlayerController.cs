﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

	public Camera cam;
    private NavMeshAgent agent;

    // Use this for initialization
	void Start () {

		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {

			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray, out hit))
				agent.destination = hit.point;				
		}
	}
}
