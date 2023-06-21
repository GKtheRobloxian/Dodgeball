using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restriction : MonoBehaviour
{
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.Find("Player"))
        {
            other.gameObject.transform.position = spawn.transform.position;
        }
    }
}
