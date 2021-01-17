using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsSpawner : MonoBehaviour
{
    private CardTypeSelector CardSelector;
    [SerializeField] private CardsFactory _CardsFactory;
    [SerializeField] private List<string> CardsIDS;
    void Start()
    {
        CardSelector = new CardTypeSelector(CardsIDS);
    }

    private void SpawnCards()
    {
        
    }
}
