using UnityEngine;

public class KnifeThrow : MonoBehaviour
{
    [SerializeField] private GameObject _targetGameObject; 
    [SerializeField] private Vector2 _throwForce;
    public static Rigidbody2D _knifeRb;
    public static BoxCollider2D _knifeCollider;
    public static bool _isActive = true;

    private void Awake()
    {
        _knifeCollider = _targetGameObject.GetComponent<BoxCollider2D>();
        _knifeRb = _targetGameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {   
        if(Input.GetMouseButtonDown(0) && _isActive)
        {
            _knifeRb.AddForce(_throwForce, ForceMode2D.Impulse);
            _knifeRb.gravityScale = 1;
            //TODO: Декремент оставшегося количества доступных ножей в запасе.
        }
    }
}