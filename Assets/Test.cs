using UnityEngine;
using UnityEngine.UIElements;
using Unity.Properties;

public sealed class Test : MonoBehaviour
{
    int _index = 0;

    [CreateProperty] public int Index
    {
        get { Debug.Log("GET"); return _index; }
        set { Debug.Log("SET"); _index = value; }
    }

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var radio = root.Q<RadioButtonGroup>("radio-button-group");
        radio.dataSource = this;
    }

    void Update()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var radio = root.Q<RadioButtonGroup>("radio-button-group");
        root.Q<Label>("label1").text = $"Value from binding = {_index}";
        root.Q<Label>("label2").text = $"RadioButtonGroup.value = {radio.value}";
    }
}

