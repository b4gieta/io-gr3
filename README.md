# Aplikacja do nauki języków - projekt IO.


## Autorzy

- [@b4gieta](https://www.github.com/b4gieta)
- [@M4ttheuz](https://www.github.com/M4ttheuz)
- [@mosuchowski](https://www.github.com/mosuchowski)


## Wymagania niefunkcjonalne
- przyjazny w obsłudze interfejs, bez konieczności rejestracji;
- aplikacja powinna działać w trybie graficznym;
- aplikacja powinna być zaprojektowana tak, aby umożliwić łatwe dodawanie nowych funkcji i zasobów w przyszłości;
- aplikacja powinna rejestrować błędy lokalnie i oferować użytkownikowi czytelne komunikaty o błędach oraz sugestie, jak je naprawić;

## Wymagania funkcjonalne
- możliwość dodawania interaktywnych fiszek;
- słownik polsko-angielski;
- śledzenie postępów użytkownika poprzez zdobywanie doświadczenia i poziomów w aplikacji;
- użytkownicy powinni otrzymywać powiadomienia o nowych lekcjach, postępach oraz przypomnienia o nauce;
- aplikacja powinna oferować ćwiczenia gramatyczne i słownikowe, z możliwością automatycznego sprawdzania odpowiedzi;
- użytkownik powinien otrzymywać feedback w czasie rzeczywistym na temat swoich odpowiedzi;

## Potencjalne ryzyka
- nie wiemy jak tworzyć aplikacje działające w tle (wysyłanie powiadomień);
- mamy małe doświadczenie w tworzeniu aplikacji z interfejsem graficznym;
- użytkownicy mogą utracić swoje postępy i dane w przypadku awarii systemu lub błędów w przechowywaniu danych lokalnych;
- możemy napotkać trudności w implementacji złożonych funkcji, takich jak algorytmy oceny postępów;
  
## To-do list
1. Zaprojektować i zaimplementować system dodawania fiszek przez użytkowników.
   Opracować interfejs użytkownika do przeglądania i nauki z fiszek.
   Wprowadzić mechanizm interakcji (np. quizy z fiszek).

2. Zbadać i wybrać źródła danych do słownika.
   Opracować funkcjonalność przeszukiwania słownika.
   Dodać możliwość wyświetlania definicji oraz przykładów użycia słów.
   Śledzenie postępów użytkownika:

3. Zaprojektować system zdobywania doświadczenia i poziomów.
   Zaimplementować mechanizm rejestrowania postępów użytkownika.
   Opracować wizualizację postępów w aplikacji.

4. Zaimplementować system powiadomień o nowych lekcjach.
   Dodać przypomnienia o postępach i nauce.
   Opracować ustawienia dotyczące zarządzania powiadomieniami.

5. Stworzyć zestaw ćwiczeń gramatycznych.
   Zaimplementować ćwiczenia słownikowe z automatycznym sprawdzaniem odpowiedzi.
   Opracować system losowania ćwiczeń dla użytkowników.

6. Zaimplementować mechanizm oceny odpowiedzi użytkowników.
   Opracować sposób dostarczania feedbacku (np. komunikaty, sugestie).
   Testować system feedbacku w celu optymalizacji.
