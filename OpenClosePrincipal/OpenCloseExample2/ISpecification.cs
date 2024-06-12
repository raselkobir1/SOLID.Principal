namespace OpenClosePrincipal.OpenCloseExample2
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}
