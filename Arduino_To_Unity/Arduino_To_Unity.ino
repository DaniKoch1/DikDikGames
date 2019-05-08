const int BUTTON1 = 4;
const int BUTTON2 = 5;
const int BUTTON3 = 6;
const int BUTTON4 = 7;
int buttonState1 = 0;
int buttonState2 = 0;
int buttonState3 = 0;
int buttonState4 = 0;
int lastButtonState  = 0;

void setup() {
  Serial.begin(9600);

  pinMode(BUTTON1, INPUT);
  pinMode(BUTTON2, INPUT);
  pinMode(BUTTON3, INPUT);
  pinMode(BUTTON4, INPUT);
}

void loop() {
  buttonState1 = digitalRead(BUTTON1);
  if (digitalRead(BUTTON1) == HIGH) {
    Serial.write(1);
    Serial.flush();
    delay(20);
  }

  if (digitalRead(BUTTON2) == HIGH) {
    Serial.write(2);
    Serial.flush();
    delay(20);
  }

  if (digitalRead(BUTTON3) == HIGH) {
    Serial.write(3);
    Serial.flush();
    delay(20);
  }

  if (digitalRead(BUTTON4) == HIGH) {
    Serial.write(4);
    Serial.flush();
    delay(20);
  }

}
