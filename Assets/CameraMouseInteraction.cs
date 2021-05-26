using UnityEngine;
using Cinemachine;

public class CameraMouseInteraction : MonoBehaviour {
    public CinemachineFreeLook cameraLook;

    private void FixedUpdate() {
        if (Input.GetMouseButton(0)) {
            cameraLook.m_YAxis.m_InputAxisName = "Mouse Y";
            cameraLook.m_XAxis.m_InputAxisName = "Mouse X";
        } else if (Input.GetMouseButton(1)) {
            cameraLook.m_YAxis.m_InputAxisName = "Mouse Y";
        } else {
            cameraLook.m_YAxis.m_InputAxisName = "";
            cameraLook.m_XAxis.m_InputAxisName = "";
            cameraLook.m_YAxis.m_InputAxisValue = 0f;
            cameraLook.m_XAxis.m_InputAxisValue = 0f;
        }
    }
}
