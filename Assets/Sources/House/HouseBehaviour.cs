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

public class HouseBehaviour : MonoBehaviour
{
    [SerializeField] private UnityEvent _onBuilding;
    [SerializeField] private UnityEvent _onBuilded;

    [Space]

    [SerializeField] private Color _notBuildedColor;

    [SerializeField] private int _clicksToBuild;

    [Space]

    [SerializeField] private SpriteColorConfig[] _nonBuildHouseSprites;
    [SerializeField] private SpriteColorConfig[] _buildedHouseSprites;

    private int _currentClicksCount;
    private bool _builded;

    private void Awake()
    {
        foreach (SpriteColorConfig config in _nonBuildHouseSprites)
        {
            config.SpriteRenderer.color = config.Color;
        }
    }

    public void Build()
    {
        if (_builded) return;

        _currentClicksCount++;

        if(_currentClicksCount >= _clicksToBuild)
        {
            _onBuilded.Invoke();

            FinishBuilding();

            _builded = true;

            return;
        }

        _onBuilding.Invoke();
    }

    public void ParticleInClick(ParticleSystem particleSystem)
    {
        var position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Instantiate(particleSystem, position, Quaternion.identity);
    }

    private void FinishBuilding()
    {
        foreach (SpriteColorConfig config in _buildedHouseSprites)
        {
            config.SpriteRenderer.color = config.Color;
        }
    }
}
