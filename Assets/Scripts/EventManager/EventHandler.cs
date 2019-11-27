using System.Collections;
using System.Collections.Generic;
public class EventHandler : IEventHandler {
    public bool addHandler(Handler handler) {
        return true;
    }

    public bool removeHandler(Handler handler) {
        return true;
    }

    public void broadcast(IEvent evt) {

    }

    public void clear() {

    }
}