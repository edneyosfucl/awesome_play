using System;

//Responsável por gerenciar as interações do usuário do console com a aplicação
class Views{
  
  //Visualização inicial
  public static int init(){
    int data = -1;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\n[1] Login");
    Console.WriteLine("[2] Novo usuário\n");
    Utils.showFooter();
    Console.WriteLine("- Escolha uma das opções:\n");

    try{ data = Convert.ToInt32(Console.ReadLine());}
    catch(Exception e){  }

    return data;
  }

  //Visualização de opção inválida
  public static void invalidOption(string title){
    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\n"+title);
    Console.WriteLine("\nOpção inválida!\n");  
    Utils.showFooter();
    Utils.sleep(3);
  }

  //Visualização mensagens
  public static void showMessage(string title, string msg){
    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\n"+title);
    Console.WriteLine("\n"+msg+"\n");  
    Utils.showFooter();
    Utils.sleep(3);
  }

  //Visualização para tela de login
  public static string[] login(){
    string[] data = new string[2];

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nLOGIN\n");
    Utils.showFooter();
    Console.WriteLine("- Informe o login de usuário:\n");
    data[0] = Console.ReadLine();
    Console.WriteLine("\n- Infome a senha de usuário:\n");
    data[1] = Console.ReadLine();

    return data;
  }

  //Visualização para tela de registro
  public static User register(){
    string nickname, birth, login, password;

    Console.Clear();
    Utils.showAppTitle();
    Console.WriteLine("\nNOVO USUÁRIO\n");
    Utils.showFooter();
    Console.WriteLine("- Informe o apelido:\n");
    nickname = Console.ReadLine();
    Console.WriteLine("\n- Informe a data de nascimento:\n");
    birth = Console.ReadLine();
    Console.WriteLine("\n- Informe o login:\n");
    login = Console.ReadLine();
    Console.WriteLine("\n- Informe a Senha:\n");
    password = Console.ReadLine();

    return new User(nickname, birth, login, password);
  }
}