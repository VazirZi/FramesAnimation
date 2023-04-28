using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimatable
{
    public Sprite[] Sprites { get; }
    public SpriteRenderer SpriteRenderer { get; }

    public IEnumerator PlayAnimation()
    {
        while (true)
        {
            SpriteRenderer.sprite = Sprites[0];

            for (int i = 0; i < Sprites.Length; i++)
            {
                SpriteRenderer.sprite = Sprites[i];
                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}