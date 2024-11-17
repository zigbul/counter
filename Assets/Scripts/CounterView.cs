using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _counterText;

    private void OnEnable()
    {
        _counter.OnCountChanged += UpdateCounterText;
    }

    private void OnDisable()
    {
        _counter.OnCountChanged -= UpdateCounterText;
    }

    private void UpdateCounterText(int newCount)
    {
        _counterText.text = $"Counter: {newCount}";
    }
}