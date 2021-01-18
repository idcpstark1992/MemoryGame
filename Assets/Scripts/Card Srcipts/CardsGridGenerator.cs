using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsGridGenerator : MonoBehaviour  , IAddCacheCards , IGrid
{
    [SerializeField] private List<CardItem> ItemsToSort;
    [SerializeField] private List<CardItem> ItemsToPasteInGrid;
    [Space(10)]
    [SerializeField] private RectTransform GridPanelParent;
    
    public void AddCardsToCache(ref List<CardItem> _InputList)
    {
        ItemsToSort = _InputList;
        CreateGridItems();
    }
    public void ConfigureGridSize(int _GridSize)
    {
      
    }
    private  void CreateGridItems()
    {
        PrintGridItems(ItemsToSort);
    }
    private void PrintGridItems(List<CardItem> _InputList)
    {
        Debug.Log(_InputList.Count);
        while (_InputList.Count > 0)
        {
            int IndexToAdd = Random.Range(0, _InputList.Count);
            ItemsToPasteInGrid.Add(_InputList[IndexToAdd]);
            _InputList.RemoveAt(IndexToAdd);
        }
        for (int i = 0; i < ItemsToPasteInGrid.Count; i++)
        {
            ItemsToPasteInGrid[i].transform.SetParent(GridPanelParent);
        }
    }

}
