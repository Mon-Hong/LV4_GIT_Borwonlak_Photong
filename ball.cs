using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigi;
    private Vector3 post;
    public float speed;

    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        post = new Vector3(moveHorizontal, 0, moveVertical);
        rigi.AddForce(post * speed);
    }
}
