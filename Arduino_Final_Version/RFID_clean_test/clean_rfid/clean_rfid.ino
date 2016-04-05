#include <MFRC522.h>
#include <SPI.h>
#define RST_PIN 9
#define SS_PIN 10
MFRC522 mfrc522(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;
void setup() 
{
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  
  for (byte i = 0; i < 6; i++) 
  {
    key.keyByte[i] = 0xFF;//keyByte is defined in the "MIFARE_Key" 'struct' definition in the .h file of the library
  }
}


void loop() 
{
   if (mfrc522.PICC_IsNewCardPresent())
    {
      if (mfrc522.PICC_ReadCardSerial())
      {
        Serial.println("START READING BLOCKS");
        byte PasID[18];
        byte RekeningID[18];
        byte KlantID[18];
        readBlock(62,PasID);
        readBlock(61,RekeningID);
        readBlock(60,KlantID);
        for(int i=0;i<6;i++)
        {
          Serial.write(PasID[i]);
        }
        for(int i=0;i<6;i++)
        {
          Serial.write(RekeningID[i]);
        }
        for(int i=0;i<4;i++)
        {
          Serial.write(KlantID[i]);
        }
      }
    }
}
