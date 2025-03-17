using Unity.VisualScripting;
using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 velocity;
    [SerializeField] private Vector3 spin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kick();
        }
        ApplyMagnusEffect();
    }

    void kick()
    {
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }
    

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        rb.AddForce(magnusForce,ForceMode.Force);
    }
}
