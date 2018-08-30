using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GameObject.FindGameObjectsWithTag("Audio").Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
	}
}
