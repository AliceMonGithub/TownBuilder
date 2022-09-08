using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class SpriteColorConfig
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _color;

    public SpriteRenderer SpriteRenderer => _spriteRenderer;
    public Color Color => _color;
}

[CreateAssetMenu]
public class HouseBehaviour : ScriptableObject
{
    public int ClicksToBuild;
    public int ClickCount;

    public bool Builded;
}
