using UnityEngine;

public class Battery : MonoBehaviour, IInteractable
{
    // When the player interacts with the battery,
    // set the battery status in the MissionManager to true and destroy the battery object
    public void Interact(RaycastHit hit)
    {
        MissionManager.battery = true;
        Destroy(gameObject);
    }
}
