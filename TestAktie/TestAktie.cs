using DLL;

namespace TestAktie
{
    [TestClass]
    public sealed class TestAktie
    {
        [DataTestMethod]
        [DataRow("x",1,100,300,100)]
        [DataRow("y", 2, 100, 25, 200)]
        [DataRow("j", 10, 250, 895, 2500)]


        [TestMethod]
        public void TestAktieToalPris(string aktieNavn, int antal, int købsPris, int salgsKurs, int res)
        {
            //Arrange
            Aktie a = new Aktie(aktieNavn, antal, købsPris, salgsKurs);

            //act
            int totalPris = a.TotalPris();

            //assert
            Assert.AreEqual(totalPris, res);
        }


        [DataTestMethod]
        [DataRow("x", 1, 100, 300, 200)]
        [DataRow("y", 2, 100, 25, -150)]
        [DataRow("j", 10, 250, 895, 6450)]

        [TestMethod]
        public void TestAktieAfKast(string aktieNavn, int antal, int købsPris, int salgsKurs, int res)
        {
            //Arrange
            Aktie a = new Aktie(aktieNavn, antal, købsPris, salgsKurs);

            //act
            int afkast = a.Afkast();

            //assert
            Assert.AreEqual(afkast, res);
        }

    }
}
