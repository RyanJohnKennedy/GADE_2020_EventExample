using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        EventManager.Instance.AddListener(EVENT_TYPE.GAME_INIT, OnWelcomeMessage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void OnWelcomeMessage(EVENT_TYPE Event_Type, Component Sender, object Param = null)
    {
        Debug.Log("Welcome to my Game");
    }
}
