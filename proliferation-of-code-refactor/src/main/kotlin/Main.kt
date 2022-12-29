fun main(args: Array<String>) {
    println("Program started!")

    val repositoryObject = RepositoryObject()
    val notificationObject = NotificationObject()

    repositoryObject.addToDb()
    notificationObject.notifyToCustomer()
}