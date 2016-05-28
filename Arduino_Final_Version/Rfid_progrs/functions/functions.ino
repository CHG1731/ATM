void writeBlock(int blockNumber, byte arrayAddress[]) 
{
  int largestModulo4Number=blockNumber/4*4;
  int trailerBlock=largestModulo4Number+3;
  mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, trailerBlock, &key, &(mfrc522.uid));
  mfrc522.MIFARE_Write(blockNumber, arrayAddress, 16);
  mfrc522.MIFARE_Write(9, value1Block, 16);
}
