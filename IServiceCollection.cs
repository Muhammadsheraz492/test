namespace Conection
{
    public interface IServiceCollection
    {
        void AddTransient<T>(Func<object, T> value);
    }
}