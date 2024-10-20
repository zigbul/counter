using UnityEngine;
using TMPro;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;

    public void UpdateCounterText(int counterValue)
    {
        _counterText.text = "Counter: " + counterValue.ToString();
    }
}
