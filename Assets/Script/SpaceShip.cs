using UnityEngine;

public class SpaceShip : MonoBehaviour, IInteractable
{
    [Header("SpaceShip Settings")]
    private float holdTime = 5f;
    private float currentHoldTime;

    private bool isHolding;
    private bool hasTriggered;
    public static bool isActiveSpaceShip;


    public void Interact(RaycastHit hit)
    {
        // When the player interacts with the Spaceship,
        // if the isActiveSpaceship is true, start holding the interaction to activate it
        if (isActiveSpaceShip)
        {
            isHolding = true;
        }
    }

    void Start()
    {
        isActiveSpaceShip = false;
    }

    void Update()
    {
        // If the player is holding the interaction, increase the hold time
        if (isHolding)
        {
            currentHoldTime += Time.deltaTime;
            if (currentHoldTime >= holdTime && !hasTriggered)
            {
                hasTriggered = true;
                Debug.Log("SpaceShip Activated!");
            }
        }
        // If the player releases the interaction before holdTimw, reset the hold time and trigger status
        else
        {
            currentHoldTime = 0f;
            hasTriggered = false;
        }
    }

    
}
