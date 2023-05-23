// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "MGF/DiffuseMask"
{
	Properties
	{
		_SecondColor("SecondColor", Color) = (0,0,0,0)
		_Color2("Color ", Color) = (0,0,0,0)
		_Mask1("Mask", 2D) = "white" {}
		_Texture1("Texture", 2D) = "white" {}
		_SecondTexture("Second Texture", 2D) = "white" {}
		_Smoothness1("Smoothness", Range( 0 , 1)) = 0
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "Opaque"  "Queue" = "Geometry+0" }
		Cull Back
		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf Standard keepalpha addshadow fullforwardshadows 
		struct Input
		{
			float2 uv_texcoord;
		};

		uniform sampler2D _Mask1;
		uniform float4 _Mask1_ST;
		uniform float4 _Color2;
		uniform sampler2D _Texture1;
		uniform float4 _Texture1_ST;
		uniform sampler2D _SecondTexture;
		uniform float4 _SecondTexture_ST;
		uniform float4 _SecondColor;
		uniform float _Smoothness1;

		void surf( Input i , inout SurfaceOutputStandard o )
		{
			float2 uv_Mask1 = i.uv_texcoord * _Mask1_ST.xy + _Mask1_ST.zw;
			float4 tex2DNode2 = tex2D( _Mask1, uv_Mask1 );
			float2 uv_Texture1 = i.uv_texcoord * _Texture1_ST.xy + _Texture1_ST.zw;
			float2 uv_SecondTexture = i.uv_texcoord * _SecondTexture_ST.xy + _SecondTexture_ST.zw;
			o.Albedo = ( ( ( 1.0 - tex2DNode2 ) * _Color2 * tex2D( _Texture1, uv_Texture1 ) ) + ( tex2D( _SecondTexture, uv_SecondTexture ) * tex2DNode2 * _SecondColor ) ).rgb;
			o.Smoothness = _Smoothness1;
			o.Alpha = 1;
		}

		ENDCG
	}
	Fallback "Diffuse"
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=17800
284.8;73.6;858;434;1888.887;317.6784;2.410891;True;False
Node;AmplifyShaderEditor.SamplerNode;2;-1242.541,227.0888;Inherit;True;Property;_Mask1;Mask;2;0;Create;True;0;0;False;0;-1;None;cec35a71aa4c1884eafd3829ba3f0d71;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;1;-1226.375,-46.80603;Inherit;True;Property;_Texture1;Texture;3;0;Create;True;0;0;False;0;-1;None;5b660fe7045ce4741bf7136af8eb29c9;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ColorNode;3;-1174.009,-230.2066;Inherit;False;Property;_Color2;Color ;1;0;Create;True;0;0;False;0;0,0,0,0;1,0.05188677,0.05188677,0;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;11;-1227.191,460.3715;Inherit;True;Property;_SecondTexture;Second Texture;4;0;Create;True;0;0;False;0;-1;None;5b660fe7045ce4741bf7136af8eb29c9;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.ColorNode;4;-1157.896,673.1552;Inherit;False;Property;_SecondColor;SecondColor;0;0;Create;True;0;0;False;0;0,0,0,0;0.1094678,0.6037736,0.06550373,0;True;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.OneMinusNode;6;-865.0934,78.9726;Inherit;False;1;0;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;5;-844.2643,373.2834;Inherit;True;3;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;8;-652.9482,-69.41911;Inherit;True;3;3;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;2;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.RangedFloatNode;10;-306.0747,-84.07871;Inherit;False;Property;_Smoothness1;Smoothness;5;0;Create;True;0;0;False;0;0;0;0;1;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;9;-272.9143,76.50788;Inherit;False;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;0,0;Float;False;True;-1;2;ASEMaterialInspector;0;0;Standard;MGF/DiffuseMask;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;Back;0;False;-1;0;False;-1;False;0;False;-1;0;False;-1;False;0;Opaque;0.5;True;True;0;False;Opaque;;Geometry;All;14;all;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;2;15;10;25;False;0.5;True;0;0;False;-1;0;False;-1;0;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;-1;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;0;False;0.1;False;-1;0;False;-1;16;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;6;0;2;0
WireConnection;5;0;11;0
WireConnection;5;1;2;0
WireConnection;5;2;4;0
WireConnection;8;0;6;0
WireConnection;8;1;3;0
WireConnection;8;2;1;0
WireConnection;9;0;8;0
WireConnection;9;1;5;0
WireConnection;0;0;9;0
WireConnection;0;4;10;0
ASEEND*/
//CHKSM=435789CF0F16C7C68589D9C8EE5509C16FBD099E