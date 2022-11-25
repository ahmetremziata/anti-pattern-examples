public class PushNotification implements INotification {
  @Override
  public void SendMessage(String message) {
    System.out.printf("Push send. Message:%s%n", message);
  }
}
