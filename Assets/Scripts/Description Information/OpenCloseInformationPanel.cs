using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseInformationPanel : MonoBehaviour
{
    public static OpenCloseInformationPanel Instance { get; private set; }
    [SerializeField] private List<GameObject> FoldableItems = new List<GameObject>();
    private void Awake()
    {
        Instance = this;
    }
    public void OnOpenPanel(int _index)
    {
        LeanTween.scale(FoldableItems[_index], Vector3.one, .1f);
    }
    public void OnClosePanel(int _index)
    {
        LeanTween.scale(FoldableItems[_index], Vector3.zero, .1f);
    }
    public void OnLeftOpenPanel(int _index)
    {
        LeanTween.scaleX(FoldableItems[_index], 1f, .1f);
    }
    public void OnLeftClosePanel(int _index)
    {
        LeanTween.scaleX(FoldableItems[_index], 0f, .1f);
    }
}
