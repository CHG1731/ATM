void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  String command = Serial.readStringUntil('*');
  if(command.length() > 2)
  {
    String tientjes = command.substring(0,2);
      String twintig = command.substring(2,4);
      String vijftig = command.substring(4,6);
    while(true)
    {
      Serial.println("TIENTJES: "+tientjes);
      Serial.println("TWINTIG: "+twintig);
      Serial.println("VIJFTIG: "+vijftig);
      delay(5000);
    }
  }
}
