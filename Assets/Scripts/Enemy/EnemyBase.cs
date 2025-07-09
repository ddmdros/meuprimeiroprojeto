using UnityEngine;

public class EnemyBase : MonoBehaviour, IKillable, IDamageable<int>
{
    #region CODE
    
    public EnemyData enemyData;

    private int _currentlife;

    private void Awake()
    {
        Init();
    }
    protected virtual void Init()
    {
        _currentlife = enemyData.startLife;
    }
    
    public virtual void Attack()
    {
        Debug.Log("Attack: ");
    }

    public virtual void OnDamage()
    { }
    #endregion

    #region INTERFACES
    public void Kill()
    {
        Destroy(gameObject);
    }

    public void Damage(int f)
    {
        _currentlife -= f;

        OnDamage();

        transform.localScale *= 0.9f;
        if (_currentlife <= 0) Kill();
    }
    #endregion
}
