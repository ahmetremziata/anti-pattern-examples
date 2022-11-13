public class Program {
  public static void main(String[] args) {
    // Do something and then send mail.
    INotification mailNotification = new MailNotification();
    mailNotification.SendMessage("Mail message");
  }
}
