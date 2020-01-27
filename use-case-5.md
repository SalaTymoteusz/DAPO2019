Use Case 5: Wykonywanie operacji przelewu dla użytkowników
=====================

**Aktor podstawowy:** Klient banku


Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

- Klient banku: oczekuje możliwości szybkiego wykonania przelewu do innego użytkownika oraz niezawodności systemu.

- Odbiorca przelewu: oczekuje otrzymanie przelewu od nadawcy w kwocie identycznej do wysłanej przez nadawcę.

- Obsługa banku: chce otrzymać informacje o każdej próbie dokonania przelewu.

Warunki początkowe:
----------------

Klient i karta przeszły pomyślnie proces autoryzacji.


Warunki końcowe:
----------------

Dokonanie przelewu jest bezpieczne. Karta została zidentyfikowana i przeprowadzone zostało uwierzytelnianie. Stan konta klienta oraz konta odbiorcy został zaktualizowany. Informacja o transakcji została wysłana poprzez odpowiedni interfejs do obsługi banku.

Scenariusz główny (ścieżka podstawowa):
---------------------------------------

1. Klientowi wybiera opcje "Wyślij przelew".
2. Klient podaje wymagane dane do wykonania przelewu oraz podaje kwotę w PLN.
3. Bankomat przed weryfikacją danych pyta klienta, czy wprowadzone dane są poprawne.
4. Klient zatwierdza przelew.
5. System banku weryfikuje dane przelewu.
6. System banku sprawdza, czy saldo rachunku klienta pozwala na wysłanie przelewu.
7. Po wykonaniu weryfikacji system banku dokonuje aktualizacji rachunków klienta banku i odbiorcy.
8. Klientowi wyświetla się potwierdzenie wykonania przelewu oraz możliwość wydrukowania jego potwierdzenia.
9. Bankomat oddaje klientowi kartę i potwierdzenie.
10. Klient odchodzi z kartą i potwierdzeniem.



Rozszerzenia (ścieżki alternatywne):
------------------------------------

*a. W dowolnym czasie, dotyczy sytuacji, kiedy system zawiesza się:
Klient dzwoni pod numer wskazany na bankomacie.
*b. Bankomat jest nieczynny. Na bankomacie wyświetlona jest adekwanta informacja. Korzystanie jest niemożliwe.
 
 1a. Klient nie wybiera opcji dokonania przelewu. Możliwe jest cofnięcie się do opcji dokonania przelewu.
 3a. Jeśli klient uzna, że wprowadzone dane muszą zostać poprawione, nadusza odpowiedni przycisk na bankomacie i edytuje dane.
 5a. Jeśli system banku wykryje błąd w danych przelewu, cofa klienta do ekranu wpisywania danych
 6a. Jeśli system banku wykryje, że na rachunku klienta nie ma wystarczających środków do wykonania przelewu poinformuje użytkownika o tym fakcie i cofnie go do ekranu wpisywania danych.
 8a. Jeśli w bankomacie brakuje papieru, aby wydrukować potwierdzenie dokonania przelewu, to klientowi pokazuje się stosowne powiadomienie na ekranie.
 9a. Jeśli karta nie zostanie wyjęta przez klienta, to bankomat po 30 sekundach automatycznie wciągnie kartę i powiadomi o tym fakcie klienta. Klient będzie mógł ją odebrać w siedzibie banku.

Wymagania specjalne:
--------------------

-   Niezbędne posiadanie konta w banku.
-   Niezbędna karta banku, umożliwiająca korzystanie z bankomatu
-   Możliwość interfejsu wielojęzycznego
-   Czynny bankomat
-   

Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
--------------------------------------------------------------
5a. Kwota nie może być większa niż 1000 PLN
12a. Potwierdzenie wykonania przelewu zostaje wydrukowane przez bankomat.

Kwestie otwarte:
----------------

- Jakie są możliwe zmiany w kwestii pobierania płatności za przelewy?

- Możliwość ustalenia przelewów zdefiniowanych.

- Możliwość użycia płatności bezgotówkowych (zbliżenie karty, zamiast wsuwania jej)
