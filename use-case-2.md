Use Case 1: Nazwa Deponowanie pieniędzy
=====================

**Aktor podstawowy:** Klient


Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

- Klient: oczekuje możliwości szybkiej wpłaty pieniędzy na konto za pomocą bankomatu

- Bank: chce poprawnie zrealizować transakcje i zadowolenia klienta

Warunki wstępne:
----------------

Bankomat jest uruchomiony i gotowy do użycia.

Warunki końcowe:
----------------

Stan konta klienta został zaaktualizowany. Ilość pieniędzy w bankomacie została zwiększona. Bankomat wydrukował potwierdzenie.

Scenariusz główny (ścieżka podstawowa):
---------------------------------------

  1. Klient wkłada kartę do bankomatu.
  2. System weryfikuje kartę do bankomatu.
  3. Klient wpisuje poprawny pin do swojej karty. System dokonuje autoryzacji. 
  4. System wyświetla opcje do wyboru.
  5. Klient wybiera opcję wpłaty gotówki.
  6. Klient wkłada gotówkę do bankomatu stosując sie do wskazówek wyświetlonych na ekranie.
  7. Bankomat wyświetla sumę pieniędzy włożonych do bankomatu oraz opcje do wyboru.
  8. Klient zatwierdza wpłatę danej ilości pieniędzy. System aktualizuje stan konta klienta.
  9. Bankomat drukuje potwierdzenie i wydaje kartę klienta.
  10. Klient odchodzi z kartą i potwierdzeniem.

Rozszerzenia (ścieżki alternatywne):
------------------------------------

 *a. W dowolnym momencie kiedy system zawiesza się:
		1. System w miarę możliwości wyświetla numer na infolinię oraz próbuje wydać kartę

 2a. Bankomat nie rozpozanje karty (klient włożył kartę do bankomatu w zły sposób lub włożył coś innego lub system rozpoznawania karty nie zadziałał poprawnie)
        1. Bankomat wyświetla komunikat o nierozpoznaniu karty i zwraca ją klientowi

 3a. Klient wpisuje zły pin do karty.
        1. System rejestruje zdarzenie. Bankomat wyświetla informacje o złym kodzie pin i prosi klienta o ponowne wpisanie poprawnego kodu pin.
        2. Po 3 nieudanej próbie: System rejestruje zdarzenie i blokuje kartę. Bankomat wyświetla informację o złym kodzie pin i zablokowaniu karty. Bankomat zwraca kartę.
		
 4a. Klient anuluje transakcje.
		1. System wyswietla komunikat o anulowaniu transakcji i oddaje kartę klientowi.

 6a. Klient anuluje transakcje.
		1. System wyswietla komunikat o anulowaniu transakcji. 
		2. System powraca do kroku nr 4.
		
 6b. Bankomat nie rozpoznał pieniędzy (klient włożył pieniądze w zły sposób)
		1. Bankomat zwraca pieniądze oraz prosi o ponowne włożenie pieniędzy stosując sie do wskazówek wyświetlając je na ekranie.
		
 7a. Klient anuluje transakcje.
		1. Bankomat zwraca pieniądze.
		2. System wraca do kroku nr 4.
--------------------

  - Niezbędne posiadanie konta w banku.

  - Niezbędna karta banku, umożliwiająca korzystanie z bankomatu

  - Czynny bankomat

Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
---------------------------------------------------------------

 2a. Identyfikacja wykożystuje specjalny chip który znajduje się na karcie
 
 3a. System weryfikuje pin poprzez sprawdzenie zgodności wpisanego pinu do pinu w bazie danych, ktory jest przypisany do danej karty


Kwestie otwarte:
----------------

  - Wpłacanie banknotów w innej walucie niż PLN