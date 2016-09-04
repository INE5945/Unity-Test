using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public GameObject prefab;

    public void OnOver()
    {
        Debug.Log("Hit");
    }

    public void OnGazeTriggerStart()
    {
        Debug.Log("Triggered from hit.cs");
		//Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
