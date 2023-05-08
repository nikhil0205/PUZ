using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nav : MonoBehaviour
{

public float distance = 30;
[SerializeField] public Transform enemy;

public NavMeshAgent navmeshagent;
// Start is called before the first frame update
private void Awake()
{
enemy = GameObject.FindGameObjectWithTag("player").transform;

navmeshagent = GetComponent<NavMeshAgent>();

}

// Update is called once per frame
private void Update()
{
navmeshagent.destination = enemy.position;
distance = Vector3.Distance(enemy.position, transform.position);

if (distance <=90)
{

navmeshagent.enabled = true;
navmeshagent.SetDestination(enemy.position);
}

else
{
this.navmeshagent.enabled = false;

}



}

}