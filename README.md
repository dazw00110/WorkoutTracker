# WorkoutTracker

## Opis aplikacji

WorkoutTracker to aplikacja Windows Forms umożliwiająca zarządzanie treningami, ćwiczeniami oraz kategoriami. Użytkownik może rejestrować konto, logować się, tworzyć własne treningi, dodawać ćwiczenia i zarządzać kategoriami (admin).

## Struktura bazy danych

- **Users**: użytkownicy aplikacji
- **Trainings**: treningi przypisane do użytkownika
- **Exercises**: ćwiczenia w treningu
- **MainCategories**: główne kategorie ćwiczeń (np. Siłowe)
- **SubCategories**: szczegółowe kategorie ćwiczeń (np. Nogi, Plecy)

## Konfiguracja

1. Skonfiguruj połączenie do PostgreSQL w pliku `appsettings.json`.
2. Wykonaj migracje EF Core:  
   `dotnet ef database update`
3. Uruchom aplikację.

## Instrukcja obsługi

1. Zarejestruj nowe konto.
2. Zaloguj się.
3. Twórz nowe treningi, dodawaj ćwiczenia, zarządzaj kategoriami.
4. Admin może zarządzać kategoriami i użytkownikami.

