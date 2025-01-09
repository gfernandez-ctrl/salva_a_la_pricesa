using System;
using Xunit;

public class TestArmes
{
    [Fact]
    public void TestPagesos()
    {
        // Arrange
        string[] armes = new string[]
        {
            "Llança", "Llança", "Llança", "Llança"
        };

        // Act
        int pagesos = CalcularPagesos(armes);

        // Assert
        Assert.Equal(4, pagesos); // Se espera que se formen 4 pagesos
    }

    private int CalcularPagesos(string[] armes)
    {
        int llança = 0;

        foreach (var arma in armes)
        {
            if (arma == "Llança")
            {
                llança++;
            }
        }

        return llança; // Cada "Llança" forma un pages
    }
}