Use case 1: Wypłata pieniędzy
 
- Klient podchodzi do bankomatu z kartą.
- Wkłada kartę do bankomatu a następnie wpisuje pin do weryfikacji. System wyświetla opcje które obsługuje.
- Klient wybiera opcje wypłaty pieniędzy a następnie wpisuje kwote którą chce wypłacic, a system weryfikuje kwote pieniędzy ka koncie.
- Po pomyslnej weryfikacji bankomat uaktualnie stan konta klienta i pieniędzy możliwych do wypłacenia z bankomatu.
- Na koniec bankomat zwraca karte klienta i po jej odebraniu wydaje pieniądze.
 
 
Pełny przypadek uzycia
 
 
Use Case 1: Wypłata pieniędzy
 
Aktor podstawowy (Primary actor): klient
 
Główni odbiorcy i oczekiwania względem systemu:
-   Klient: Chce szybko i bez problemów wypłacić pieniądze
-   Bank: Chce bez problemu wypłacić pieniądze klientowi i jednocześnie pobrać pieniądze  z konta klienta
 
Warunki wstępne: Bankomat jest uruchomiony i posiada odpowiednią kwotę piniędzy w środku. Klient posiada konto w dowonlym banku i posiada przy sobie kartę bankomatową odopwiadającą temu kontu
 
Warunki końcowe:
Pieniądze zostają wydane. System bankowy i stan pieniędzy klienta na koncie zostają zaktualizowane.
 
Scenariusz główny (ścieżka podstawowa):
1. Klient podchodzi z kartą do bankomatu //do usuniecia
2. Klient wkłada kartę do bankomatu
3. Bankomat rozpoczyna weryfikację karty
4. Klient wpisuje pin by potwierdzić swoją osobę
5. Po poprawnej weryfikajci klienta bankomt wyświetla opcje w tym wypłatę pieniędzy
6. Klient wybiera opcję wypałaty pieniędzy
7. Klienty wpisuje na terminalu ile pieniędzy chce wypłacić i zatwierdza ją
8. Bnkomat sprawdza stan konta klienta i po pozytywnym wyniku sprawdzenia wypłaca Pieniądze
9. Klient odbiera kartę a nastepnie pieniądze z bankomatu
10. Klient wybira czy chce lub nie wydrukować potwierdzenie i podchodzi
 
Rozszerzenia (ścieżki alteratywne):
*a. W dowolnym momencie kiedy system zawiesza się:
      1. System wyświetla komunikat o uszkodzeniu bankomatu i wyświetla numer do obsługi
      2. W przypadku kiedy karta jest w środku bankomatu podczas zawieszenia to w miarę możliwości próbuje ją wydać
3a. W przypadku negatynej weryikacji bankomat oddaje kartę i wyświetla komunikat o braku możliwości odczytania danych z karty.
4a. W przypadku wpisania złego pinu bankomat prosi o wpisanie pinu jeszcze raz
4b. Po 3 nieudanych próbach wpisania pinu bankomat blokuj kartę i oddaje ją klientowi
4c. Klient rezygnuje z wpisywania pinu i anuluje transakcję
  1. System wysietla komunikat o anulowaniu transakcji i oddaje kartę klientowi
5a. Klient anuluje transakcję
  1. System wysietla komunikat o anulowaniu transakcji i oddaje kartę klientowi
6a. Klient którzy przez przypadek wybrał inną opcję może wrócić do 5 stanu
7a. Klient który przez przypadek wpisał złą kwotę może przed zatwierdzeniem usunąć poprzednią kwotę i wpisać nową
8a. Jeżeli w bankomacie nie ma wystarczającej liczby banknotów bankomat informuje o tym klienta i anuluje transakcję
8b. Kiedy klient nie ma wytsarczającej kwoty na koncie to bankomat
 
 
 
Wymagania spacjalne:
 
 
 
Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
 
 
 
 
Kwestie otwarte: