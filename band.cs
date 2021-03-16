using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class band : MonoBehaviour
{
    public MeshFilter bandMesh;
    public Vector3[] vertices;

    public MeshFilter stackMesh;
    public float margin;

    // Start is called before the first frame update
    void Start()
    {
        vertices = new Vector3[bandMesh.mesh.vertices.Length];
        for(var i = 0; i < vertices.Length; i++){
          vertices[i] = bandMesh.mesh.vertices[i];
        }

        margin = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {

        int[] top = {10, 11, 9, 8, 17, 16, 23, 22};
        for(var i = 0; i < top.Length; i++){
          vertices[top[i]].y = stackMesh.mesh.vertices[0].y + margin;
        }

        int[] topRight = {9, 8, 23, 22};
        for(var i = 0; i < topRight.Length; i++){
          vertices[topRight[i]].x = stackMesh.mesh.vertices[2].x + margin;
        }

        int[] topLeft = {10, 11, 17, 16};
        for(var i = 0; i < topLeft.Length; i++){
          vertices[topLeft[i]].x = stackMesh.mesh.vertices[1].x + margin;
        }


        bandMesh.mesh.vertices = vertices;
    }
}
