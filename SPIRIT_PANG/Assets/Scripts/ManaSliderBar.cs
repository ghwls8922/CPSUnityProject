using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaSliderBar : MonoBehaviour
{
    [SerializeField] private Slider manaPoint_Slider;

    void Update()
    {
        manaPoint_Slider.value += (Time.deltaTime * 5) ;
    }
}
