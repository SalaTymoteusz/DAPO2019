# Skrócony Use case 1: Wypłata pieniędzy
 
- Klient podchodzi do bankomatu z kartą.
- Wkłada kartę do bankomatu a następnie wpisuje pin do weryfikacji. System wyświetla opcje które obsługuje.
- Klient wybiera opcje wypłaty pieniędzy a następnie wpisuje kwote którą chce wypłacic, a system weryfikuje kwote pieniędzy ka koncie.
- Po pomyslnej weryfikacji bankomat uaktualnie stan konta klienta i pieniędzy możliwych do wypłacenia z bankomatu.
- Na koniec bankomat zwraca karte klienta i po jej odebraniu wydaje pieniądze.
 
 
# Pełny przypadek uzycia
 
 
# Use Case 1: Wypłata pieniędzy
 
# Aktor podstawowy (Primary actor): 
- Klient
 
# Główni odbiorcy i oczekiwania względem systemu:
- Klient: Chce szybko i bez problemów wypłacić pieniądze.
- Bank: Chce bez problemu wypłacić pieniądze klientowi i jednocześnie pobrać pieniądze  z konta klienta.
 
# Warunki wstępne:
- Bankomat jest uruchomiony i posiada odpowiednią kwotę piniędzy w środku. Klient posiada konto w dowonlym banku i posiada przy sobie kartę bankomatową przypisaną do tego konta.
 
# Warunki końcowe:
- Pieniądze zostają wydane. System bankowy i stan pieniędzy klienta na koncie zostają zaktualizowane.
 
# Scenariusz główny (ścieżka podstawowa):
1. Klient podchodzi z kartą do bankomatu //do usuniecia
2. Klient wkłada kartę do bankomatu
3. Bankomat rozpoczyna weryfikację karty
4. Klient wpisuje pin by potwierdzić swoją osobę
5. Po poprawnej weryfikajci klienta bankomt wyświetla opcje w tym wypłatę pieniędzy
6. Klient wybiera opcję wypałaty pieniędzy
7. Klienty wpisuje na terminalu ile pieniędzy chce wypłacić i zatwierdza ją
8. Bnkomat sprawdza stan konta klienta i po pozytywnym wyniku sprawdzenia wypłaca Pieniądze
9. Klient odbiera kartę a nastepnie pieniądze z bankomatu
10. Klient wybera czy chce lub nie wydrukować potwierdzenie i odchodzi
 
# Rozszerzenia (ścieżki alteratywne):
*a. W dowolnym momencie kiedy system zawiesza się:
    1. System wyświetla komunikat o uszkodzeniu bankomatu i wyświetla numer do obsługi
    2. W przypadku kiedy karta jest w środku bankomatu podczas zawieszenia to w miarę możliwości próbuje ją wydać
3a. Negatyna weryikacja
    1. Bankomat oddaje kartę i wyświetla komunikat o braku możliwości odczytania danych z karty.
4a. W przypadku wpisania złego pinu:
    1. System wyświetla komunikat o błędnym pinie i prosi o wprowadzenie go jeszcze raz
    2. Po 3 nieudanych próbach wpisania pinu bankomat blokuj kartę i oddaje ją klientowi
4c. Klient rezygnuje z wpisywania pinu i anuluje transakcję
    1. System wysietla komunikat o anulowaniu transakcji i oddaje kartę klientowi
5a. Klient anuluje transakcję
    1. System wysietla komunikat o anulowaniu transakcji i oddaje kartę klientowi
6a. Klient przez przypadek wybrał inną opcję
    1. Powrót do stanu 5 
7a. Klient wpisał złą kwotę
    1. Klient może przed zatwierdzeniem usunąć poprzednią kwotę i wpisać nową
8a. W bankomacie nie ma wystarczającej liczby banknotów
    1. Bankomat informuje o tym klienta i anuluje transakcję
8b. Kiedy klient nie ma wytsarczającej kwoty na koncie
    1. Bankomat informuje o tym klienta a następnie:
        1a. Klient może anulować transakcje i bankomat oddaje kartę
        1b. Klient może wrócić do kroku 7
9a. Bankomat wydaje złą sumę pieniędzy:
    1. system rejestruje brak banknotów i wysyła powiadomienie do banku który musi powiadomić klienta o zainstniałej sytuacji
10a. W bankomacie brakuje papieru do drukowania potwierdzeń
    1. Bankomat wyświetla komunikat o braku możliwości wydrukowania potwierdzenia
 
 
 
# Wymagania spacjalne:
 - Możliwość interfejsu wielojęzykowego
 - czytelna czcionka na wyświetlaczu z odległości 1 metra
 - wygodne dobrze klikalne klawisze na klawiaturze
 - Opcjonalny ekran dotykowy do wybierania opcji zamiast klawiatury
 - Wejście na karte powinno być takiego typu by nie można było nałożyć specjalnej nakładki do kradzieży danych z karty
 
 
# Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
3a. Weryfikacja odbywa się przez czytnik kart
 
 
# Kwestie otwarte:
- 