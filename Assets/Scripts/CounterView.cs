using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _textValue;

    private void OnEnable()
    {
        _counter.CountChanged += UpdateTextValue;
    }

    private void OnDisable()
    {
        _counter.CountChanged -= UpdateTextValue;
    }

    private void UpdateTextValue(int newCount)
    {
        _textValue.text = $"Counter: {newCount}";
    }
}