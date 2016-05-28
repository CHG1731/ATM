//Serial Peripheral RFID setup
#include <SPI.h>
#include <MFRC522.h>
#define SS_PIN 10
#define RST_PIN 5
MFRC522 mfrc522(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;
//Fields
boolean authenticated = false;
boolean dataretrieve = true;
boolean klantID = true;
boolean RekeningNR = true;
boolean pasID = true;
boolean writefase = false;
byte data[16];
void setup() {
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  for (byte i = 0; i < 6; i++)
  {
    key.keyByte[i] = 0xFF;
  }
}

void loop()
{
  while (!authenticated)
  {
    Serial.println("1234#");
    delay(2000);
    if (Serial.readStringUntil('#') == "AUTH")
    {
      authenticated = true;
    }
  }
  delay(200);
  Serial.println("Authenticated");
  if (Serial.readStringUntil('#') == "WRITEPROMPT")
  {
    while (true)
    {
      while (dataretrieve)
      {
        String content = Serial.readStringUntil('#');
        if (content.endsWith("PS"))
        {
          while (pasID)
          {
            content = content.substring(0, 6);
            content.getBytes(data, 16);
            //writeBlock(62, data, pasID);
            Serial.println("WRITINGPASNR");
            pasID = false;
            writefase = true;
            dataretrieve = false;
          }
        }
        if (content.endsWith("RK"))
        {
          while (RekeningNR)
          {
            Serial.println("WRITINGRKN");
            RekeningNR = false;
          }
        }
        else
        {
          Serial.println("NOTHING");
        }
      }
      while (writefase)
      {
        mfrc522.PCD_Init();
        if (mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial())
        {
          Serial.println("YESSSS");
        }
      }
    }
  }
}













/*
  while (true)
  {
  String content = Serial.readStringUntil('#');
  if (content.endsWith("PS"))
  {
    while (pasID)
    {
      while (true)
      {
        content = content.substring(0, 6);
        content.getBytes(data, 16);
        writeBlock(62, data, pasID);
        break;
      }
      Serial.println("WRITINGPASNR");
      pasID = false;
    }
  }
  if (content.endsWith("RK"))
  {
    while (RekeningNR)
    {
      Serial.println("WRITINGRKN");
      RekeningNR = false;
    }
  }
  }
  }
  }
  }
*/
