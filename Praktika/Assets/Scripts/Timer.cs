using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public Color col, defCol;
    public GameObject mCube;
    private Color lastCol;

	// Use this for initialization
	void Start () {
        lastCol = mCube.GetComponent<Renderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () {
	    if (!mCube.GetComponent<GameCnrtl>().lose){
            if (transform.position.x < -8.5f)
                Destroy(gameObject);
            if (transform.position.x < -0.7f)
                GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, col, Time.deltaTime);
            transform.position -= new Vector3(0.1f, 0, 0);
        }

        if (mCube.GetComponent<Renderer>().material.color != lastCol)
        {
            lastCol = mCube.GetComponent<Renderer>().material.color;
            transform.position = new Vector3(0, transform.position.y, 0);
            GetComponent<Renderer>().material.color = defCol;            
        }
    }

    void OnDestroy () {
        if (mCube)
            mCube.GetComponent<GameCnrtl>().lose = true;
    }
}
