using UnityEngine;
using Cinemachine;

public class CameraActivator : MonoBehaviour
{
	public CinemachineVirtualCameraBase m_ActivatedCamera;

	void OnTriggerEnter(Collider coll)
	{
		m_ActivatedCamera.m_Priority = 100;
	}

	void OnTriggerExit(Collider coll)
	{
		m_ActivatedCamera.m_Priority = -100;
	}
}
