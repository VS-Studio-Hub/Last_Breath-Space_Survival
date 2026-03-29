using UnityEngine;


interface IInteractable
{
    void Interact(RaycastHit hit);
}

public class interactor : MonoBehaviour
{
    [Header("Interaction Settings")]
    public Transform interactorSource;
    public float interactRange;

    void Start()
    {
        // If no source is assigned, default to the main camera's transform
        if (interactorSource == null)
        {
            interactorSource = FindAnyObjectByType<Camera>().transform;
        }
    }

    void Update()
    {
        // Check for interaction input (E key)
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray r = new Ray(interactorSource.position, interactorSource.forward);
            if(Physics.Raycast(r, out RaycastHit hitInfo, interactRange))
            {
                if(hitInfo.collider.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact(hitInfo);
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a line in the editor to visualize the interaction range
        if (interactorSource != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(interactorSource.position, interactorSource.position + interactorSource.forward * interactRange);
        }
    }
}
