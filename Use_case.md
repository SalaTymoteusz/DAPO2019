Opis skrócony przypadków użycia
===============================

Aktorzy procesu i ich cele
--------------------------

Aktor       Cel
----------- -----------------------------
Klient     Wypłata pieniędzy
Klient     Deponowanie pieniędzy
Klient     Zakup kodu do telefonii prepaidowej
Klient     Sprawdzenie stanu konta
Klient     Wykonywanie operacji przelewu dla użytkowników


Słownik
-------

Hasło       Opis
----------- -----------------------------
hasło    Opis hasła ...

Przypadki użycia
----------------

### Use case 1: Wypłata pieniędzy

Klient podchodzi do bankomatu z kartą. Wkłada kartę do bankomatu a następnie wpisuje pin do weryfikacji. System wyświetla opcje które obsługuje. Klient wybiera opcje wypłaty pieniędzy a następnie wpisuje kwote którą chce wypłacic, a system weryfikuje kwote pieniędzy ka koncie. Po pomyslnej weryfikacji bankomat uaktualnie stan konta klienta i pieniędzy możliwych do wypłacenia z bankomatu. Na koniec bankomat zwraca karte klienta i po jej odebraniu wydaje pieniądze.

### Use case 2: Deponowanie pieniędzy

Klient podchodzi do bankomatu z kartą i pieniędzmi. Wkłada kartę do bankomatu a nasepnie przechodzi weryfikację przez wpisanie pinu. Klient następnie wybiera opcję z pośród wyświetlonych przeznaczoną do wpłacania pieniędzy. Klient wpisuje kwotę którą chce wpłacić a nastepnie wkłada taką samą kwotę jak tą którą wpisał do bankomatu. Bankomat wyświetla stan konta i drukuje potwierdzenie wpłąty pieniędzy.

### Use case 3: Zakup kodu do telefonii prepaidowej

Klient podchodzi do bankomatu z kartą. Wkłada kartę do bankomatu a następnie wpisuje pin do weryfikacji. System wyświetla opcje które obsługuje. Klient wybiera opcję zakupu kodu do telefonii prepaidowej. Następnie klient wpisuje kwote doladowania jaka chce otrzymac. Po pomyslnej weryfikacji stanu konta bankomat uaktualnia ilosc pieniedzy na koncie, zwraca kartę klienta i po jej odbiorze drukuje kod do telefonii prepaidowej.

### Use case 4: Sprawdzenie stanu konta

Klient podchodzi do bankomatu z kartą. Wkłada kartę do bankomatu a następnie wpisuje pin do weryfikacji. System wyświetla opcje które obsługuje. Klient wybiera opcję sprawdzenia stanu konta. Bankomat wyświetla stan konta, a następnie zwraca kartę klienta.

### Use case 5: Wykonywanie operacji przelewu dla użytkowników

Klient podchodzi do bankomatu z kartą. Wkłada kartę do bankomatu a następnie wpisuje pin do weryfikacji. System wyświetla opcje które obsługuje. Klient wybiera opcję przelewu dla użytkownika i wpisuje numer konta na które mają zostać przelane pieniądze. Klient wpisuje kwotę którą chce przelać, a system weryfikuje stan konta.  Po pomyslnej weryfikacji bankomat uaktualnia stany kont obu użytkowników. Nakoniec bankomat zwraca karte klienta.