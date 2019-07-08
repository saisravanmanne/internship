#define Clockpin 2
#define Updownpin 12
int count=0;
unsigned long encoder=0;
int updown=0;

void setup() {
  // put your setup code here, to run once:
pinMode(Clockpin,INPUT);
pinMode(Updownpin,INPUT);
pinMode(6,OUTPUT);
pinMode(5,OUTPUT);
Serial.begin(115200);
}

void loop() {
analogWrite(6,133);
analogWrite(5,129);
while (Serial.available()>0) {
unsigned long val = Serial.parseInt();
Serial.println(val);
if ((val/10000==1)) {
  val=val-10000;
  val=val*54;
   encoder=0;
   int preval=0;
  analogWrite(6,228);
  analogWrite(5,30);
  //updown=digitalRead(Updownpin);
  while (encoder <= val) {
  
    count=digitalRead(Clockpin);
    if ((count==1)&&(preval==0)) {
      encoder=encoder+1;
      preval=1;
    }
    if (count==0) {
      preval=0;
    }
  
  }
  updown=digitalRead(Updownpin);
  analogWrite(6,133);
   analogWrite(5,129);
  Serial.println(encoder);
  Serial.println(updown);
  }

if ((val/10000==2)) {
  val=val-20000;
  val=val*54;
   encoder=0;
   int preval=0;
  analogWrite(6,28);
  analogWrite(5,234);
  //updown=digitalRead(Updownpin);
  while (encoder <= val) {
  
    count=digitalRead(Clockpin);
    if ((count==1)&&(preval==0)) {
      encoder=encoder+1;
      preval=1;
    }
    if (count==0) {
      preval=0;
    }
  
  }
  updown=digitalRead(Updownpin);
  analogWrite(6,133);
   analogWrite(5,129);
  Serial.println(encoder);
  Serial.println(updown);
  }
  
if ((val/10000==3)) {
  val=val-30000;
  val=val*54;
   encoder=0;
   int preval=0;
  analogWrite(6,28);
  analogWrite(5,30);
  //updown=digitalRead(Updownpin);
  while (encoder <= val) {
  
    count=digitalRead(Clockpin);
    if ((count==1)&&(preval==0)) {
      encoder=encoder+1;
      preval=1;
    }
    if (count==0) {
      preval=0;
    }
  
  }
  updown=digitalRead(Updownpin);
  analogWrite(6,133);
   analogWrite(5,129);
  Serial.println(encoder);
  Serial.println(updown);
  }
  
}
  // put your main code here, to run repeatedly:

}
