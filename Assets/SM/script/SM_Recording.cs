using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrostweepGames.Plugins.GoogleCloud.SpeechRecognition.Examples
{
    public class SM_Recording : MonoBehaviour
    {
        private bool isRecording = false;
        private float stopRecordingDelay = 3f;

        private void Start()
        {
            StartRecording();
        }

        private void StartRecording()
        {
            if (!isRecording)
            {
                GCSR_Example.Instance.StartRecordButtonOnClickHandler(); // Assuming this is the method to start recording
                StartCoroutine(StopRecordingAfterDelay(10f));
                isRecording = true;
            }
        }

        private void StopRecording()
        {
            if (isRecording)
            {
                GCSR_Example.Instance.StopRecordButtonOnClickHandler(); // Assuming this is the method to stop recording
            }
        }
        private IEnumerator StopRecordingAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            StopRecording();
            isRecording = false;

        }

    }
}