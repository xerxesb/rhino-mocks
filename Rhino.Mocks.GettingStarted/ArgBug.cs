using NUnit.Framework;

namespace Rhino.Mocks.GettingStarted
{
    public interface IFoo
    {
        string DoFoo(string foo);
    }
    public class Bar
    {
        public void DoFoo(IFoo foo)
        {
            foo.DoFoo("some string");
        }
    }
    public class TestClass
    {
        [Test]
        public void TestBlah()
        {
            var mock = MockRepository.GenerateMock<IFoo>();
            new Bar().DoFoo(mock);
            mock.AssertWasCalled(x => x.DoFoo(Arg<string>.Matches(obj => true)));
        }
    }
}