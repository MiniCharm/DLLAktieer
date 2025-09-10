using DLL;
using DLL_Fortsat;
using Xunit;

namespace TestAktie;

[TestClass]
[Collection("")]
public class TestAktieManeger
{
    [DataTestMethod]
    [DataRow("DSV", 1, 1312, 1300)]
    [DataRow("Novo", 6, 1555, 1500)]
    [DataRow("Iss", 2, 193, 170)]

    [Fact]
    public void TestTilføjAktie(string aktieNavn, int antal, int købsPris, int salgsKurs)
    {
        //Arrange
        AktieManager am = new AktieManager();

        //Act
        am.TilføjAktie(new Aktie(aktieNavn, antal, købsPris, salgsKurs));

        //Assert
        Assert.IsNotNull(AktieManager.AktieListe);
    }

    [Fact]
    public void TestTotalAfkast()
    {
        //Arrange
        AktieManager am = new AktieManager();
        Aktie a1 = new Aktie("DSV", 1, 1312, 1300);
        Aktie a2 = new Aktie("Novo", 6, 1555, 1500);
        Aktie a3 = new Aktie("Iss", 2, 193, 170);

        //Act
        am.TilføjAktie(a1);
        am.TilføjAktie(a2);
        am.TilføjAktie(a3);

        int total = a1.Afkast() + a2.Afkast() + a3.Afkast();
        int amTotal = am.TotalAfkast();

        //Assert
        Assert.AreEqual(total, amTotal);
    }
}
