public abstract class Car implements ITransport {
  @Override
  public boolean fillUp() {
    System.out.println("Fill up method called!");
    return true;
  }
  @Override
  public void turnOn() {
    System.out.println("Turn on method called!");
  }

  public boolean openTheDoor() {
    System.out.println("Open the door method called!");
    return true;
  }
  public abstract void fixCar();
}
