using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotation;
    [SerializeField] private GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.W))
        //{
        //    this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    rotation += new Vector3(90, 0, 0) * Time.deltaTime;
        //    //get eulerangles only once when starting and accumulate later
        //    this.transform.rotation = Quaternion.Euler(rotation);

        //    //this.transform.eulerAngles = rotation;

        //    //his.transform.Rotate(new Vector3(90, 0, 0 * Time.deltaTime));
        //}



        //this.transform.position += new Vector3(0, 0, 1) * Time.deltaTime;

        //if (Input.GetKey(KeyCode.W))
        //{
        //    this.transform.localScale += new Vector3(2, 2, 2) * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    //this.transform.forward //¡§±‘»≠ ∫§≈Õ Vector3(0, 0, 1)
        //    //this.transform.up // Vector(0, 1, 0)
        //    //this.transform.right //Vector(1, 0, 0)

        //    //this.transform.LookAt(cam.transform.position);

            
        //}

        //this.transform.RotateAround(cam.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
