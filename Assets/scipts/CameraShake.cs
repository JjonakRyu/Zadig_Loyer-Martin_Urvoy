using System.Collections;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    private CinemachineBasicMultiChannelPerlin noise;
    private bool isShaking = false;

    private void Start()
    {
        if (virtualCamera != null)
        {
            noise = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isShaking)
        {
            StartCoroutine(ShakeForDuration(8f)); // Shake the camera for 5 seconds when 'E' is pressed
        }
    }

    private IEnumerator ShakeForDuration(float duration)
    {
        if (noise != null)
        {
            isShaking = true; // Set flag to indicate shaking is active

            float timer = 0f;
            float startAmplitude = 1f; // Initial amplitude value
            float startFrequency = 20f; // Initial frequency value

            while (timer < duration)
            {
                float amplitude = Mathf.Lerp(startAmplitude, 0f, timer / duration); // Smoothly decrease amplitude
                float frequency = Mathf.Lerp(startFrequency, 0f, timer / duration); // Smoothly decrease frequency

                noise.m_AmplitudeGain = amplitude;
                noise.m_FrequencyGain = frequency;

                timer += Time.deltaTime;
                yield return null;
            }

            // Reset noise parameters after duration ends
            noise.m_AmplitudeGain = 0f;
            noise.m_FrequencyGain = 0f;

            isShaking = false; // Reset flag
        }
    }
}
