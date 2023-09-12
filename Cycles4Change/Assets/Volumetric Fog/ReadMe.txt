Thank you for downloading !
Dynamic Volumetric Fog offers GPU approach to simulate natural fog phenomenon in 3d environment.

How to setup ?
=> Fog depend on a 3d noise texture, so all you need to do is transfer the 3d noise texture to material.
   1. The script "Noise3D.cs" is a 3d noise generator, call "Create" function to generate a 3d noise texture.
   2. Then just call "SetTexture" transfer the 3d noise to material which applyed on the game object.
   3. There are 3 shaders in package:
      => "Volumetric Fog/Texture" is foggy textured shader.
	  => "Volumetric Fog/Diffuse Texture" is foggy lighted textured shader.
	  => "Volumetric Fog/Bump Diffuse Texture" is foggy lighted bump textured shader.
	  And yes of course you can easily integrate the foggy effect into any existing shaders in your own projects.
	  Just call "VFog" function in "Core.cginc".
   
=> Please open "Demo.unity" to see the effect.
   1. The reference script "Demo.cs" is a demonstration about how to use effect in unity ( with some tiny UI logic script ).
   2. In script "Demo.cs" we use an array "m_FogObjects" to hold all "foggy objects" and transfer the generated 3d noise texture to their material when game start.

If you like it, please vote me 5 star on asset store. Thanks so much !
Any suggestion or improvement you want, please contact qq_d_y@163.com.