int mainPower = 2;
int dispenser1 = 3;
int dispenser2 = 5;
int dispenser3 = 6;
int tens;
int twenties;
int fifties;

void setup() {
  // put your setup code here, to run once:
  pinMode(dispenser1, OUTPUT);
  pinMode(dispenser2, OUTPUT);
  pinMode(dispenser3, OUTPUT);
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
    delay(1500);
  }
}

