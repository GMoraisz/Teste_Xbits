namespace Teste_Xbits.Infra.ORM.EntitiesMapping.Base;

public abstract class BaseMapping
{
    private const string DefaultSchema = "XB";
    protected string Schema { get; }

    protected BaseMapping() =>
        Schema = DefaultSchema;

    protected BaseMapping(string schema) =>
        Schema = schema;
}