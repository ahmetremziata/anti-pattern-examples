public class Main {
  public static void main(String[] args) {
    System.out.println("Program started!");
    var car = new HyundaiTucson();
    car.openTheDoor();
    car.turnOn();
    car.fillUp();
    car.startMove();
    car.brake();
    car.fixCar();
  }
}