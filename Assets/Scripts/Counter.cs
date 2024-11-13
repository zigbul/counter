using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _interval = 0.5f;

    private int _count = 0;
    private bool _isCounting = false;
    private WaitForSeconds _waitTime;

    public int Count => _count;

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
                StartCoroutine(CountCoroutine());
            }
            else
            {
                StopCoroutine(CountCoroutine());
            }
        }
    }

    private IEnumerator CountCoroutine()
    {
        while (_isCounting)
        {
            _count++;

            yield return _waitTime;
        }
    }
}