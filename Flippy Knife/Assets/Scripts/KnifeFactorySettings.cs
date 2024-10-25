using UnityEngine;
[CreateAssetMenu] 
public class KnifeFactorySettings : ScriptableObject 
{
    [SerializeField] private int _knifeCount = 5;
    public int KnifeCount => _knifeCount;
}
