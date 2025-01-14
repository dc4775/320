using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDestiny;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        //GetComponent<BoxCollider>().enable = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDestiny.position;
        this.transform.parent = GameObject.Find("PickUpLoc").transform;
    }

    void OnMouseUp()
    {
        //GetComponent<BoxCollider>().enable = true;
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
