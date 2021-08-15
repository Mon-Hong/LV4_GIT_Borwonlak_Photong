using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class move : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody riki;
    public float speed;
    public Text point;

    void Start()
    {
        riki = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal * speed, 0, moveVertical * speed);
        riki.AddForce(movement);
        point.text = points.pointer.ToString();
    }
}
