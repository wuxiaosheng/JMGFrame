using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //EventManager.getInstance().addEventListener(EventType.TEST_EVT_1, new Handler(onTestEvt1));
        //EventManager.getInstance().addEventListener(EventType.TEST_EVT_1, new Handler(onTestEvt2));
        //Button btn = GameObject.Find("Button").GetComponent<Button>();
        //btn.onClick.AddListener(onClick);
    }

    //void onClick() {
        //Event evt = EventManager.getInstance().createEvent(EventType.TEST_EVT_1, "test data", "12315");
        //EventManager.getInstance().trigger(evt);
    //}

    // Update is called once per frame
    void Update()
    {
        EventManager.getInstance().update();
    }
}
