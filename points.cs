using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    // Start is called before the first frame update
    static public int pointer = 0;
    public Color my = new Color(1, 1, 1, 1);
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pointer += 1;
            this.gameObject.SetActive(false);

        }
    }
}
