using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class ShaderSelector : MonoBehaviour
{
    [SerializeField, Tooltip("シェーダ適用オブジェクト")]
    Transform[]   targets = null;

    [SerializeField, Tooltip("変更シェーダ")]
    Material[] materials = null;

    [SerializeField, Tooltip("シェーダリスト")]
    Dropdown materialList = null;

    void Start()
    {
        var renderers = new List<Renderer>();
        foreach (var t in targets) {
            var r = t.GetComponent<Renderer>();
            renderers.Add(r);
        }

        materialList.ObserveEveryValueChanged(_ => _.value)
            .Subscribe(index => {
                foreach(var r in renderers) {
                    r.material = materials[index];
                }
            });

        materialList.options.Clear();
        foreach (var m in materials) {
            var n = m.name;
            materialList.options.Add(new Dropdown.OptionData(n));
        }
        materialList.captionText.text = materials[0].name;
    }
}
