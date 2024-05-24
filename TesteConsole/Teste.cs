using Microsoft.Extensions.Options;

public class Teste : ITeste
{
    public MyOptions _options;
    public Teste(IOptions<MyOptions> options)
    {
        _options = options.Value;
    }
    public void Write()
    {
        Console.WriteLine($"Hello: {_options.PostgreSql}");
    }
}