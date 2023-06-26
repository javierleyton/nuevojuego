using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostProcessController : MonoBehaviour
{
    [SerializeField] private Volume m_postProcess;

    private Bloom m_bloomEffect;

    [ContextMenu("Test bloom")]

    private void DisableBloom()
    {
        if (m_postProcess.sharedProfile.TryGet(out Bloom l_bloom))
        {
            l_bloom.intensity.value = 0;
        }
    }

}
