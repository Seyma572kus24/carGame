using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 6.0f;
    public float height = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = target.position;
        transform.position = transform.position - target.rotation * Vector3.forward * distance;
        transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
        transform.LookAt(target);
    }
}
