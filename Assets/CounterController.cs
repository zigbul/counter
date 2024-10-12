using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    [SerializeField] private Text _counterText;
    private int _counter = 0;
    private bool _isCounting = false;
    private float _waitingTime = 0.5f;

    void Update()
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

    IEnumerator CountCoroutine()
    {
        while (true)
        {
            _counter++;
            _counterText.text = "Counter: " + _counter;
            yield return new WaitForSeconds(_waitingTime);
        }
    }
}
