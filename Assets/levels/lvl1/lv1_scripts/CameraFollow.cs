using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        smoothSpeed = .15f;
        offset = new Vector3(0, -1, -10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        Vector3 goalPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, goalPos, smoothSpeed);

        transform.position = smoothPos;

        //transform.LookAt(target);
    }
}
