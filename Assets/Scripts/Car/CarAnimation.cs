using UnityEngine;
using DG.Tweening;
public class CarAnimation : MonoBehaviour
{
    public float duration = 2;
    public Ease ease = Ease.Linear; 
    void Start()
    {
        transform.DOMoveX((float)2.5, duration).SetEase(ease);
    }

    
}
