using UnityEngine;

public class SlidingDoor2 : MonoBehaviour
{

    public Vector3 positionOffset = new Vector3(0f, -2f, 0f);
    public float speed = 5f;
    private Vector3 openPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        openPosition = transform.position + positionOffset;
    }

    public void OpenTheDoor2()
    {
        //MoveTowards makes an object move towards a target object specified by a max distance
        transform.position = Vector3.MoveTowards(transform.position, openPosition, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // OpenTheDoor();
    }
}
