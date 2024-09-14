public class ConnectSingleton
{
  private static ConnectSingleton instance;

  private ConnectSingleton()
  {
    
  }

  public static ConnectSingleton GetInstance()
  {
    if (instance == null)
    {
      instance = new ConnectSingleton();
    }
    return instance;
  }
}