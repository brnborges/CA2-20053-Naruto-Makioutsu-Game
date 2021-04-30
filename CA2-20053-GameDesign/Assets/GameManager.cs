using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField]
    private GameObject knifePrefab;

    public Vector3 positionOfKnife;

    // Use this for initialization
    void Start () {
        Instantiate(knifePrefab, positionOfKnife, transform.rotation);
    }

    // Update is called once per frame
    /*void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(knifePrefab, positionOfKnife, transform.rotation);
        }

    }
    */

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Log")
        {
            Instantiate(knifePrefab, positionOfKnife, Quaternion.identity);
        }
    }
}
