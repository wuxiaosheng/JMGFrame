using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : IEventManager
{

    private Dictionary<EventType, IEventHandler> _dict;
    private Queue<IEvent> _queue;

    EventManager() {
        _dict = new Dictionary<EventType, IEventHandler>();
    }

    public bool addEventListener(EventType gEvt, Handler handler) {
        bool bRet;
        if (!_dict.ContainsKey(gEvt)) {
            _dict.Add(gEvt, new EventHandler());
        }
        bRet = _dict[gEvt].addHandler(handler);
        return bRet;
    }
    public bool removeEventListener(EventType gEvt) {
        if (_dict.ContainsKey(gEvt)) {
            _dict.Remove(gEvt);
            return true;
        }
        return false;
    }
    public void trigger(IEvent evt) {

    }
    public void broadcast() {

    }
}
