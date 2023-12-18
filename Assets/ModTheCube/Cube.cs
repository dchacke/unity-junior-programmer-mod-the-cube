using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(1, 1, 1);
        transform.localScale = Vector3.one * 2f;
        
        Material material = Renderer.material;
        
        material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), 1f);
    }
    
    void Update()
    {
        transform.Rotate(new Vector3(10.0f, 10.0f, 10.0f) * Time.deltaTime * 10);
    }
}
