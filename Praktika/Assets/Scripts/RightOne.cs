using UnityEngine;
using System.Collections;

public class RightOne : MonoBehaviour {

    private GameObject mainCube;

	// Use this for initialization
	void Start () {
        mainCube = GameObject.Find ("Main Cube");
	}

    void OnMouseDown () {
        if (GetComponent <Renderer> ().material.color == mainCube.GetComponent <Renderer> ().material.color)
            mainCube.GetComponent <GameCnrtl> ().next = true;
        else
            mainCube.GetComponent <GameCnrtl> ().lose = true;
    }
}
