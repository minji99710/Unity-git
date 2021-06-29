using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Collider : MonoBehaviour
{
    private BoxCollider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

        //if(Input.GetKeyDown(KeyCode.W))
        //{
        //    Debug.Log(col.bounds);
        //    Debug.Log(col.center);
        //    Debug.Log(col.size);

        //}

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    if (col.Raycast(ray, out hit, 1000))
        //    {
        //        this.transform.position = hit.point; //move the cube to the pointer(mouse clicked)
        //    }
        //}


    }

    //private void OnTriggerStay(Collider other) //충돌상태 지속될 때 적용 
    //{
    //    other.transform.position += new Vector3(0, 0, 0.01f);
    //}
}
