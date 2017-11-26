/*
using UnityEngine;

public class IntroInteraction : MonoBehaviour {
    public static bool introStarted = false;

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    public bool triggerButtonDown = false;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Update()
    {
        triggerButtonDown = controller.GetPressDown(triggerButton);

        if (triggerButtonDown)
        {
            introStarted = true;
        }
    }
}
*/
