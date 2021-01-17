using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CardsFactory : MonoBehaviour
{
    [SerializeField] private List<CardItem> InputCardsDataBase      = new List<CardItem>();

    private Dictionary<string, CardItem>    CardsCacheDataBase      = new Dictionary<string,CardItem>();

    private void Awake()
    {
        foreach (var item in InputCardsDataBase)
        {
            if (!CardsCacheDataBase.ContainsKey(item.ID))
                CardsCacheDataBase.Add(item.ID,item);
        }
    }

    public CardItem CreateCardInstance(string _CardID)
    {
        if (!CardsCacheDataBase.TryGetValue(_CardID, out CardItem value))
            throw new ArgumentOutOfRangeException(string .Concat("No existe la carta :" , _CardID));


        return Instantiate(value);
    }
}
