Shader "Custom/RimLighting"
{
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
            float3 worldNormal;
            float3 viewDir;
        };

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 baseColor = fixed4(0.05, 0.1, 0, 1);
            fixed4 rimColor = fixed4(0.5, 0.7, 0.5, 1);

            o.Albedo = baseColor;
            float rim = 1 - saturate(dot(IN.viewDir, o.Normal));
            o.Emission = rimColor * pow(rim, 3);
        }
        ENDCG
    }
    FallBack "Diffuse"
}
