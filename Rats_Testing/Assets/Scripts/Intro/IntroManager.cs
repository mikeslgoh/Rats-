/*
using UnityEngine;

public class IntroManager : MonoBehaviour {
    public Canvas canvas;
    public Transform mainCamera;
    public GameObject[] objectsToActivate;
    public GameObject[] objectsToDeactivate;

    private bool switchedStates = false;

    void Start()
    {
        foreach (GameObject objectToActivate in objectsToActivate)
        {
            objectToActivate.SetActive(false);
        }

        foreach(GameObject objectToDeactivate in objectsToDeactivate)
        {
            objectToDeactivate.SetActive(true);
        }
    }

    void Update()
    {
        LabelManager.CanvasLookAt(canvas, mainCamera);

        if(IntroInteraction.introStarted && !switchedStates)
        {
            SetActiveStates(objectsToActivate, true);
            SetActiveStates(objectsToDeactivate, false);
            switchedStates = true;
        }
    }

    void SetActiveStates(GameObject[] objects, bool state)
    {
        foreach(GameObject obj in objects)
        {
            obj.SetActive(state);
        }
    }  
}
*/