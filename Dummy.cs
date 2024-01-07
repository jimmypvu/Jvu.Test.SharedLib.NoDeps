namespace Jvu.Test.SharedLib.NoDeps
{
  public class Dummy
  {
    private readonly string _testValue = "Hello Dummy!";

    public bool IsDummy { get; private set; } = true;

    public Dummy() { }
    public Dummy(bool isDummy) { IsDummy = isDummy; }

    public string GetTestValue()
    {
      return _testValue;
    }
  }
}
