Adress home = new Adress();
home.Index = 08801;
home.Country = "Україна";
home.City = "Богуслав";
home.Street = "Вишнева";
home.House = 23;
home.Apartment = 1;

Console.WriteLine($"Моя адреса: вул. {home.Street}, буд. {home.House}, кв. {home.Apartment}, мiсто {home.City}, {home.Country}, {home.Index}");