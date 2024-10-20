using System.Collections;
using UnityEngine;

public class CounterController : MonoBehaviour
{
    [SerializeField] private float _waitingTime = 0.5f;
    [SerializeField] private CounterView _counterView;

    private int _counterValue = 0;
    private bool _isCounting = false;
    private bool isWorking = true;
    private static WaitForSeconds _waitTime;

    private void Start()
    {
        _waitTime = new WaitForSeconds(_waitingTime);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                StopCoroutine(nameof(CountCoroutine));
            }
            else
            {
                StartCoroutine(nameof(CountCoroutine));
            }

            _isCounting = !_isCounting;
        }
    }

    private IEnumerator CountCoroutine()
    {
        while (isWorking)
        {
            _counterValue++;
            _counterView.UpdateCounterText(_counterValue);

            yield return _waitTime;
        }
    }
}
