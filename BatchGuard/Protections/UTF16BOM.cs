using System.Text;

namespace BatchGuard.Protections
{
    public class UTF16BOM
    {
        public static byte[] Process(string input)
        {
            Debug.Log("Adding UTF-16 byte-order-mark...", LogType.Normal);
            byte[] uniheader = new byte[] { 0xFF, 0xFE, 0x0D, 0x0A };
            byte[] gencodebytes = Encoding.ASCII.GetBytes(input);
            byte[] ret = new byte[uniheader.Length + gencodebytes.Length + 1];
            uniheader.CopyTo(ret, 0);
            Debug.Log("Unicode header copied.", LogType.Info);
            gencodebytes.CopyTo(ret, uniheader.Length);
            Debug.Log("Successfully added UTF-16 byte-order-mark.", LogType.Success);
            return ret;
        }
    }
}
