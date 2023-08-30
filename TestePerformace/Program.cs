using TestePerformace;

Console.WriteLine("Programa começou");
List<ClasseTeste> ObjetoLista = new();

DateTime dataInicio = DateTime.Now;
for (int i = 0; i <= 1000000; i++)
{
    ObjetoLista.Add(new ClasseTeste(
        i,
        i.ToString()
        ));
}
DateTime dataFim = DateTime.Now;
TimeSpan timeSpan = dataFim - dataInicio;
Console.WriteLine("Preencheu os dados");
Console.WriteLine("Demorou: " + timeSpan.TotalSeconds.ToString());

List<ClasseTeste> ObjetoListaNumPar = new();
List<ClasseTeste> ObjetoListaNumImpar = new();

dataInicio = DateTime.Now;
foreach (ClasseTeste classe in ObjetoLista)
{
    bool blxIsPar = classe.IDDOCARA % 2 == 0;
    switch (blxIsPar)
    {
        case true:
            ObjetoListaNumPar.Add(classe);
            break;
        case false:
            ObjetoListaNumImpar.Add(classe);
            break;
    }
}

dataFim = DateTime.Now;
timeSpan = dataFim - dataInicio;
Console.WriteLine("Demorou pra filtrar 1: " + timeSpan.TotalSeconds.ToString());

dataInicio = DateTime.Now;
ObjetoListaNumPar = new();
ObjetoListaNumImpar = new();

ObjetoListaNumPar = ObjetoLista.Where(x => x.IDDOCARA % 2 == 0).ToList();
ObjetoListaNumImpar = ObjetoLista.Where(x => x.IDDOCARA % 2 != 0).ToList();

dataFim = DateTime.Now;
timeSpan = dataFim - dataInicio;
Console.WriteLine("Demorou pra filtrar 2: " + timeSpan.TotalSeconds.ToString());
