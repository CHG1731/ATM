int mainPower = 2;
int dispenser1 = 3;
int dispenser1Rev = 9;
int dispenser3 = 5;
int dispenser3Rev = 10;
int dispenser2 = 6;
int dispenser2Rev = 11;
int tens;
int twenties;
int fifties;

void setup() {
  // put your setup code here, to run once:
  pinMode(dispenser1, OUTPUT);
  pinMode(dispenser2, OUTPUT);
  pinMode(dispenser3, OUTPUT);
  pinMode(dispenser1Rev, OUTPUT);
  pinMode(dispenser2Rev, OUTPUT);
  pinMode(dispenser3Rev, OUTPUT);
  digitalWrite(dispenser1Rev, LOW);
  digitalWrite(dispenser2Rev, LOW);
  digitalWrite(dispenser3Rev, LOW);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available())
  {
    String command = Serial.readStringUntil('*');
    Serial.println(command);
    if (command.length() > 8)
    {
      tens = (command.substring(0, 2)).toInt();
      twenties = (command.substring(3, 5)).toInt();
      fifties = (command.substring(6, 8)).toInt();
      Serial.println("dispensing"+tens+twenties+fifties);
      Serial.println(tens);
      Serial.println(twenties);
      Serial.println(fifties);
      dispense();
      Serial.println("Done");
    }
  }
}

void dispense()
{
  bool complete = false;
  while (complete == false)
  {
    if (tens == 0 && twenties == 0 && fifties == 0) {
      complete = true;
    }
    if (tens > 0) {
      digitalWrite(dispenser1, HIGH);
      tens--;
    }
    else
    {
      digitalWrite(dispenser1, LOW);
    }
    if (twenties > 0) {
      digitalWrite(dispenser2, HIGH);
      twenties--;
    }
    else
    {
      digitalWrite(dispenser2, LOW);
    }
    if (fifties > 0) {
      digitalWrite(dispenser3, HIGH);
      fifties--;
    }
    else
    {
      digitalWrite(dispenser3, LOW);
    }
    delay(1600);
    digitalWrite(dispenser1, LOW);
    digitalWrite(dispenser1Rev, HIGH);
    digitalWrite(dispenser2, LOW);
    digitalWrite(dispenser2Rev, HIGH);
    digitalWrite(dispenser3, LOW);
    digitalWrite(dispenser3Rev, HIGH);
    delay(800);
    digitalWrite(dispenser1Rev, LOW);
    digitalWrite(dispenser2Rev, LOW);
    digitalWrite(dispenser3Rev, LOW);
  }
}

