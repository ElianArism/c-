/*
  Programa cajero
  2 tipos de clientes
    - Pasivo
      - No puede tener saldo negativo
    - Activo
      - Puede sacar hasta mil pesos en negativo

    acciones comunes
      - consultar saldo 
      - ingresar monto
      - retirar monto

*/


class Program {
  public static void Main(string[] args) {

    // Console.WriteLine("Ingrese su nombre: "); 
    // string name = Console.ReadLine();

    // Console.WriteLine("Es jubilado?\n1. si\n2. no\n Seleccione: "); 
    // int opt = int.Parse(Console.ReadLine());
  	// bool isActive = true;
    
    // if(opt == 1) {
    //   isActive = false;
    // }
    // Console.WriteLine("Ingrese su balance  actual (no mienta): "); 
    // double balance = double.Parse(Console.ReadLine());
  
    Human human = new Human("Seba", true, new Bank(22000));
   
    double money = 0; 
    bool wasSuccessfull; 
    Console.WriteLine("Bienvenido al cajero, que desea hacer:\n1 Consultar Saldo\n2 Retirar dinero\n3. Ingresar dinero\nSeleccione: ");
 
    int option = int.Parse(Console.ReadLine());
  

    switch (option)
    {

      case 1:
        Console.WriteLine(" Su balance es: {0}", human.account.balance); 
        break;  
      case 2: 
          Console.WriteLine("Ingrese la cantidad a retirar: "); 
          money = double.Parse(Console.ReadLine());
          wasSuccessfull = human.account.retrieveMoney(money, human.isActive);       
          
          if(wasSuccessfull) {
            Console.WriteLine("Retiro exitoso");
          } else {
            Console.WriteLine("Saldo insuficiente");
          }
          Console.WriteLine(" Su balance es: {0}", human.account.balance); 
        break; 
      case 3:
          Console.WriteLine("Ingrese la cantidad a ingresar: "); 
          money = double.Parse(Console.ReadLine());
          human.account.addMoney(money);
          Console.WriteLine(" Su balance es: {0}", human.account.balance); 
        break; 
      default:
          Console.WriteLine("Opcion invalida"); 
        break; 
    }

    Console.ReadKey();
  }
}