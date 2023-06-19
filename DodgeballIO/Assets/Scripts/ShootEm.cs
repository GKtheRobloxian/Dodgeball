using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEm : MonoBehaviour
{
    public GameObject ball;
    public GameObject ballAim;
    [Range(0.0f, 15.0f)][SerializeField] float throwForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yeet = Random.Range(-15.0f, 15.0f);
        if (Input.GetMouseButtonDown(0))
        {
            GameObject instantiating = Instantiate(ball, transform.position, Quaternion.identity);
            instantiating.GetComponent<Rigidbody>().AddRelativeForce((ballAim.transform.position - transform.position) * throwForce, ForceMode.Impulse);
            instantiating.GetComponent<Rigidbody>().AddTorque(new Vector3(yeet, yeet, yeet));
            GameObject.Find("Game Manager").GetComponent<RandomizeColor>().ChangeColor(instantiating);
        }
    }
}
