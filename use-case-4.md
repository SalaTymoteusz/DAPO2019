Use case 4: Sprawdzenie stanu konta
=====================

**Aktor podstawowy:** Posiadacz konta w banku


Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

- Posiadacz konta w banku oczekuje:
  - płynność działania
  - bezawaryjność
  - nieomylność
  - prywatność

Warunki wstępne:
----------------
  - Wsadzenie karty do bankomatu
  - Weryfikacja karty
  - Weryfikacja użytkownika przy użyciu kodu 6 cyfrowego kodu pin
  - Po wpisaniu błędnego kodu użytkownik otrzymuje możliwość ponownego wpisania kodu
  - Wybór funkcji sprawdzenie salda konta

Warunki końcowe:
  - Przedstawienie informacji o aktualnym saldzie konta
  - Przejście do menu bankomatu
  - Wylogowanie użytkownika
  - Odbiór karty

Scenariusz główny (ścieżka podstawowa):
---------------------------------------

  1. Użytkownik podchodzi do bankomatu, po czym wkłada do niego kartę
  2. Bankomat weryfikuje kartę
  3. Bankomat oczekuje na wprowadzenie kodu pin
  4. Bankomat oczekuje na potwierdzenie kodu pin
  5. Bankomat przeprowadza weryfikację użytkownika przez porównanie kodu pinu
  6. Wybór z menu funkcjonalności przez użytkownika
  7. Wyświetlenie aktualnego i poprawnego salda konta
  8. Zaproponowanie użytkownikowi przejście do menu głównego
  9. Ukazanie w widocznym miejscu użytkownikowi funkcji wylogowania
  10. Upomnienie użytkownika o konieczności odbioru karty
  11. Wyświetlenie komunikatu o poprawnym wylogowaniu

Rozszerzenia (ścieżki alternatywne):
------------------------------------

 *2. Weryfikacja karty

 2a. Karta z banku niewspieranego przez bankomat

 2b. Uszkodzona lub niespełniająca wymagań bezpieczeństwa karta

*4. Wielokrotnie błędnie wpisane hasło

4a. Błędny kod pin

4b. Pin niezgodny z standardami (zbyt mała liczba znaków)

Wymagania specjalne:
--------------------

  - Niezbędny wyświetlacz zapewniający czytelny odczyt komunikatów

- Niezbędna klawiatura do wprowadzeniu kodu pin oraz podstawowej komunikacji z bankomatem.

  - Niezbędny czytnik kart bankomatowych

Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
---------------------------------------------------------------

 2a. Identyfikator karty zgodny z standardami

 4a. Maksymalna liczba błędnie wprowadzonych kodów pin ustalona na wartość 5, po tym czasie bankomat wysuwa kartę oraz informuje użytkownika o zablokowanym dostępie do systemu bankowego na czas 30 min

 6a. Użytkownik przez 90 sekund nie wybrał żadnej funkcji z menu bankomatu. Po tym czasie bankomat wyloguje użytkownika, wysuwa kartę oraz wyświetla stosowny komunikat

Kwestie otwarte:
----------------

  - Jak zweryfikować czy użytkownik zabrał wysuniętą kartę bankomatową

  - Co się wydarzy jeżeli użytkownik po wylogowaniu nie odbierze karty bankomatowej
