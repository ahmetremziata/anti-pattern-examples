public class MailNotification implements INotification {
  @Override
  public void SendMessage(String message) {
    System.out.printf("Mail send. Message:%s%n", message);
  }
}
