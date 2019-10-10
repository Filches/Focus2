using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavScript : MonoBehaviour
{
    public GameObject[] navpoints;
    NavMeshAgent nav;
    public float dtd,dth;
    int currenttarget;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nextnode();
    }

    // Update is called once per frame
    void Update()
    {
        dtd = Vector3.Distance(navpoints[currenttarget].transform.position, transform.position);
        
        if(dtd < dth)
        {
            nextnode();
        }
    }

    void nextnode()
    {
        currenttarget = Random.Range(0, navpoints.Length);
        nav.SetDestination(navpoints[currenttarget].transform.position);
    }
}
