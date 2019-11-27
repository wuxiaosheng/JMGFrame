using System.Collections;
using System.Collections.Generic;
public interface IEventManager {
    bool addEventListener(EventType gEvt, Handler handler);
    bool removeEventListener(EventType gEvt);
    void trigger(IEvent evt);
    void broadcast();
}