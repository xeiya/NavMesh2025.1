using UnityEngine;
using UnityEngine.AI;

public class MoveToMouse : MonoBehaviour
{
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;

        if (Physics.Raycast(ray.origin, ray.direction, out hitinfo))
        {
            agent.destination = hitinfo.point;
        }

    }
}
