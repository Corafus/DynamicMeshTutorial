﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stack : MonoBehaviour
{
    public MeshFilter stackMesh;
    public Vector3[] vertices;
    // Start is called before the first frame update
    void Start()
    {
        vertices = new Vector3[stackMesh.mesh.vertices.Length];
        for(var i = 0; i < vertices.Length; i++){
          vertices[i] = stackMesh.mesh.vertices[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        stackMesh.mesh.vertices = vertices;
    }
}
