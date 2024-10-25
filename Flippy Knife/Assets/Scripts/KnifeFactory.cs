using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class KnifeFactory : MonoBehaviour
{
    [SerializeField] private KnifeFactorySettings _knifeFactorySettings;
    [SerializeField] private KnifeHit _knifePrefab;
    [SerializeField] private KnifeCountUI _knifeCountUI;
    [SerializeField] private Transform _createPoint;
    private KnifeHit _currentKnife;
    public int _currentIndex;

    private void Start()
    { 
        
        Create();  
    }
    public void Create()
    {  
        if(_currentKnife != null)
        {
            _currentKnife.OnHit -= OnHit;
        }
        if(_currentIndex < _knifeFactorySettings.KnifeCount)
        {
            _currentKnife = Instantiate(_knifePrefab, _createPoint.position, quaternion.identity);
            
            _currentIndex++;
            _currentKnife.OnHit += OnHit;
            _currentKnife.OnHit += Remove;
        }

    }
    private void Remove()
    {
        _knifeCountUI.Remove();
    }

    private void OnHit()
    {
        StartCoroutine(Delay());
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.2f);
        _currentKnife.OnHit -= Remove;
        Create();
    }
}
