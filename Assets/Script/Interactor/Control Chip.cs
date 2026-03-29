using UnityEngine;

public class ControlChip : MonoBehaviour, IInteractable
{
    // When the player interacts with the control chip,
    // set the circuit status in the MissionManager to true and destroy the control chip object
    public void Interact(RaycastHit hit)
    {
        MissionManager.circuit = true;
        Destroy(gameObject);
    }
}
