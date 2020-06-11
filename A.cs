using System;

public class A
{
    public int A1 { get; set; }

    public float A2 { get; set; }

    public A()
	{
	}

	public void MA1()
    {
		Console.WriteLine("MA1");
    }
	public void MA2()
    {
		Console.WriteLine("MA2");
    }

  public void MA3() {
    Console.WriteLine("Alteração a classe A partir do clone");
  }
}
