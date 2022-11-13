public class PushNotification implements INotification{
  @Override
  public void SendMessage(String message) {
    System.out.println("Do some things to send push. Message: " + message);
  }
}
