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
      //don't forget to apply bundle to public bundleMeshFilter
      vertices[10].y = bundleMesh.mesh.vertices[2].y + margin;
      vertices[11].y = bundleMesh.mesh.vertices[2].y+ margin;
      vertices[16].y = bundleMesh.mesh.vertices[2].y+ margin;
      vertices[17].y = bundleMesh.mesh.vertices[2].y+ margin;

      vertices[10].x = bundleMesh.mesh.vertices[2].x+ margin;
      vertices[11].x = bundleMesh.mesh.vertices[2].x+ margin;
      vertices[16].x = bundleMesh.mesh.vertices[2].x+ margin;
      vertices[17].x = bundleMesh.mesh.vertices[2].x+ margin;

      bandMesh.mesh.vertices = vertices;
    }
}
