public class SmsNotification implements INotification {
  @Override
  public void SendMessage(String message) {
    System.out.printf("Sms send. Message:%s%n", message);
  }
}
