using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationManager : MonoBehaviour, IConfigureDescriptionInformaiton
{
    [SerializeField] private InformationItemUI  printablePrefab;
    [SerializeField] private RectTransform      ScrollViewHolder;

    public void ConfigureDescriptionInfo(InformationChars _IncharInfo)
    {
        printablePrefab.GetComponent<IConfigureDescriptionInformaiton>().ConfigureDescriptionInfo(_IncharInfo);
        Instantiate(printablePrefab, ScrollViewHolder);
    }
    
}
