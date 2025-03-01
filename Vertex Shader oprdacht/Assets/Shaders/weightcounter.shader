﻿Shader "MyShader/FatMaker" {
	Properties{
	  _MainTex("Texture", 2D) = "white" {}
	  _Amount("Extrusion Amount", Range(0,1)) = 0.5
	}
		SubShader{
		  Tags { "RenderType" = "Opaque" }
		  CGPROGRAM
		  #pragma surface surf Lambert vertex:vert
		  struct Input {
			  float2 uv_MainTex;
		  };
		  float _Amount;
		  void vert(inout appdata_full v) {
			  v.vertex.xyz += v.normal * _Amount /100;
		  }
		  sampler2D _MainTex;
		  void surf(Input IN, inout SurfaceOutput o) {
			  o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
		  }
		  ENDCG
	  }
		  Fallback "Diffuse"
}