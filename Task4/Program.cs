var country = new Country("Tajikistan", "Dushanbe", 10000000, "tajik");

System.Console.WriteLine($"Capital: {country.GetCapital()}\nPopulation: {country.GetPopulation()}\nOfficial Language: {country.GetOfficialLanguage()}");
System.Console.WriteLine();
country.SetCapital("Moscow");
country.SetPopulation(140000000);
country.SetOfficialLanguage("Russian");


System.Console.WriteLine($"Capital: {country.GetCapital()}\nPopulation: {country.GetPopulation()}\nOfficial Language: {country.GetOfficialLanguage()}");
