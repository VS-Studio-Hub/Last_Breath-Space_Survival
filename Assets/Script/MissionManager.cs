using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public static MissionManager instance;

    [Header("Mission")]
    public static bool battery;
    public static bool circuit;
    public static bool tool;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        battery = false;
        circuit = false;
        tool = false;
    }


    void Update()
    {
        
    }
}
