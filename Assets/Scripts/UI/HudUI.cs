using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudUI : MonoBehaviour
{
    // Singleton
    public static HudUI Singleton;

    // Set Singleton
    private void Awake()
    {
        Singleton = this;
    }

}
