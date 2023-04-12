using System.Reflection.Metadata;

namespace DenverLibrary.TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Constructor_WhenInstantiated_SetsPropertyValues()
        {
            User user1 = new User("James");
        }
    }
}