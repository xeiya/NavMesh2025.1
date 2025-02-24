using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    public GameObject moveToObject;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent != null && moveToObject != null)
        {
            agent.destination = moveToObject.transform.position;
        }

    }
}
