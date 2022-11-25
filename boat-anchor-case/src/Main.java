public class Main {
  public static void main(String[] args) {
    System.out.println("Program started!");
    INotification mailNotification = new MailNotification();
    mailNotification.SendMessage("Lorem ipsum");
  }
}