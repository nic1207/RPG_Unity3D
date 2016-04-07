using UnityEngine;
using System.Collections;



public class ClickToMove : MonoBehaviour {

	private NavMeshAgent navMeshAgent;
	private bool isMoving;
	private bool enemyClicked;


	// Use this for initialization
	void Awake () {
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if(Input.GetButton("Fire1"))
		{
			if(Physics.Raycast(ray, out hit, 100))
			{
				/*if(hit.collider.CompareTag("Enemy"))
				{
					
				}
				else
				{*/
					isMoving = true;
					enemyClicked = false;
					navMeshAgent.destination = hit.point;
					Debug.Log ("Walking");
					navMeshAgent.Resume();
				//}
			}
		}
	}
}
