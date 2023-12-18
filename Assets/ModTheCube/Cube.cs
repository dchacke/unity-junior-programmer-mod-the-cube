using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one;
        
        Material material = Renderer.material;
        
        material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), 1f);
    }
    
    void Update()
    {
        transform.Rotate(new Vector3(10.0f, 10.0f, 10.0f) * Time.deltaTime * 10);

        float scale = Mathf.Sin(Time.time) + 1;
        transform.localScale = new Vector3(scale, scale, scale);

        float r = Mathf.Abs(Mathf.Sin(Time.time) % 1);
        float g = Mathf.Abs(Mathf.Sin(Time.time + 1) % 1);
        float b = Mathf.Abs(Mathf.Sin(Time.time + 2) % 1);
        Renderer.material.color = new Color(r, g, b);
    }
}
