using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatable : MonoBehaviour, IAnimatable
{
    public Sprite[] Sprites => sprites;
    public SpriteRenderer SpriteRenderer => spriteRenderer;

    private IAnimatable animatable => this;

    private Coroutine _frameAnimation;

    [SerializeField] Sprite[] sprites;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Awake()
    {
        _frameAnimation = StartCoroutine(animatable.PlayAnimation());
    }

    private void OnDisable() 
    {
        StopCoroutine(_frameAnimation);    
    }
}
