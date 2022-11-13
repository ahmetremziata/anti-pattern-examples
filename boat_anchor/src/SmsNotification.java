public class SmsNotification implements INotification{
  @Override
  public void SendMessage(String message) {
    System.out.println("Do some things to send sms. Message: " + message);
  }
}
