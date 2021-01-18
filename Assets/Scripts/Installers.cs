using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Installers : MonoBehaviour
{
    [Header("Interfaces a Instalar")]
    [SerializeField] private CardsGridGenerator _IGrid;
    [SerializeField] private CardsGridGenerator _AddCachedCards;
    [SerializeField] private InformationManager _IconfigureInformation;
    [Space(10)]
    [Header("Clases para Inyectar")]
    [SerializeField] private CardsSpawner       ToInstallAddCachecards;
    [SerializeField] private GameManager        ToInstallGameManager;



    private void Start()
    {
        ToInstallAddCachecards.Configure(_AddCachedCards);
        ToInstallGameManager.Configure(_IGrid,_IconfigureInformation);
    }

}
