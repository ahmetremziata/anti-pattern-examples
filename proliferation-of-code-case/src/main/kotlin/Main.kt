fun main(args: Array<String>) {
    println("Program started!")

    //This object has no important purpose. Its purpose is only being a middleman
    val proliferationObject = ProliferationObject(
        notificationObject = NotificationObject(),
        repositoryObject = RepositoryObject(),
    )
    proliferationObject.doSomething()
}