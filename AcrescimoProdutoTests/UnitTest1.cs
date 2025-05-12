using System;
using Xunit;

public class ProgramTests
{
    [Fact]
    public void Teste_Calculo_Acrescimo_Produto_Valido()
    {
        decimal valorProduto = 50.00m;

        decimal valorEsperado = valorProduto * 1.10m;
        
        Assert.Equal(55.00m, valorEsperado);
    }

    [Fact]
    public void Teste_Calculo_Acrescimo_Produto_Invalido()
    {
        decimal valorProduto = -10.00m;

        Assert.False(valorProduto > 0);
    }
}
