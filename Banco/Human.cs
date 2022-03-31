

class Human {

  public bool isActive { get; private set; }
  public string name { get; private set; }
  public  Bank account { get; private set; }

  public Human(string name, bool isActive, Bank account) {
    this.name = name; 
    this.isActive = isActive;
    this.account = account;
  }
}

