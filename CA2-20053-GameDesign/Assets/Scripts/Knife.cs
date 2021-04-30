using UnityEngine;

public class Knife : MonoBehaviour {

    [SerializeField]
    private GameObject KnifePrefab;

    [SerializeField]
    private Vector3 throwForce;
    public Vector3 positionOfKnife;
    private bool isActive = true;
    private Rigidbody rb;
    private BoxCollider knifeCollider;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        knifeCollider = GetComponent<BoxCollider>();
    }

    // Throwing kunais
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && isActive)
        {
            rb.AddForce(throwForce, ForceMode.Impulse);
            rb.useGravity = true;
        }
    }

    // Hit target method
    private void OnCollisionEnter(Collision collision)
    {
        if (!isActive)
            return;

        isActive = false;
        
        // If you succeed keep playing
        if (collision.collider.tag == "Log")
        {
            GetComponent<ParticleSystem>().Play();

            rb.velocity = new Vector3(0, 0, 0);
            rb.isKinematic = true;

            GameController.Instance.HitTarget();
        } 
        
        // if u failed game over
        else if(collision.collider.tag == "Knife")
        {
            rb.velocity = new Vector3(rb.velocity.x, -2, rb.velocity.z);
            GameController.Instance.GameOver(false);
        }
    }
    
    
}
