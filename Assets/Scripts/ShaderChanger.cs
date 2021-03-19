using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
TODO:ShaderChange UI

*/
public class ShaderChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // TODO:Shader(material)をScriptから変更
        var renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", Color.black);
        renderer.material.SetFloat("_Metaric", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
