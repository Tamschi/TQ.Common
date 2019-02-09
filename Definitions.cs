using System.Text;

namespace TQ.Common
{
    public static class Definitions
    {
        //TODO: Should be codepage 1252, but that's not supported by default.
        public static Encoding Encoding => Encoding.ASCII;
    }
}
