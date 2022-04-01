using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEditor.Experimental.GraphView;

public class CanvasFade : MonoBehaviour
{
    [SerializeField] private Image background;
    [SerializeField] float fadeDuration;
    private Sequence seq1;
    private Sequence seq2;

    public void BackgroundFade()
    {
        Sequence seq1 = DOTween.Sequence();
        seq1.Append(background.DOColor(Color.grey, fadeDuration));
    }

    public void BackgroundAppear()
    {
        Sequence seq2 = DOTween.Sequence();
        seq2.Append(background.DOColor(Color.white, fadeDuration));
    }

    private void OnDisable()
    {
        seq1.Kill();
        seq2.Kill();
    }
}
