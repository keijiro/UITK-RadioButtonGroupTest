using UnityEngine;
using UnityEngine.UIElements;
using Unity.Properties;

public sealed class Test : MonoBehaviour
{
    [CreateProperty] public int Index { get; set; }

    void Update()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        var idx = root.Q<RadioButtonGroup>("radio-button-group").value;

        root.Q<Label>("label1").text = $"Value from binding = {Index}";
        root.Q<Label>("label2").text = $"RadioButtonGroup.value = {idx}";
    }
}

