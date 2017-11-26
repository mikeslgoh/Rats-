using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphicsf : MonoBehaviour {
    public static GameObject DrawLine(Material material, Vector3 start, Vector3 end, Color color, float width)
    {
        GameObject myLine = new GameObject();
        myLine.transform.position = start;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();

        lr.material = material;
        lr.startColor = color;
        lr.endColor = color;

        lr.startWidth = width;
        lr.endWidth = width;
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);

        return myLine;
    }

    public static void DrawLine(Material material, Vector3 start, Vector3 end, Color color, float width, float duration)
    {
        GameObject myLine = new GameObject();
        myLine.transform.position = start;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();

        lr.material = material;
        lr.startColor = color;
        lr.endColor = color;

        lr.startWidth = width;
        lr.endWidth = width;
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);

        Destroy(myLine, duration);
    }
}
