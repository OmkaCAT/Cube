using UnityEngine;
using System.Collections;

public class CubeFloat : MonoBehaviour {
	
    public float speed, tilt;
    private Vector3 target = new Vector3(0, 1.39f, 0);

	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 0.73f)
            target.y = 0.73f;
        else if (transform.position == target && target.y == 0.73f)
                target.y = 1.79f;

        transform.Rotate(Vector3.up * Time.deltaTime * tilt);
    }
}
