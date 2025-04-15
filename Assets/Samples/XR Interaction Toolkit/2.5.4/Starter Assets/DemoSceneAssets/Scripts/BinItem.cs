using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BinItem : MonoBehaviour
{
    private Timer timer;
    private XRGrabInteractable interactable;

    void Start()
    {
        timer = FindObjectOfType<Timer>();
        interactable = GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(ObjectGrabbed);
    }

    private void ObjectGrabbed(SelectEnterEventArgs a)
    {
        if (a.interactorObject.GetType() == typeof(XRSocketInteractor))
        {
            return;
        }
        timer.StartTimer();
    }
}
