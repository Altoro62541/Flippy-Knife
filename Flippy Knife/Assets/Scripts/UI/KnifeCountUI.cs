using UnityEngine;
public class KnifeCountUI : MonoBehaviour
{
    [SerializeField] private KnifeFactorySettings _knifeFactorySettings;
    [SerializeField] private KnifeFactory _knifeFactory;
    [SerializeField] private GameObject[] _knifeElements;

    public void Remove()
    {
        if (_knifeFactorySettings.KnifeCount != 0)
        {
            _knifeElements[_knifeFactory._currentIndex - 1].SetActive(false);
        }
    }
}
