using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T __inst = null;
    public static T Instance
    {
        get
        {
            if (__inst == null)
            {
                __inst = GameObject.FindObjectOfType<T>();
            }
            return __inst;
        }
    }

    private void Awake()
    {
        if (__inst == null)
        {
            __inst = this as T;
        }
    }
    protected virtual void OnDestroy()
    {
        if (__inst == this)
        {
            __inst = null;
        }
    }
}
