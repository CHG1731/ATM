void setup() {
  Serial.begin(9600);
}

void loop() {
  static bool authenticated = false;
  if(!authenticated)
  {
    Serial.println("1234#");
    delay(2000);
  }
}
