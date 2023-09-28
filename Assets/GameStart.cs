using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        EventManager.Instance.PostNotification(EVENT_TYPE.GAME_INIT, this);
        
    }
}
