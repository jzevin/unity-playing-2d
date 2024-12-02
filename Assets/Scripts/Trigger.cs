using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameEvent gameEvent;
    void Start()
    {
        InvokeRepeating("TriggerRepeater", 3, 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TriggerRepeater();
        }
    }

    public void TriggerRepeater()
    {
        gameEvent.TriggerEvent();
    }
}
