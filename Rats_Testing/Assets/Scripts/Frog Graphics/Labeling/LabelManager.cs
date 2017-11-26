using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelManager : MonoBehaviour {
    [SerializeField] private Material lineMaterial;
    [SerializeField] private Transform mainCamera;
    [SerializeField] private GameObject canvasPrefab;
    [SerializeField] private float labelHeight;
    [SerializeField] private float labelScaleMod = 0.00493f;

    [SerializeField] private FrogLabel[] frogLabels;

    private Canvas[] canvases;

    void Start()
    {
        canvases = new Canvas[frogLabels.Length];
    }

    void Update()
    {
        CheckOrganState();
    }

    Canvas CreateCanvas(FrogLabel label)
    {
        Vector3 organPosition = label.organ.transform.position;
        Vector3 labelPosition = new Vector3(organPosition.x, organPosition.y + labelHeight, organPosition.z);
        Transform parentTransform = label.organ.transform;
        
        GameObject canvasObject = Instantiate(canvasPrefab, labelPosition, Quaternion.identity, parentTransform);
        Canvas canvas = canvasObject.GetComponent<Canvas>();

        float organScale = label.organ.transform.lossyScale.magnitude;
        float canvasScaleMod = labelScaleMod / organScale;
        Vector3 canvasScale = canvas.transform.localScale;
        canvas.transform.localScale = new Vector3(canvasScale.x * canvasScaleMod, canvasScale.y * canvasScaleMod, canvasScale.z * canvasScaleMod);

        canvas.enabled = false;

        return canvas;
    }

    void DrawLabel(FrogLabel label, Canvas canvas)
    {
        if (!label.commonName.Equals(string.Empty))
            label.commonName = " (" + label.commonName + ")";

        string labelText = "<i>" + label.sciName + "</i>" + label.commonName;
        canvas.enabled = true;
        canvas.GetComponent<RectTransform>().sizeDelta = new Vector2(canvas.GetComponent<RectTransform>().sizeDelta.x * labelText.Length, canvas.GetComponent<RectTransform>().sizeDelta.y);

        Text textField = canvas.GetComponentInChildren<Text>();
        textField.GetComponent<RectTransform>().sizeDelta = new Vector2(textField.GetComponent<RectTransform>().sizeDelta.x * labelText.Length, textField.GetComponent<RectTransform>().sizeDelta.y);
        textField.text = labelText;
    }

    public static void CanvasLookAt(Canvas canvas, Transform target)
    {
        canvas.transform.LookAt(target);
    }

    void CheckOrganState()
    {
        for(int i = 0; i < frogLabels.Length; ++i)
        {
            if(frogLabels[i].organ.activeInHierarchy)
            {
                if(canvases[i] == null)
                {
                    canvases[i] = CreateCanvas(frogLabels[i]);
                    DrawLabel(frogLabels[i], canvases[i]);
                }

                else
                {
                    canvases[i].enabled = true;
                }

                CanvasLookAt(canvases[i], mainCamera);
                Graphicsf.DrawLine(lineMaterial, canvases[i].transform.position, frogLabels[i].organ.transform.position, Color.blue, 0.002f, 0.01f);
            }

            else if(!frogLabels[i].organ.activeInHierarchy && canvases[i] != null)
            {
                canvases[i].enabled = false;
            }
        }
    }
}
