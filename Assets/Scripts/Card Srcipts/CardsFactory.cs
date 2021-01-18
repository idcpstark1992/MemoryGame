using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CardsFactory : MonoBehaviour
{
    [SerializeField] private List<CardDataItem>         InputCardsDataBase      = new List<CardDataItem>();
    [SerializeField] private CardItem                   CardItemTemplate;
    private Dictionary<string, CardDataItem>            CardsCacheDataBase      = new Dictionary<string, CardDataItem>();



    private void Awake()
    {
        foreach (var item in InputCardsDataBase)
        {
            if (!CardsCacheDataBase.ContainsKey(item.IDItem))
            {
                CardsCacheDataBase.Add(item.IDItem,item);
            }
                
        }
    }

    public CardItem CreateCardInstance(string _CardID)
    {
        if (!CardsCacheDataBase.TryGetValue(_CardID, out CardDataItem value))
            throw new ArgumentOutOfRangeException(string .Concat("No existe la carta :" , _CardID));

       
        CardItemTemplate.ConfigureCardItem(_CardID, value.ArtWork);
        return Instantiate(CardItemTemplate);
    }

}
