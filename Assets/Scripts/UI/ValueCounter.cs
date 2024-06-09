using ScriptableObjectArchitecture;
using TMPro;
using UnityEngine;

public class ValueCounter : MonoBehaviour
{
    [SerializeField] private FloatVariable _value;
    [SerializeField] private TextMeshProUGUI _valueText;

    private void Update()
    {
        _valueText.text = $"{_value.name.ToUpper()}: {_value.Value}";
    }
}
