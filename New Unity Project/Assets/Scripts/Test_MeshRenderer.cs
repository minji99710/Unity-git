using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_MeshRenderer : MonoBehaviour
{
    //when clicked render it blue 
    [SerializeField] private Material red;
    [SerializeField] private Material blue;

    private MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            mesh.material = blue;
        }
        else
        {
            mesh.material = red;
        }
    }
}
