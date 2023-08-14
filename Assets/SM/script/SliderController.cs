using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SliderController : MonoBehaviour
{
    public Slider slider; // Inspector에서 할당할 슬라이더
    private float duration = 10f; // 애니메이션 지속 시간 (초)
    private float elapsedTime = 0f;

    void Start()
    {
        // 시작 시 슬라이더의 값을 최대로 설정
        slider.value = slider.maxValue;

        // 10초 동안 슬라이더 값을 줄이는 코루틴 시작
        StartCoroutine(ReduceSliderValue());
    }

    private IEnumerator ReduceSliderValue()
    {
        while (elapsedTime < duration)
        {
            // 경과 시간 업데이트
            elapsedTime += Time.deltaTime;

            // 슬라이더 값 계산
            float newValue = Mathf.Lerp(slider.maxValue, slider.minValue, elapsedTime / duration);

            // 슬라이더 값 설정
            slider.value = newValue;

            yield return null;
        }
    }
}
