public class PoolGameObjectInfo
{  
    public string _name;

    //缓存时间
    public float _cacheTime= 0.0f;

    //缓存物体类型
    public PoolType _type;

    //可以重用
    public bool _canUse = true;

    //重置时间
    public float _resetTime = 0.0f;
}