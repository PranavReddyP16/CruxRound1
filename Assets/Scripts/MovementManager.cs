using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
	private UnityEngine.AI.NavMeshAgent NMA;

    // Start is called before the first frame update
    void Start()
    {
		NMA = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		RaycastHit hit;

		if(Input.GetMouseButtonDown(0))
		{
			if(Physics.Raycast(ray, out hit, 100))
			{
				NMA.destination = hit.point;
			}

			else
			{
				Debug.Log("Please click only on the plane");
			}
		}
    }
}
