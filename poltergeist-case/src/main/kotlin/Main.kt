fun main(args: Array<String>) {
    println("Program started!")

    val repositoryObject = RepositoryObject()
    val notificationObject = NotificationObject()
    val poltergeistObject = PoltergeistObject(notificationObject, repositoryObject)

    poltergeistObject.doSomething()
}