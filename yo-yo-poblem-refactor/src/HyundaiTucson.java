public class HyundaiTucson extends Car {

  @Override
  public void startMove() {
    System.out.println("Start move method called!");
  }
  @Override
  public void brake() {
    System.out.println("Brake method called!");
  }
  @Override
  public void fixCar() {
    System.out.println("Fix car method called!");
  }
}
