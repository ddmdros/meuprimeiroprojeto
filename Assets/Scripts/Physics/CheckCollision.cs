using UnityEngine;



public class CheckColision : MonoBehaviour
{

    public GameObject fire;

    public void Awake()
    {
        fire.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter "+collision.gameObject.name);
        Destroy(gameObject);
    }

    private void OnCollisionStay(Collision collision)
    {
        
        Debug.Log("Collision Stay "+collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit "+collision.gameObject.name);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("On Trigger Enter "+other.gameObject.name);
        fire.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        
        Debug.Log("On Trigger Stay " + other.gameObject.name);
        
    }

    private void OnTriggerExit(Collider other)
    {
        fire.SetActive(false);
        Debug.Log("On Trigger Exit " + other.gameObject.name);
        
    }

}
