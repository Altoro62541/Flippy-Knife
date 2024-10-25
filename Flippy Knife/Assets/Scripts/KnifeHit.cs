using UnityEngine;
using System;
public class KnifeHit : MonoBehaviour
{
    private Knife _knife;
    public event Action OnHit;
    private void Start()
    {
        _knife = GetComponent<Knife>();
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.GetComponent<LogRotation>())
        {
            _knife.LogHit();
            transform.SetParent(other.collider.transform);
            OnHit?.Invoke();
            
        }
        else if(other.collider.GetComponent<Knife>())
        {
            _knife.Down();
            _knife.IsActive = false;
        }
    }
}
