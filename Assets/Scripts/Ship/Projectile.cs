using UnityEngine;
using System;

public class Projectile : MonoBehaviour
{
    
    public float timeToReset = 5f;
    public Vector3 direction;

    public string tagToLookFor = "Enemy";


    public Action OnHitTarget;

    void Update()
    {
        transform.Translate(direction*Time.deltaTime);
    }

    

    public void StartProjectile()
        
        { 
        Invoke(nameof(FinishUsage), timeToReset);
        }

    private void FinishUsage()
    {
        gameObject.SetActive(false);
        OnHitTarget = null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == tagToLookFor)
           {
            Destroy(collision.gameObject);
            OnHitTarget.Invoke();
            FinishUsage();

           }
    }
}
