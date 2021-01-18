using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardItem : MonoBehaviour 
{
    [SerializeField] private UnityEngine.UI.Image   PrintArtWork;
    [SerializeField] private RectTransform CoverTransform;
    [SerializeField] private GameObject CardObject;
    private bool ClickedCard;
    public string ID;
    public void ConfigureCardItem(string _CardId, Sprite _Art)
    {
        ID = _CardId;
        PrintArtWork.sprite = _Art;
    }  

    private void OnEnable()
    {
        Delegates.Listener_OnVerification += OnVerificationEvent;
    }
    private void OnDisable()
    {
        Delegates.Listener_OnVerification -= OnVerificationEvent;
    }

    public void OnClicked()
    {
        ClickedCard = true;
        GameManager.Instance.AddItemToCompare(ID);
        LeanTween.scale(CoverTransform, Vector3.zero, .2f);
    }

    public void OnVerificationEvent(bool _isMatch)
    {
        if (ClickedCard)
        {
            if (_isMatch)
                LeanTween.scale(CardObject, Vector3.zero, .2f);
            else
                LeanTween.scale(CoverTransform, Vector3.one, .2f);
        }
        ClickedCard = false;
    }

}
