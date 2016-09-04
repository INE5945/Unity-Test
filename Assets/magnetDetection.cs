using UnityEngine;
using System.Collections;

public class magnetDetection: MonoBehaviour
{
    void OnGUI()
    {
        GUILayout.Label("Magnetometer reading: " + Input.compass.rawVector.ToString());
    }
}