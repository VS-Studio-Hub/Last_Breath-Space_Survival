using Unity.VisualScripting;
using UnityEngine;

public class RepairTool : MonoBehaviour, IInteractable
{
    // When the player interacts with the repair tool,
    // set the tool status in the MissionManager to true and destroy the repair tool object
    public void Interact(RaycastHit hit)
    {
        MissionManager.tool = true;
        Destroy(gameObject);
    }
}
