using UnityEngine;

public class ObjectInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject[] Objects;

    public void Start()
    {
        CreateObject();
    }
    internal void CreateObject()
    {
        GameObject o = Objects[Random.Range(0, Objects.Length)];
        Instantiate(o, transform.position, transform.rotation);
    }
}
