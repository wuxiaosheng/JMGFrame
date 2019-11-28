using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager {
    // Start is called before the first frame update
    private Dictionary<PoolType, Pool> _dict;
    PoolManager() {
        
    }
    public GameObject getGameObject() {
        return new GameObject();
    }
}
