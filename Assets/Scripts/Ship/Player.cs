using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootingPoint;
    public Vector3 direction;

    public PoolManager poolManager;

    public int deathNumber = 0;

    public bool canMove = false;

    public MeshRenderer meshRenderer;

    public void ChangeColor(Color c)
    {
        meshRenderer.material.SetColor("_Color", c);
    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if (!canMove) return;
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(direction * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-direction * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }
        private void SpawnObject()
    {

        var obj = poolManager.GetPooledObject();
        obj.SetActive(true);
        obj.GetComponent<Projectile>().StartProjectile();
        obj.GetComponent<Projectile>().OnHitTarget = CountDeaths;
        //obj.transform.SetParent(null);
        obj.transform.position = shootingPoint.transform.position;

    }

    private void CountDeaths()
    {
        deathNumber++;
        Debug.Log("Death count "+ deathNumber);
    }
}


