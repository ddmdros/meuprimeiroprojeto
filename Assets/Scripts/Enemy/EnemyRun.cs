using UnityEngine;

public class EnemyRun : EnemyBase
{
    [Header("Enemy Run")]
    public float speed;
    public void Awake()
    {
        Attack();
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log("Attack run");
    }

}
