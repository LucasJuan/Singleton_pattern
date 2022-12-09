using Singleton_pattern.Model;
    //as the constructor is not available  here you cannot instantiate, use the static
    //class to acces in the entire application with the same instance
    var item = SingletonClass.getInstance();
   //show the message
    item.showMessage();
