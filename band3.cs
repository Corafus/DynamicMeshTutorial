using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class band3 : MonoBehaviour
{

    public MeshFilter bandMesh;
    public Vector3[] vertices;

    public MeshFilter bundleMesh;
    public float margin = 0.01f;

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
      int[] top = {4, 5, 19, 18, 17, 16, 11, 10};
      for(var i = 0; i < top.Length; i++){
        vertices[top[i]].y = bundleMesh.mesh.vertices[2].y + margin;
      }

      int[] topRight = {16, 17, 10, 11};
      for(var i = 0; i < topRight.Length; i++){
        vertices[topRight[i]].x = bundleMesh.mesh.vertices[2].x + margin;
      }

      int[] topLeft = {18, 19, 5, 4};
      for(var i = 0; i < topLeft.Length; i++){
        vertices[topLeft[i]].x = bundleMesh.mesh.vertices[6].x + margin;
      }

      bandMesh.mesh.vertices = vertices;
    }
}
