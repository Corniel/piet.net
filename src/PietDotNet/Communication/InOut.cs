namespace PietDotNet.Communication
{
    public interface InOut
    {
        long? InInt();
        char? InChr();

        void Out(long n);
        void Out(char c);
    }
}
