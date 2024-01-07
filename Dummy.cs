namespace Jvu.Test.SharedLib.NoDeps
{
  public class Dummy
  {
    private readonly string _testValue = "Hello Dummy!";

    public bool IsDummy { get; set; }
    public string Name { get; set; }

    public Dummy() { }
    public Dummy(string name) { Name = name; }
    public Dummy(string name, bool isDummy) { Name = name; IsDummy = isDummy; }

    public string GetTestValue()
    {
      return _testValue;
    }
  }
}
