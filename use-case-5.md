Use Case 5: Wykonywanie operacji przelewu dla użytkowników
=====================

**Aktor podstawowy:** Klient banku


Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

- Klient banku: oczekuje możliwości szybkiego wykonania przelewu do innego użytkownika oraz niezawodności systemu. Po pomyślnym lub niepomyślnym dokonaniu przelewu oczekuje wydanie karty bankomatowej.

- Odbiorca przelewu: oczekuje otrzymanie przelewu od nadawcy w kwocie identycznej do wysłanej przez nadawcę.

- Obsługa banku: chce otrzymać informacje o każdej próbie dokonania przelewu.

Warunki początkowe:
----------------

Klient banku wsuwa do bankomatu kartę.


Warunki końcowe:
----------------

Dokonanie przelewu jest bezpieczne. Karta została zidentyfikowana i przeprowadzone zostało uwierzytelnianie. Stan konta klienta oraz konta odbiorcy został zaktualizowany. Dane dotyczące dokonanej operacji zostały wysłane do obsługi banku. Karta została zwrócona klientowi. 

Scenariusz główny (ścieżka podstawowa):
---------------------------------------

1. Klient banku przychodzi do bankomatu, w którym chce dokonać przelewu.
2. Klient wsuwa kartę do bankomatu.
3. Następuje identyfikacja karty w systemie bankomatu.
4. Klient wpisuje PIN do karty.
5. Klientowi wyświetlone zostają opcje, z których wybiera wykonanie
    przelewu.
6. Klient podaje wymagane dane do wykonania przelewu oraz podaje kwotę.
7. Bankomat przed weryfikacją danych pyta klienta, czy wprowadzone dane są poprawne.
8. Klient weryfikuje dane i potwierdza chęć wykonania przelewu.
9. System banku weryfikuje dane przelewu.
10. Po wykonaniu weryfikacji system banku dokonuje aktualizacji rachunków klienta banku i odbiorcy.
11. Bankomat wysyła informacje dokonania przelewu wraz ze wszystkimi danymi do obsługi banku.
12. Klientowi wyświetla się potwierdzenie wykonania przelewu oraz możliwość jego wydrukowania.
13. Po wydrukowaniu potwierdzenia bankomat wydaje kartę klientowi.
14. Klient odchodzi z kartą i potwierdzeniem.



Rozszerzenia (ścieżki alternatywne):
------------------------------------

*a. W dowolnym czasie, dotyczy sytuacji, kiedy system zawiesza się:
Klient dzwoni pod numer wskazany na bankomacie.

 1a. Bankomat jest nieczynny. Na bankomacie wyświetlona jest adekwanta informacja. Korzystanie jest niemożliwe.
 3a. Bankomat nie jest w stanie zweryfikować karty. Na bankomacie wyświetlona jest adekwanta informacja. Karta zostaje zwrócona klientowi.
 4a. Klient wpisuje błędny PIN. Jeśli wpisany zostanie trzy razy błędny PIN następuje blokada rachunku i karta zostaje zwrócona przez bankomat. Klient banku musi udać się do siedziby banku, aby odblokować kartę. Informacja o blokadzie rachunku zostaje wysłana do obsługi banku.
 5a. Klient nie wybiera opcji dokonania przelewu. Możliwe jest cofnięcie się do opcji dokonania przelewu.
 7a. Jeśli klient uzna, że wprowadzone dane muszą zostać poprawione, nadusza odpowiedni przycisk na bankomacie i edytuje dane.
 9a. Jeśli system banku wykryje błąd w danych przelewu, cofa klienta do ekranu wpisywania danych
 9b. Jeśli system banku wykryje, że na rachunku klienta nie ma wystarczających środków do wykonania przelewu poinformuje użytkownika o tym fakcie i cofnie go do ekranu wpisywania danych.
 12a. Jeśli w bankomacie brakuje papieru, aby wydrukować potwierdzenie dokonania przelewu, to klientowi pokazuje się stosowne powiadomienie na ekranie.
 14a. Jeśli karta nie zostanie wyjęta przez klienta, to bankomat po 30 sekundach automatycznie wciągnie kartę i powiadomi o tym fakcie klienta. Klient będzie mógł ją odebrać w siedzibie banku.

Wymagania specjalne:
--------------------

-   Niezbędne posiadanie konta w banku.
-   Niezbędna karta banku, umożliwiająca korzystanie z bankomatu
-   Możliwość interfejsu wielojęzycznego
-   Czynny bankomat

Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
--------------------------------------------------------------
3a. Identyfikator karty i dane zawarte w karcie zczytywane zostają poprzez specjalny chip zawarty w karcie.
4a. PIN do karty weryfikowany jest poprzez chip zawarty w karcie.
12a. Potwierdzenie wykonania przelewu zostaje wydrukowane przez bankomat.

Kwestie otwarte:
----------------

- Jakie są możliwe zmiany w kwestii pobierania płatności za przelewy?

- Możliwość ustalenia przelewów zdefiniowanych.
