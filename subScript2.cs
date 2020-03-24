using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subScript2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("subScript2");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(50.0f * Time.deltaTime, 0.0f, 0.0f));
    }
}
