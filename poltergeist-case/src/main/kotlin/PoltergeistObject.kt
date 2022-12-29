class PoltergeistObject(val notificationObject: NotificationObject, val repositoryObject: RepositoryObject) {
    fun doSomething() {
        this.repositoryObject.addToDb()
        this.notificationObject.notifyToCustomer()
    }
}