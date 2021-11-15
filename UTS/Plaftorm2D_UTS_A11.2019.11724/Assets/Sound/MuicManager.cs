using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuicManager : MonoBehaviour
{
    private static MuicManager instance = null;

    public MuicManager Instance()
    {
        return instance;
    }

    public void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
