using System;

namespace ProgrLab2
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu.Instance.Start();
    }
  }
}

public class Menu
{
  public void Start() //В методе Start происходит вызов одного из методов класса Menu
                      //в зависимости от того, что ввёл пользователь в консоль.
                      //Если значение, введённое пользователем некорректно, метод Start
                      //вызывается заново.
  {
    Console.WriteLine("Выберите формат: 0-Excel, 1-Word, 2-PDF, 3-TXT, 4-HTML");
    int Choice = Convert.ToInt32(Console.ReadLine());
    switch (Choice)
    {
      case 0:
        Menu.Instance.Excel();
        break;
      case 1:
        Menu.Instance.Word();
        break;
      case 2:
        Menu.Instance.PDF();
        break;
      case 3:
        Menu.Instance.Txt();
        break;
      case 4:
        Menu.Instance.HTML();
        break;
      default:
        Start();
        break;
    }
  }

  public static Menu Instance
  {
    get
    {
      if (instance == null) instance = new Menu();
      return instance;
    }
  }

  private Menu() { } //Собственно, сам Синглтон
  private static Menu instance;

  public void Excel()
  {
    var Excel = new
    {
      Name = "Pikchi.xlsx",
      Author = "Balbes",
      Keywords = "name, link",
      Subject = "pictures",
      Pathfile = "C:/Users/pawsw/source/repos/Quest_game_v2/pictures/Pikchi.xlsx"
    };
    Console.WriteLine(Excel);
  }
  public void Word()
  {
    var Word = new
    {
      Name = "Task.docx",
      Author = "Balbes",
      Keywords = "quest, text, bot",
      Subject = "project's task",
      Pathfile = "C:/Users/pawsw/source/repos/Quest_game_v2/Task.docx"
    };
    Console.WriteLine(Word);
  }
  public void PDF()
  {
    var PDF = new
    {
      Name = "Гавриловы_Истор. типы фил..pdf",
      Author = "Oleg Fedorovich Gavrilov",
      Keywords = "Philosophy, Nietzsche, Pantheism",
      Subject = "Philosophy",
      Pathfile = "C:/Users/pawsw/downloads/Гавриловы_Истор. типы фил..pdf"
    };
    Console.WriteLine(PDF);
  }
  public void Txt()
  {
    var Txt = new
    {
      Name = "data.txt",
      Author = "me",
      Keywords = "user, id, states",
      Subject = "Bot",
      Pathfile = "C:/Users/pawsw/source/repos/Quest_game_v2/data/data.txt"
    };
    Console.WriteLine(Txt);
  }
  public void HTML()
  {
    var HTML = new
    {
      Name = "SomeName.html",
      Author = "Nobody",
      Keywords = "nothing, absolutely",
      Subject = "Void",
      Pathfile = "C:/Users/pawsw/Documents/SomeName.html"
    };
    Console.WriteLine(HTML);
  }
}