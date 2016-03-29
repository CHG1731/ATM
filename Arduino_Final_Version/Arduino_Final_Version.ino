//Written by Felix Jochems
#include <Keypad.h>
#include <MFRC522.h>
#include <SPI.h>
#define  RST_PIN 9
#define SS_PIN 10
MFRC522 mfrc522(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;
byte nuidPICC[3];
const byte ROWS = 4; //four rows
const byte COLS = 4; //three columns
char keys[ROWS][COLS] = {
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','$'}
};
byte rowPins[ROWS] = {7, 6, 5, 4}; //connect to the row pinouts of the keypad
byte colPins[COLS] = {14, 15, 16, 17}; //connect to the column pinouts of the keypad

Keypad keypad = Keypad( makeKeymap(keys), rowPins, colPins, ROWS, COLS );


void setup(){
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();        // Init MFRC522 card
  //Serial.println("Print block 0 of a MIFARE PICC ");
}

void dump_byte_array(byte *buffer, byte bufferSize) {
    for (byte i = 0; i < bufferSize; i++) {
        Serial.print(buffer[i] < 0x10 ? " 0" : "");
        Serial.print(buffer[i], HEX);
    }
}

void loop() {
    // Look for new cards
    
    if (mfrc522.PICC_IsNewCardPresent())
    {
      if (mfrc522.PICC_ReadCardSerial())
      {
         dump_byte_array(mfrc522.uid.uidByte, mfrc522.uid.size);
         Serial.println(",NEWUID");
         delay(1000);
      }
    }
    char key = keypad.getKey();
      if (key != NO_KEY){
    Serial.print(key);
    Serial.println("KEY");
  }
}
