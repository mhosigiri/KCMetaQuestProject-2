using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Bin : MonoBehaviour
{
    private AudioSource audioSource;
    private Timer timer;
    private XRSocketInteractor interactor;
    private ObjectInstantiator objectInstantiator;

    void Start()
    {
        timer = FindObjectOfType<Timer>();
        interactor = GetComponent<XRSocketInteractor>();
        objectInstantiator = FindObjectOfType<ObjectInstantiator>();
        interactor.selectEntered.AddListener(ObjectPlaced);
        audioSource = GetComponent<AudioSource>();
    }

    private void ObjectPlaced(SelectEnterEventArgs a)
    {
        timer.StopTimer();
        if (objectInstantiator != null)
        {
            objectInstantiator.CreateObject();
        }
        else
        {
            Debug.LogWarning("ObjectInstantiator not found in the scene.");
        }
        Destroy(a.interactableObject.transform.gameObject, 1.0f);

        if (audioSource)
        {
            audioSource.Play();
        }
    }
}
