

Console.Write("Valor da fatura: ");
decimal valor = decimal.Parse(Console.ReadLine());

Console.Write("Vencimento (dd/mm/aaaa): ");
DateTime venc = DateTime.Parse(Console.ReadLine());

int dias = (DateTime.Today - venc).Days;

if (dias <= 0)
{
    Console.WriteLine("Sem atraso.");
    return;
}

decimal juros = valor * 0.025m * dias;
Console.WriteLine($"Total de juros: R$ {juros:F2}");
Console.WriteLine($"Total a pagar: R$ {(valor + juros):F2}");