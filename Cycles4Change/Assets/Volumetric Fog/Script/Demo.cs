using UnityEngine;
using System.Collections.Generic;

public class Demo : MonoBehaviour
{
	public GameObject[] m_FogObjects;
	private float m_FogDensity = 0.001f;
	private float m_FogSpeed = 0.5f;
	private Noise3D m_NoiseTexture = new Noise3D ();
	private Rect[] m_GUIRects = new Rect[2];
	
	public bool MouseOnGUI ()
	{
		for (int i = 0; i < m_GUIRects.Length; i++)
		{
			if (m_GUIRects[i].Contains (new Vector2 (Input.mousePosition.x, Screen.height - Input.mousePosition.y)))
				return true;
		}
		return false;
	}
    private void Start ()
	{
		m_NoiseTexture.Create (64, 16);
		for (int i = 0; i < m_FogObjects.Length; i++)
		{
			MeshRenderer rd = m_FogObjects[i].GetComponent<MeshRenderer>();
			rd.material.SetTexture ("_FogNoiseTex", m_NoiseTexture.Get ());
		}
		m_GUIRects[0] = new Rect (75, 50, 180, 25);
		m_GUIRects[1] = new Rect (75, 80, 180, 25);
	}
	private void Update ()
    {
		for (int i = 0; i < m_FogObjects.Length; i++)
		{
			Vector4 scaleBias = new Vector4 (0, m_FogSpeed * Time.realtimeSinceStartup, 0, 0.0008f);
			MeshRenderer rd = m_FogObjects[i].GetComponent<MeshRenderer>();
			rd.material.SetVector ("_FogScaleBias", scaleBias);
			rd.material.SetFloat ("_FogDensity", m_FogDensity);
		}
    }
	private void OnGUI ()
	{
		GUI.Box (new Rect (10, 10, 240, 25), "Volumetric Fog Demo");
		GUI.Box (new Rect (10, 40, 60, 25), "Density");
		m_FogDensity = GUI.HorizontalSlider  (m_GUIRects[0], m_FogDensity, 0f, 0.005f);
		GUI.Box (new Rect (10, 70, 60, 25), "Speed");
		m_FogSpeed = GUI.HorizontalSlider  (m_GUIRects[1], m_FogSpeed, 0f, 0.7f);
	}
}
