using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardItem : MonoBehaviour
{
    [SerializeField] private CardDataItem           _CardDataItem;
    [SerializeField] private SpriteRenderer         PrintArtWork;
    public string ID   { get; private set; }
    public Sprite ART { get; private set; }
    private void Start()
    {
        ID =    _CardDataItem.IDItem;
        ART =   _CardDataItem.ArtWork;
        PrintCards();
    }
    private void PrintCards()
    {
        PrintArtWork.sprite     = ART;
    }

}
