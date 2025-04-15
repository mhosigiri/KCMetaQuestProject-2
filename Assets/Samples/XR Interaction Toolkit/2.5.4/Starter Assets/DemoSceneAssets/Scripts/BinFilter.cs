using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

public class BinFilter : MonoBehaviour, IXRHoverFilter, IXRSelectFilter
{

    public bool canProcess => true;
    public bool Process(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
    {
        return interactable.transform.tag.Equals(gameObject.tag);
    }

    public bool Process(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
    {
        return interactable.transform.tag.Equals(gameObject.tag);
    }
}