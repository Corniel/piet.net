namespace PietDotNet
{
    public interface IInOut
    {
        long? InInt();
        char? InChr();

        void Out(long n);
        void Out(char c);
    }
}
