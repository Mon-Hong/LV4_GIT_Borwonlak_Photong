using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 angle;
    public GameObject ball;
    void Start()
    {
        angle = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + angle;
    }
}
