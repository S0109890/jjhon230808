using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SliderController : MonoBehaviour
{
    public Slider slider; // Inspector���� �Ҵ��� �����̴�
    private float duration = 10f; // �ִϸ��̼� ���� �ð� (��)
    private float elapsedTime = 0f;

    void Start()
    {
        // ���� �� �����̴��� ���� �ִ�� ����
        slider.value = slider.maxValue;

        // 10�� ���� �����̴� ���� ���̴� �ڷ�ƾ ����
        StartCoroutine(ReduceSliderValue());
    }

    private IEnumerator ReduceSliderValue()
    {
        while (elapsedTime < duration)
        {
            // ��� �ð� ������Ʈ
            elapsedTime += Time.deltaTime;

            // �����̴� �� ���
            float newValue = Mathf.Lerp(slider.maxValue, slider.minValue, elapsedTime / duration);

            // �����̴� �� ����
            slider.value = newValue;

            yield return null;
        }
    }
}
