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

        int[] midHeight = {18, 19, 5, 4, 15, 14, 20, 21};
        for(var i = 0; i < midHeight.Length; i++){
          vertices[midHeight[i]].y = 0.2f;
        }

        int[] bottom = {2, 3, 1, 0, 6, 7, 12, 13};
        for(var i = 0; i < bottom.Length; i++){
          vertices[bottom[i]].y = 0.1f;
        }

        int[] bottomRight = {20, 12, 15, 14, 12, 13, 21, 1, 0};
        for(var i = 0; i < bottomRight.Length; i++){
          vertices[bottomRight[i]].x = 1.6f + margin;
        }

        int[] bottomLeft = {18, 19, 5, 4, 6, 7, 3, 2};
        for(var i = 0; i < bottomLeft.Length; i++){
          vertices[bottomLeft[i]].x = -1.6f - margin;
        }

        int[] front = {10, 9, 22, 21, 14, 13, 0, 3, 6, 5, 18, 17};
        for(var i = 0; i < front.Length; i++){
          vertices[front[i]].z = -0.05f;
        }

        int[] back = {11, 8, 23, 20, 15, 12, 1, 2, 7, 4, 19, 16};
        for(var i = 0; i < back.Length; i++){
          vertices[back[i]].z = 0.05f;
        }


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
          vertices[topLeft[i]].x = stackMesh.mesh.vertices[1].x - margin;
        }


        bandMesh.mesh.vertices = vertices;
    }
}
