using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float ForceMultipliyer = 3f;
    public float MaximumVelocity = 3f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        var HorizonatalInput = Input.GetAxis("Horizontal");
        // Debug.Log(-1);
        if (GetComponent<Rigidbody>().velocity.magnitude <= MaximumVelocity)
        {
            GetComponent<Rigidbody>()
                .AddForce(new Vector3(HorizonatalInput * ForceMultipliyer, 0, 0));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(gameObject);
        }
    }
}
