using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigureInformation : MonoBehaviour, IConfigureDescriptionInformaiton
{
    public static ConfigureInformation Instance { get; private set; }
    [SerializeField] private TMPro.TextMeshProUGUI PrintName;
    [SerializeField] private TMPro.TextMeshProUGUI PrintDescription;
    [SerializeField] private UnityEngine.UI.Image printImage;
    
    private void Awake()
    {
        Instance = this;
    }
    public void ConfigureDescriptionInfo(InformationChars _IncharInfo)
    {
        PrintName.text = _IncharInfo.SpanishName;
        PrintDescription.text = _IncharInfo.SpanishDescription;
        printImage.sprite = _IncharInfo.Art;
        OpenCloseInformationPanel.Instance.OnOpenPanel(1);
    }
}
