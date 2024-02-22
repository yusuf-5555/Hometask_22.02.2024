public class Country
{
    string _name;
    string _capital;
    int _population;
    string _officialLanguage;

    public void SetCountryName(string country)
    {
        _name = country;
    }
        public string GetCountryName()
    {
        return _name;
    }
    public void SetCapital(string capital)
    {
        _capital = capital;
    }
    public string GetCapital ()
    {
        return _capital;
    }
    public void SetPopulation(int population)
    {
        _population = population;
    }
    public int GetPopulation()
    {
        return _population;
    }
    public void SetOfficialLanguage(string language)
    {
        _officialLanguage=language;
    }
    public string GetOfficialLanguage()
    {
        return _officialLanguage;
    }
    public Country(string name, string capital, int population, string language)
    {
        _name = name;
        _capital = capital;
        _population = population;
        _officialLanguage = language;
    }
}