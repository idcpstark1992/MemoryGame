using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsSpawner : MonoBehaviour
{
    [SerializeField] private CardsFactory   _CardsFactory;
    [SerializeField] private List<string>   CardsIDS;
    [SerializeField] private List<CardItem> CachedCards = new List<CardItem>();
    private IAddCacheCards AddCardsCache;
    
    public void Configure (IAddCacheCards _DependeceInjection)
    {
        AddCardsCache = _DependeceInjection;
    }

    private void SpawnCards()
    {

        foreach (var item in CardsIDS)
        {
            CachedCards.Add(_CardsFactory.CreateCardInstance(item));
        }
        foreach (var item in CardsIDS)
        {
            CachedCards.Add(_CardsFactory.CreateCardInstance(item));
        }
        AddCardsCache.AddCardsToCache(ref CachedCards);
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            SpawnCards();
    }
}
