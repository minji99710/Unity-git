using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_RigidBody : MonoBehaviour
{
    Rigidbody rigid;
    Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //rigid.velocity = Vector3.forward;
            //rigid.angularVelocity = Vector3.right * 100;
            //rigid.maxAngularVelocity = 100;

            //rigid.MovePosition(transform.forward);
            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            rigid.MoveRotation(Quaternion.Euler(rotation));

            //rigid.AddForce(transform.forward);
            //rigid.AddTorque(Vector3.up);

            //rigid.AddExplosionForce(10f, this.transform.right, 10f);

            
        }
    }
}
