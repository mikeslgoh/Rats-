/*
using UnityEngine;
using UnityEngine.Audio;

//[RequireComponent(typeof(AudioSource))]

public class TriggerManager : MonoBehaviour
{
	public GameObject dissectAnimal;
	public GameObject previousDissection;

	public GameObject previous;
	private bool previousOpen = true;
    private bool inMarker = false;
    public int totalTime = 100000;

	public GameObject rightController;
	public GameObject leftController; // for left handed people

    public GameObject scissorsClosed;
    public GameObject scissorsOpen;

    private int index = 0;

    void OnTriggerEnter(Collider other)
    {
        int index = (int)other.GetComponentInParent<SteamVR_TrackedObject>().index;

        if (previous != null)
            previousOpen = !previous.activeInHierarchy;// checks if the previous object is active in the hierarchy

        inMarker = true;

        int countTimer = 0;

        while (countTimer != totalTime)
        {
            SteamVR_Controller.Input(index).TriggerHapticPulse(2900, Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad); // get controller index
            countTimer++;
        }

        scissorsOpen.SetActive(true);
        scissorsClosed.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        inMarker = false;

        scissorsOpen.SetActive(false);
        scissorsClosed.SetActive(true);
    }
    // check inMarker

    void Update ()
	{
		if ( (rightController.GetComponent<SteamVR_TrackedController>().padPressed || leftController.GetComponent<SteamVR_TrackedController>().padPressed) 
            && previousOpen && inMarker) {

            if (rightController.GetComponent<SteamVR_TrackedController>().padPressed)
                loopVibration(rightController);
            else
                loopVibration(leftController);
            //Debug.Log("Open");

            if (previousDissection != null)
				previousDissection.SetActive (false);
			
			dissectAnimal.SetActive (true);
			this.gameObject.SetActive (false);

            scissorsOpen.SetActive(false);
            scissorsClosed.SetActive(true);
        }
	}

    void loopVibration(GameObject controller)
    {
        int count = -totalTime/2;
        int index = (int)controller.GetComponent<SteamVR_TrackedController>().controllerIndex;
     
      while (count != totalTime)
       {
            SteamVR_Controller.Input(index).TriggerHapticPulse(2900, Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
            count++;
       }
    }
}
*/