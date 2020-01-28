#include <iostream>
using namespace std;

// VOID FUNCTIONS
 
// Show welcome message
void welcomeMessage(){
    cout<<"#############################"<<endl;
    cout<<"##### WITAJ W BANKU WMI #####"<<endl;
    cout<<"#############################"<<endl;
    cout<<"#### BEZPIECZNIE LOKUJEMY ###"<<endl;
    cout<<"###### WASZE PIENIĄDZE ######"<<endl;
    cout<<"## WMI BANK WYDZIAŁOWY S.A ##"<<endl;
    cout<<"#############################"<<endl;
    cout<<endl;

}

void endMessage(){
    cout<<"#############################"<<endl;
    cout<<"#### ZAPRASZAMY PONOWNIE ####"<<endl;
    cout<<"#############################"<<endl;
    cout<<"## WMI BANK WYDZIAŁOWY S.A ##"<<endl;
    cout<<"#############################"<<endl;
}

// Ask for PIN
void pinMessage(){
    cout<<endl;
    cout<<"PODAJ PIN"<<endl;
}

// Show account balance
void balance(double accountBalance){
    cout<<endl;
    cout<<"POZOSTAŁO: "<<accountBalance<<" ZŁ"<<endl;
    cout<<endl;
}

// Show my account number
void showMyAccountNumber(string accountNumber){
    cout<<endl;
    cout<<"TWÓJ NUMER KONTA: "<<accountNumber<<endl;
    cout<<endl;
}

// Show text menu
void menu(){
    cout<<"1. STAN KONTA"<<endl;
    cout<<"2. WYPŁATA GOTÓWKI"<<endl;
    cout<<"3. PRZELEW"<<endl;
    cout<<"4. WPŁATA GOTÓWKI"<<endl;
    cout<<"5. DOŁADOWANIE TELEFONU"<<endl;
    cout<<"6. NUMER KONTA"<<endl;
    cout<<"7. QUIT"<<endl;
}

// Withdrwal cash
double withdrawal(double amount, double accountBalance){
    return accountBalance - amount;
}

// Deposit cash
double deposit(double amount, double accountBalance){
    return accountBalance + amount;
}



// That function checks if pin is correct
// It will return true if pin is valid
// The enteredPin is provided by the user
// The correctPin is downloaded from the system
bool checkPin(int enteredPin, int correctPin){
    if (enteredPin == correctPin) {
        return true;
    }else{
        return false;
    }
}


int main(){
    // Variables
    int i = 0;
    int correctPin = 1111;
    int pinCode = 0;
    int menuValue = 0;
    int phoneNumber = 0;
    int amountTransfers [100];
    double depositAmount = 0;
    double withdrawalAmount = 0;
    double transferAmmount = 0;
    double accountBalance = 100;
    bool pinStatus = false;
    char confirmation = 'N';
    string myAccountNumber = "44 2354 9000 0448 5008 9791 4536";
    string accountNumber = "";
    string transferAccountNumbers [100];
    
    
    // Run
    welcomeMessage();
    pinMessage();
    
    do{
        cin>>pinCode;
        cout<<endl;
        pinStatus = checkPin(pinCode, correctPin);
        
        if(pinStatus == true) {
            menu();
        }else{
            cout<<"ZŁY PIN"<<endl;
            cout<<"PODAJ POPRAWNY PIN"<<endl;
        }
    }while(pinStatus != true);
    
    while(menuValue != 7){
        cin>>menuValue;
        switch (menuValue) {
            case 1:
                balance(accountBalance);
                menu();
                break;
            case 2:
                cout<<endl<<"PODAJ KWOTĘ WYPŁATY:"<<endl;
                cin>>withdrawalAmount;
                accountBalance = withdrawal(withdrawalAmount, accountBalance);
                cout<<endl<<"WYPŁACONO "<<withdrawalAmount<<" ZŁ"<<endl<<endl;
                menu();
                break;
            case 3:
                cout<<endl<<"PODAJ NUMER KONTA:"<<endl;
                cin>>accountNumber;
                cout<<endl<<"PODAJ KWOTĘ PRZELEWU:"<<endl;
                cin>>transferAmmount;
                cout<<endl<<"CZY NAPEWNO CHCESZ PRZELAĆ "<<transferAmmount<<" ZŁ"<<endl;
                cout<<"NA NUMER KONTA: "<<accountNumber<<endl;
                cout<<endl<<"Y/N ?"<<endl;
                cin>>confirmation;
                if (confirmation == 'Y') {
                    accountBalance = withdrawal(transferAmmount, accountBalance);
                    transferAccountNumbers[i] = accountNumber;
                    amountTransfers[i] = transferAmmount;
                    i++;
                    cout<<endl<<"PRZELAŁEŚ "<<transferAmmount<<" ZŁ"<<endl;
                    cout<<"NA NUMER KONTA: "<<accountNumber<<endl<<endl;
                    menu();
                    break;
                }else{
                    menu();
                    break;
                }
            case 4:
                cout<<endl<<"PODAJ KWOTĘ DEPOZYTU:"<<endl;
                cin>>depositAmount;
                accountBalance = deposit(depositAmount, accountBalance);
                cout<<endl<<"ZDEPONOWANO "<<depositAmount<<" ZŁ"<<endl;
                menu();
                break;
            case 5:
                cout<<endl<<"PODAJ 9 CYFROWY NUMER TELEFONU"<<endl;
                cin>>phoneNumber;
                cout<<endl<<"PODAJ KWOTĘ DEPOŁADOWANIA:"<<endl;
                cin>>withdrawalAmount;
                cout<<endl<<"CZY NAPEWNO CHCESZ DOŁADOWAĆ TELEFON: "<<phoneNumber<<endl;
                cout<<"KWOTĄ "<<withdrawalAmount<<" ZŁ"<<endl;
                cout<<endl<<"Y/N ?"<<endl;
                cin>>confirmation;
                if (confirmation == 'Y') {
                    accountBalance = withdrawal(withdrawalAmount, accountBalance);
                    cout<<endl<<"DOŁADOWAŁEŚ TELEFON "<<phoneNumber<<endl;
                    cout<<"KWOTĄ "<<withdrawalAmount<<endl;
                    menu();
                    break;
                }else{
                    menu();
                    break;
                }
            case 6:
                showMyAccountNumber(myAccountNumber);
                menu();
                break;
            case 7 :
                break;
            default:
                menu();
                break;
        }
    }
    endMessage();
    return 0;

}

 


 

