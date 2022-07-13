using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Target;
    public float follow_speed = 7.0f;
    public float z = -10.0f;

    Transform this_transform;
    Transform Target_transform;
    void Start()
    {
        this_transform = GetComponent<Transform>();
        Target_transform = Target.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this_transform.position = Vector3.Lerp(this_transform.position, Target_transform.position, follow_speed * Time.deltaTime);
        //this_transform.Translate(0, 0, z);
    }
}
