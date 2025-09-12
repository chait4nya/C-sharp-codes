#include<iostream>
#include<string>
using namespace std;

int main(){
    string playerName;
    int playerHealth=100;
    int enemyHealth=100;
    char choice;
    
    cout << "Welcome to mini RPG." << endl;
    cout << "Enter your hero name: ";
    getline (cin, playerName);
    
    cout << "Welcome " << playerName << endl << "! Shit You encounter a giant Python !" << endl;
    
    while(playerHealth > 0 && enemyHealth > 0) {
        cout << "Your Hp: " << playerHealth << "| Giant Python's Hp: " << enemyHealth << endl;
        cout << "Choose an action:" << endl;
        cout << "1. Attack" << endl;
        cout << "2. Heal" << endl;
        cout << "Enter your choice:" << endl;
        cin >> choice;
        
        if (choice == '1'){
            cout << "You striked the enemy !" << endl;
            enemyHealth -= 20;
        }
        else if (choice == '2'){
            cout << "You healed yourself :)" << endl;
            playerHealth += 20;
        }
        else {
            cout << "You gave an Invalid choice. You loose your turn :(" << endl;
        }
        if (enemyHealth > 0){
            cout << "Python is Attacking!" << endl;
            playerHealth -= 30;
        }
    }
        if (playerHealth <= 0){
            cout << playerName << " is dead! Game over" << endl;
        } 
        else {
            cout << "You deafeated the Giant Python. VICTORY!" << endl;  
        }
    return 0;
}