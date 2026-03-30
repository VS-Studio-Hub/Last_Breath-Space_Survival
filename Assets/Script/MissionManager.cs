using UnityEngine;

public class MissionManager : MonoBehaviour
{
    [Header("Mission")]
    public static bool battery;
    public static bool circuit;
    public static bool tool;
    private bool missionComplete;

    void Start()
    {
        battery = false;
        circuit = false;
        tool = false;
    }


    void Update()
    {
        if(!missionComplete && battery && circuit && tool)
        {
            SpaceShip.isActiveSpaceShip = true;
            //Debug.Log("Mission Complete!");
        }
    }
}
