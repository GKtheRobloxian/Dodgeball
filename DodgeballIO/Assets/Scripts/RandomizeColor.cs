using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeColor : MonoBehaviour
{
    public Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor(GameObject ball)
    {
        ball.GetComponent<MeshRenderer>().material = materials[Random.Range(0, materials.Length)];
    }
}
