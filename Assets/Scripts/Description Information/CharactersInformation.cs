using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersInformation : MonoBehaviour
{
    [SerializeField] private List<InformationChars>     InformationInput    = new List<InformationChars>();
    public static Dictionary<string, InformationChars>  CharInformation     = new Dictionary<string, InformationChars>();

    private void Start()
    {
        foreach (var item in InformationInput)
        {
            if (!CharInformation.ContainsKey(item.IDInformationRow))
                CharInformation.Add(item.IDInformationRow,item);
        }
    }
}
[System.Serializable]
public class InformationChars
{
    public string IDInformationRow;
    public string SpanishName;
    public string EnglishName;
    public string SpanishDescription;
    public string EnglishDescription;
    public InformationChars(string _InputID , string _InspanishName, string _InEnglishName, string _InSpanishDescription , string _InEnglishDescription)
    {
        IDInformationRow    = _InputID;
        SpanishName         = _InspanishName;
        EnglishName         = _InEnglishName;
        SpanishDescription  = _InSpanishDescription;
        EnglishDescription  = _InEnglishDescription;
    }
}