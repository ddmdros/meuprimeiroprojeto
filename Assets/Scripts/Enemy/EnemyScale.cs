using UnityEngine;
using System.Collections;

public class EnemyScale : EnemyBase
{
    [Header ("Enemy Scale")]
    public float scale = 1.5f;
    public float duration = 1f;
    public float durationfor = 100f;

    [Space()]
    public MeshRenderer meshRenderer;

    private bool _attacking = false;
    private Coroutine _currentCoroutine;

    public override void Attack()
    {
        base.Attack();

        if (!_attacking)
        {
            _attacking = true;
            transform.localScale *= scale;
            //Invoke(nameof(ResetScale), duration);
            //ChangeColor();
        }
        
    }

    public void ResetScale()
    {
        transform.localScale = Vector3.one;
        _attacking = false;
    }

    
    IEnumerator DelayCall()
    {
        //entro e espero 1 segundo
        yield return new WaitForSeconds(duration);
        
        transform.localScale *= scale;

        yield return new WaitForSeconds(duration);

        //faço o que tenho que fazer
        transform.localScale = Vector3.one;
        _attacking = false;

        
    }

    private void ChangeColor()
    {   for (float i = 1f; i >= 0; i -= .001f)
        {
            //meshRenderer.material.SetColor("_BaseColor", Color.Lerp(Color.white, Color.red, 1 - i));
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, Color.red, 1 - i));
        }
    }
    IEnumerator ChangeColorCoroutine()
    {
        for (float i = 1f; i >= 0; i -= .02f)
        {
            //meshRenderer.material.SetColor("_BaseColor", Color.Lerp(Color.white, Color.red, 1 - i));
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, enemyData.colorDamageable, 1 - i));
            yield return new WaitForEndOfFrame();
        }

        _currentCoroutine = null;
               
    }

    #region OVERRIDES
    public override void OnDamage()
    {
        base.OnDamage();
        if (_currentCoroutine == null)
        {
            _currentCoroutine = StartCoroutine(ChangeColorCoroutine());

        }
    }
    #endregion
}
