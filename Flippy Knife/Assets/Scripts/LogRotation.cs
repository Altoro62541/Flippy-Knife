using UnityEngine;
using DG.Tweening;
public class LogRotation : MonoBehaviour
{
    private Tween[] _logTweens = new Tween[1];
    void Start()
    {
          //Обычная цикличная анимация вращения полного оборота.
          _logTweens[0] = transform.DORotate(new Vector3(0f, 0f, 360f), 5f, RotateMode.FastBeyond360).SetLoops(-1);
    }
}
