using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _interval = 0.5f;

    private int _count = 0;
    private bool _isCounting = false;
    private WaitForSeconds _waitTime;
    private Coroutine _currentCoroutine;

    public event Action<int> CountChanged;

    private void Start()
    {
        _waitTime = new WaitForSeconds(_interval);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isCounting = !_isCounting;

            if (_isCounting)
            {
                _currentCoroutine = StartCoroutine(CountCoroutine());
            }
            else
            {
                StopCoroutine(_currentCoroutine);
            }
        }
    }

    private IEnumerator CountCoroutine()
    {
        while (_isCounting)
        {
            _count++;
            CountChanged?.Invoke(_count);

            yield return _waitTime;
        }
    }
}