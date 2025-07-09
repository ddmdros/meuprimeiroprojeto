using UnityEngine;

public class BossBase : MonoBehaviour, IKillable, IDamageable<int>
{
    public int life;
    [SerializeField] private float force;

    private int _currentlife;

    private void Awake()
    {
        Init();
    }
    protected virtual void Init()
    {
        _currentlife = life;
    }

    public virtual void Attack()
    {
        Debug.Log("Attack:" + force);
    }

    public void Kill()
    {
        Destroy(gameObject);
    }

    public void Damage(int f)
    {
        _currentlife -= f;

        transform.localScale *= 0.9f;
        if (_currentlife <= 0) Kill();
    }
}
