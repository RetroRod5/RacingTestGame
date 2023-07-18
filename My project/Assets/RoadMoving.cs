using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoving : MonoBehaviour
{
    public float RoadSpeed = 5;
    private float offset;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset += (Time.deltaTime * RoadSpeed);
        mat.SetTextureOffset("_MainTex", new Vector2(0, offset));
        RoadSpeed += 0.01f * Time.deltaTime;
    }
}
