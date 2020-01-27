### Skrócony Use case 4: Sprawdzenie stanu konta

- Klient wkłada kartę do bankomatu
- Klient wprowadza pin
- Klient wybiera opcję sprawdzenia stanu konta
- Klient odbiera potwierdzenie
- Klient odbiera kartę

# Pełny przypadek uzycia


## Use case 4: Sprawdzenie stanu konta

### Aktor podstawowy (Primary actor): 
- Klient


### Główni odbiorcy i oczekiwania względem systemu:
- Klient: Chce szybko i bez problemów sprawdzić stan konta.
- Bank: Chce bez problemu przedstawić klientowi saldo jego konta.

### Warunki wstępne:
- Bankomat jest uruchomiony i posiada działający ekran oraz przyciski.
- Klient posiada konto w dowolnym banku i posiada przy sobie kartę bankomatową przypisaną do tego konta.

### Warunki końcowe:
- Saldo zostaje wyświetlone, karta zwrócona. Klient zostaje wylogowany a stan konta pozostaje niezmieniony.

### Scenariusz główny (ścieżka podstawowa):
1. Klient podchodzi z kartą do bankomatu
2. Klient wkłada kartę do bankomatu
3. Bankomat rozpoczyna weryfikację karty
4. Klient wpisuje pin by potwierdzić swoją tożsamość
5. Po poprawnej weryfikajci klienta bankomat wyświetla menu, w tym sprawdzenie salda konta
6. Klient wybiera opcję saldo konta
7. Bankomat wyświetla aktualne saldo konta
8. Bankomat wyświetla możliwość powrotu do menu głównego
9. Klient wraca do menu głównego
10. Bankomat wyświetla menu główne
11. Klient wybiera opcję zakończ działanie bankomatu
12. Bankomat zwraca kartę
13. Klient odbiera kartę
14. Bankomat kończy działanie

### Rozszerzenia (ścieżki alteratywne):
- *a. W dowolnym momencie kiedy system zawiesza się:
   - 1. System wyświetla komunikat o uszkodzeniu bankomatu i wyświetla numer do obsługi
   - 2. W przypadku kiedy karta jest w środku bankomatu podczas zawieszenia to w miarę możliwości próbuje ją wydać
- 3a. Negatyna weryikacja
    1. Bankomat oddaje kartę i wyświetla komunikat o braku możliwości odczytania danych z karty.
- 4a. W przypadku wpisania złego pinu:
   - 1. System wyświetla komunikat o błędnym pinie i prosi o wprowadzenie go jeszcze raz
   - 2. Po 3 nieudanych próbach wpisania pinu bankomat blokuj kartę i oddaje ją klientowi
- 4a. Klient rezygnuje z wpisywania pinu i anuluje transakcję
   - 1. System wysietla komunikat o anulowaniu transakcji i oddaje kartę klientowi
- 6a. Klient przez przypadek wybrał inną opcję
   - 1. Powrót do stanu 4
- 12a. Bankomat nie może zwrócić karty
   - 1. System wyświetla komunikar o braku możliwości zwrotu karty z powodu uszkodzenia i wyświetla numer alarmowy.

### Wymagania spacjalne:
 - Możliwość interfejsu wielojęzykowego
 - czytelna czcionka na wyświetlaczu z odległości 1 metra
 - wygodne dobrze klikalne klawisze na klawiaturze
 - Opcjonalny ekran dotykowy do wybierania opcji zamiast klawiatury
 - Wejście na karte powinno być takiego typu by nie można było nałożyć specjalnej nakładki do kradzieży danych z karty
 - Kamera do ewentualnej weryfikacji osoby korzystającej z karty
 
### Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
- 3a. Weryfikacja i identyfikacja karty to proces w którym specjalny czytnik kart sprawdza czip który zamontowany jest w karcie
- 4a. Pin jest weryfikowany przez bankomat poprzez czip zamontowany w karcie

### Kwestie otwarte:
- Wyświetlenie kwoty w innej walucie
- Wyświetlenie wykresu z wartościami stanu konta na przestrzeni czasu
