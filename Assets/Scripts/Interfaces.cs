
public interface IGrid
{
    void ConfigureGridSize(int _GridSize);
}

public interface IAddCacheCards
{
    void AddCardsToCache(ref System.Collections.Generic.List<CardItem> _InputList);
}

public interface IConfigureDescriptionInformaiton
{
    void ConfigureDescriptionInfo(InformationChars _IncharInfo);
}