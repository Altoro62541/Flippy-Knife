using UnityEngine;
using DG.Tweening;
public class Knife : MonoBehaviour
{ 
    [SerializeField] private Vector2 _throwForce;
    private Rigidbody2D _rigidBody;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private Color _defaultColor;
    public bool IsActive {get; set;} = true;

    private void Awake()
    {
        _defaultColor = _spriteRenderer.material.color;
        _rigidBody = GetComponent<Rigidbody2D>();
        
        _spriteRenderer.DOColor(_defaultColor, 0.3f);
        _rigidBody.DOMoveY(-3f, 0.1f);
    }

    private void Update()
    {   
        if(Input.GetMouseButtonDown(0) && IsActive)
        {
            _rigidBody.AddForce(_throwForce, ForceMode2D.Impulse);
            _rigidBody.gravityScale = 1;
        }
    }

    public void LogHit()
    {
        _rigidBody.velocity = new Vector2(0, 0);
        _rigidBody.bodyType = RigidbodyType2D.Kinematic;
    }
    public void Hit()
    {
        _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, -2); 
    }
    public void Down()
    {
        _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, 2); 
    }
}