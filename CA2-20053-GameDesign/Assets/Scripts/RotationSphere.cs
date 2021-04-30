using System.Collections;
using UnityEngine;

public class RotationSphere : MonoBehaviour {

    public Transform sphere;
    public float angularVelocity;
    public float angularVelocity1 = 1f;
    public float angularVelocity2 = 2f;
    private Vector3 axisOfRotation;
    public float time = 0f;
    int oldsec=0;
    float rDuration = 4f;
    public float MinDuration = 2f;
    public float MaxDuration = 6f;

    void Start()
    {
        angularVelocity = Random.Range(angularVelocity1,angularVelocity2);
        axisOfRotation = Random.onUnitSphere;

    }

    void Update()
    {
        time += Time.deltaTime;
        Debug.Log((int)time);

        if ( (int)time % (int)rDuration == 0 && (int)time != oldsec)
        {
            Debug.Log(" Old Sec Here " + oldsec);
            axisOfRotation = Random.onUnitSphere;

            rDuration = Random.Range(MinDuration, MaxDuration);
            angularVelocity = Random.Range(angularVelocity1, angularVelocity2);
        }

        
        transform.Rotate(axisOfRotation, angularVelocity * Time.smoothDeltaTime);

        oldsec = (int)time;
    }

    private void OnCollisionEnter(Collision other)
    {
        other.transform.parent = this.transform;
    }

}
