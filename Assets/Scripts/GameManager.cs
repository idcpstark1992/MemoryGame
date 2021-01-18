using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    [SerializeField] private IGrid              _Grid;
    [SerializeField] private int                GridSize;
    [SerializeField] private List<string>       IdsToCompare = new List<string>();
    [SerializeField] private int                Points;
    [SerializeField] private GraphicRaycaster   ThisRayCaster;
    [SerializeField] private string             PassId;
    [SerializeField] private IConfigureDescriptionInformaiton  _ConfigureDescriptionInformation;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        _Grid.ConfigureGridSize(GridSize);
    }
    public void Configure(IGrid _Inyection, IConfigureDescriptionInformaiton _Iconfigure)
    {
        _Grid = _Inyection;
        _ConfigureDescriptionInformation = _Iconfigure;
    }
    
    public void SetGameConfiguration()
    {
        _Grid.ConfigureGridSize(GridSize);
    }
    public void AddItemToCompare(string _IdComprasion)
    {
        IdsToCompare.Add(_IdComprasion);
        if(IdsToCompare.Count == 2)
        {
            if (IdsToCompare[0].Equals(IdsToCompare[1]))
            {
                PassId = _IdComprasion;
                Invoke("ExecuteMathPoint", 1f);

            }
            else
            {
                ThisRayCaster.enabled = false;
                Invoke("ExecuteHideCards", 1f);
            }
            IdsToCompare.Clear();
        }
    }
    private void ExecuteHideCards()
    {
        Delegates.Listener_OnVerification.Invoke(false);
        ThisRayCaster.enabled = true;
    }
    private void ExecuteMathPoint()
    {
        Delegates.Listener_OnVerification.Invoke(true);
        Points += 1;
        if(CharactersInformation.CharInformation.TryGetValue(PassId, out InformationChars informationChars))
        {
            _ConfigureDescriptionInformation.ConfigureDescriptionInfo(informationChars);
        }
        
    }

}
