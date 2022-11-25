public class Main {
  public static void main(String[] args) {
    System.out.println("Program started!");
    MailNotification mailNotification = new MailNotification();
    mailNotification.SendMessage("Lorem ipsum");
  }
}