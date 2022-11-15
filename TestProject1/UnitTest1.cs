using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScore9()
        {
            Student s = new Student(){ Score = 9};
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);

        }
        /*
                [TestMethod]
                public void TestScore7()
                {
                    Student s = new Student() { Score = 7 };
                    char letter = s.getLetterScore();
                    Assert.AreEqual('B', letter);

                }
                [TestMethod]
                public void TestScore5()
                {
                    Student s = new Student() { Score = 5 };
                    char letter = s.getLetterScore();
                    Assert.AreEqual('C', letter);

                }
                [TestMethod]
                public void TestScore3dot5()
                {
                    Student s = new Student() { Score = 3.5 };
                    char letter = s.getLetterScore();
                    Assert.AreEqual('D', letter);

                }
                [TestMethod]
                public void TestScore_under_3dot5()
                {
                    Student s = new Student() { Score = 2 };
                    char letter = s.getLetterScore();
                    Assert.AreEqual('E', letter);

                }
        */
    }
}