using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll
{
    public class Class2
    {
        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103fibonacciNumbercpp(int fiIndex);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103strrevcpp( char[] fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103strlencpp(string fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103strcatcpp(char[] fiDest, char[] fiSrc);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103strcmpcpp(string fiLhs, string fiRhs);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103strcpycpp(char[] foDestination, char[] fiSource);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103hex2bincpp(string fiHex, int fiHexLen, byte[] foBin);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103bin2hexcpp([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex);


        /**
        *
        *	  @name   fibonacciNumber (ce103_fibonacciNumber_cs_imported)
        *
        *	  @brief Fibonacci Number Calculator
        *
        *	  Calculates the fibonacci number in the given index and return as output
        *
        *	  @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
        *
        *	  @retval [\b int] ce103_fibonacciNumber_cpp
        **/
        public int ce103fibonacciNumbercsharpimported(int fiIndex)
        {
            return ce103fibonacciNumbercpp(fiIndex);
        }

       

        private static string PointerToStringUtf8(IntPtr pointer1) // aPtr is nul-terminated
        {
            if (pointer1 == IntPtr.Zero)
                return "";
            int length1 = 0;
            while (System.Runtime.InteropServices.Marshal.ReadByte(pointer1, length1) != 0)
                length1++;
            if (length1 == 0)
                return "";
            byte[] array1 = new byte[length1];
            System.Runtime.InteropServices.Marshal.Copy(pointer1, array1, 0, length1);
            return System.Text.Encoding.UTF8.GetString(array1);
        }
        /**
           @name   strrev (ce103_strrev_cs_imported)

           @brief \b Reverse string

           Reverse given string

           @param [in] fiStr [\b string] The given string which is needed to be reversed.

           @retval [\b string] ce103_strrev_cpp
        **/

        public string ce103strrevcsharpimported(string fiStr)
        {

            var q = fiStr.ToCharArray();
            var w = new char[fiStr.Length+1];
            for (int i = 0; i < q.Length; i++)
            {
                w[i] = q[i];
            }
            w[fiStr.Length] = '\0';
            var x = ce103strrevcpp(w); 
            return PointerToStringUtf8(x);
        }

        /**
	        @name   strlen (ce103_strlen_cs_imported)

	        @brief \b Get string length

            Get length of a string

	        Returns the length of the C sharp string str.

	        @param [in] fiStr [\b string] given string

	        @retval [\b int] ce103_strlen_cpp
        **/
        public int ce103strlencsharpimported(string fiStr)
        {
            return ce103strlencpp(fiStr);
        }

        /**
            @name   strcat (ce103_strcat_cs_imported)

            @brief \b Concatenate strings

            Concatenate two strings

            @param  [in] fiDest [\b string] will be appended string

            @param  [in] fiSrc  [\b string] will be copy from this

            @retval [\b string] ce103_strcat_cpp
        **/
        public string ce103strcatcsharpimported(string fiDest, string fiSrc)
        {


            var q = fiDest.ToCharArray();
            var w = new char[fiDest.Length + 1];
            for (int i = 0; i < q.Length; i++)
            {
                w[i] = q[i];
            }
            w[fiDest.Length] = '\0';

            var u = fiSrc.ToCharArray();
            var d = new char[fiSrc.Length + 1];
            for (int i = 0; i <u.Length; i++)
            {
                d[i] = u[i];
            }
            d[fiSrc.Length] = '\0';





            var c = ce103strcatcpp(w,d);
            return PointerToStringUtf8(c);
        }

        /**
            @name   strcmp (ce103_strcmp_cs_imported)

            @brief  \b Compare two strings

            Compare two strings

            @param  [in] fiLhs [\b string] string to compare

            @param  [in] fiRhs [\b string] string to compare

            @retval [\b int] ce103_strcmp_cpp
        **/
        public int ce103strcmpcsharpimported(string fiLhs, string fiRhs)
        {
            return ce103strcmpcpp(fiLhs, fiRhs);
        }

        /**
            @name  strcpy (ce103_strcpy_cs_imported)

            @brief \b Copy string

            Copy string to another

            @param [out] foDestination	[\b string] destination string to copy

            @param [in]  fiSource		[\b string]	C sharp string to be copied.

            @retval [\b string] ce103_strcpy_cpp
        **/
        public string ce103strcpycsharpimported(string foDestination, string fiSource)
        {
            var q = foDestination.ToCharArray();
            var w = new char[foDestination.Length + 1];
            for (int i = 0; i < q.Length; i++)
            {
                w[i] = q[i];
            }
            w[foDestination.Length] = '\0';

            var u = fiSource.ToCharArray();
            var d = new char[fiSource.Length + 1];
            for (int i = 0; i < u.Length; i++)
            {
                d[i] = u[i];
            }
            d[fiSource.Length] = '\0';

            var c = ce103strcpycpp(w, d);
            return PointerToStringUtf8(c);


        }

        /**
         * @name    hex2bin (ce103_hex2bin_cs_imported)
         * 
         * @brief   \b Hexadecimal string to byte array Conversion
         * 
         * Convert hex string to byte array
         *
         * @param   [in]  fiHex    [\b string] Ascii hex string.
         * 
         * @param   [in]  fiHexLen [\b int]     Ascii data length.
         * 
         * @param  [out]  foBin    [\b byte[]]   Convertion result as binary.
         **/
        public void ce103hex2bincsharpimported(string fiHex, int fiHexLen, byte[] foBin)
        {
            ce103hex2bincpp(fiHex, fiHexLen, foBin);
        }

        /**
        * @name    bin2hex (ce103_bin2hex_cs_imported)
        * 
        * @brief   \b Binary to Hexadecimal Conversion
        *
        * Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
        *
        * @param [in]  fiBin      [\b byte[]]    Binary data to be converted.
        * 
        * @param [in]  fiBinLen   [\b int]	 Binary data length.
        * 
        * @param [out] foHex      [\b char[]]	 Convertion result as ascii. Doubles the binary length.
        **/
        public void ce103bin2hexcsharpimported([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex)
        {
            ce103bin2hexcpp(fiBin, fiBinLen, foHex);
        }
    }
}
