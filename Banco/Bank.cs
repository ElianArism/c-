

class Bank {
  
  public double balance { get; private set; }

  public Bank(double balance) {
    this.balance = balance;
  }

  public bool retrieveMoney(double money, bool isActive) {
    if(!isActive) {
        if(this.balance > 0 && this.balance > money) {
          this.balance -= money;
          return true;
        }
    } else {
        if(this.balance > -1000 && this.balance >= (money - 1000)) {
          this.balance -= money;
          return true;
        }
      }
    return false;
  }

  public void addMoney(double money) {
    this.balance += money; 
  }
}