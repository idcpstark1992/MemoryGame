using UnityEngine;
using System.Collections.Generic;

public class CardTypeSelector 
{
    [SerializeField] private List<string> CardsIDs;

    public CardTypeSelector (List<string> _InputCardsIDs)
    {
        CardsIDs = _InputCardsIDs;
    }

    public string SelectCard()
    {
        return CardsIDs[Random.Range(0, CardsIDs.Count)];
    }
}
