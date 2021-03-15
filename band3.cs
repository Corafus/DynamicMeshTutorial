using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class band3 : MonoBehaviour
{

    public MeshFilter bandMesh;
    public Vector3[] vertices;


    // Start is called before the first frame update
    void Start()
    {
        vertices = new Vector3[bandMesh.mesh.vertices.Length];
        for(var i = 0; i < vertices.Length; i++){
          vertices[i] = bandMesh.mesh.vertices[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
      bandMesh.mesh.vertices = vertices;
    }
}
