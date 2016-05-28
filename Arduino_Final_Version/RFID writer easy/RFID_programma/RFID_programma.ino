/*
 * Written by Felix Jochems
 * Program to Write RFID cards
 *
 * Yet to implement:
 * - Key [0]
 * - Write [0]
 * - Serial input[0]
 *
 * PIN LAYOUT:
 * SDA = Arduino Pin 10
 * SCK = Arduino Pin 13
 * RST = Arduino Pin 9
 * MISO = Arduino Pin 12
 * MOSI = Arduino Pin 11
 */
#include <SPI.h>
#include <MFRC522.h>
#define SS_PIN 10
#define RST_PIN 5
MFRC522 mfrc522(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;

String PasID;
String RekeningNR;
String KlantID;

byte PasIDblock[16];
byte RekeningNRblock[16];
byte KlantIDblock[16];

void setup()
{
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  for (byte i = 0; i < 6; i++) 
  {
    key.keyByte[i] = 0xFF;
  }
  Serial.println("$$===STARTING WRITE PROGRAM, PLEASE READ INFO BELOW!===$$");
  Serial.println("||BLOCK 62 is PasID                                    ||");
  Serial.println("||BLOCK 61 is RekeningID                               ||");
  Serial.println("||BLOCK 60 is KlantID                                  ||");
  Serial.println("||Standard key (0xFF0xFF0xFF0xFF0xFF0xFF)  will be used||");
  Serial.println("$$=====================================================$$");
  Serial.println();
  boolean go = true;
  boolean pasgiven = true;
  boolean rekeninggiven = true;
  boolean klantgiven = true;
  while (go)
  {
    Serial.println("Voer PasID in");
    while (pasgiven)
    {
      PasID = Serial.readString();
      if (PasID.length() > 3)
      {
        pasgiven = false;
      }
    }
    Serial.println("PasID : " + PasID);
    Serial.println("Voer RekeningNR in");
    while (rekeninggiven)
    {
      RekeningNR = Serial.readString();
      if (RekeningNR.length() > 3)
      {
        rekeninggiven = false;
      }
    }
    Serial.println("RekeningNR : " + RekeningNR);
    Serial.println("Voer KlantID in");
    while (klantgiven)
    {
      KlantID = Serial.readString();
      if (KlantID.length() > 3)
      {
        klantgiven = false;
      }
    }
    Serial.println("KlantID : " + KlantID);
    KlantID.getBytes(KlantIDblock, 16);
    RekeningNR.getBytes(RekeningNRblock, 16);
    PasID.getBytes(PasIDblock, 16);
    go = false;
  }
}
void loop()
{
  for(int i = 0; i < 50; i++)
  {
    Serial.println();
  }
  Serial.println("DATA TO BE WRITTEN");
  Serial.println("RekeningNR : " + RekeningNR);
  Serial.println("KlantID : " + KlantID);
  Serial.println("PasID : " + PasID);
  Serial.println("Present an RFID card to start writing");
  while (true)
  {
    mfrc522.PCD_Init();
    if (!mfrc522.PICC_IsNewCardPresent())
    {
      delay(2000);
      break;
    }
    if (!mfrc522.PICC_ReadCardSerial())
    {
      delay(2000);
      break;
    }
    writeBlock(62,PasIDblock);
    Serial.println("DONE WRITING");
    delay(200000);
    delay(2000);
  }
}

