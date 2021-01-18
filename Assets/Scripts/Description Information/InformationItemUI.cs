using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationItemUI : MonoBehaviour , IConfigureDescriptionInformaiton
{
    [SerializeField] private InformationChars       ThisInformation;
    [SerializeField] private TMPro.TextMeshProUGUI  PrintName;
    [SerializeField] private UnityEngine.UI.Image   PrintArtwork;
    public void OnClicked()
    {
        ConfigureInformation.Instance.GetComponent<IConfigureDescriptionInformaiton>().ConfigureDescriptionInfo(ThisInformation);
    }

    public void ConfigureDescriptionInfo(InformationChars _IncharInfo)
    {
        ThisInformation = _IncharInfo;
        PrintName.text = _IncharInfo.SpanishName;
        PrintArtwork.sprite = _IncharInfo.Art;
    }
}
