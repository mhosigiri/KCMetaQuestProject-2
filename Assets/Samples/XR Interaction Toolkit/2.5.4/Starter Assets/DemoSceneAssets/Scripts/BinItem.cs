using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BinItem : MonoBehaviour
{
    private AudioSource audioSource;
    private Timer timer;
    private XRGrabInteractable interactable;

    void Start()
    {
        timer = FindObjectOfType<Timer>();
        interactable = GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(ObjectGrabbed);
        audioSource = GetComponent<AudioSource>();
    }

    private void ObjectGrabbed(SelectEnterEventArgs a)
    {
        if (a.interactorObject.GetType() == typeof(XRSocketInteractor))
        {
            return;
        }
        timer.StartTimer();

        if (audioSource)
        {
            audioSource.Play();
        }
    }
}
