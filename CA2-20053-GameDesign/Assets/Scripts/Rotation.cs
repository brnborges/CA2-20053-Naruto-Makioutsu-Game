using UnityEngine;

public class Rotation : MonoBehaviour {


    public Transform sphere;
    public float x = Random.Range(-2, 2);
    public float y = Random.Range(-2, 2);
    public float z = Random.Range(-2, 2);


	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3(x, y, z));
          
	}
}
