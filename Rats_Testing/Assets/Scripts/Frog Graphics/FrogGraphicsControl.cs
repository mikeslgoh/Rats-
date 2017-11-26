using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogGraphicsControl : MonoBehaviour {
    public float lineWidth;
    public float lineLength;
    public Color lineColor;

    public Material lineMaterial;
    public GameObject lineOrigin;
   // public TriggerManager tb;
    private GameObject line;

    void Start()
    {
        Vector3 lineStart = lineOrigin.transform.position;
        Vector3 lineEnd = new Vector3(lineStart.x + lineLength, lineStart.y, lineStart.z);
        line = Graphicsf.DrawLine(lineMaterial, lineStart, lineEnd, lineColor, lineWidth);
    }

    void Update()
    {
        //if(tb.check)
       // {
           // Destroy(line);
       // }
    }
}
