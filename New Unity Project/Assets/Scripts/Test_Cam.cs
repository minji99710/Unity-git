using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Cam : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //ī�޶� (3��Ī ����)
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + offset, speed);
    }
}
