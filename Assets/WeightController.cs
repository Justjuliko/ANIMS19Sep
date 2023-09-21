using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;

public class SliderWeightController : MonoBehaviour
{
    public Rig weightRig;
    public Slider weightSlider;

    // Update is called once per frame
    void Update()
    {
        weightRig.weight = weightSlider.value;
    }
}
