using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stack : MonoBehaviour
{
    public MeshFilter stackMesh;
    public float height;
    public Vector3[] vertices;


    // Start is called before the first frame update
    void Start()
    {
      vertices = new Vector3[stackMesh.mesh.vertices.Length];
      for(var i = 0; i < vertices.Length; i++){
        vertices[i] = stackMesh.mesh.vertices[i];
      }

      height = 1.0f;


    }

    // Update is called once per frame
    void Update()
    {

      vertices[0].y = height;
      vertices[1].y = height;
      vertices[2].y = height;
      vertices[3].y = height;

      
      stackMesh.mesh.vertices = vertices;
    }
}
