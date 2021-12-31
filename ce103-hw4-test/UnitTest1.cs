using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll;
using System.Text;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_1()
        {
            Class1 fibonacci = new Class1();
            int res = fibonacci.ce103fibonacciNumbercsharp(7);
            Assert.AreEqual(res, 8);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_1()
        {
            Class2 fibonacci = new Class2();
            int res = fibonacci.ce103fibonacciNumbercsharpimported(7);
            Assert.AreEqual(res, 8);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_1()
        {
            Class1 fibonacci = new Class1();
            int res = fibonacci.ce103fibonacciNumbercsharp(7);
            Class2 fiboo = new Class2();
            int res2 = fiboo.ce103fibonacciNumbercsharpimported(7);
            Assert.AreEqual(res, res2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_2()
        {
            Class1 fibonacci = new Class1();
            int res = fibonacci.ce103fibonacciNumbercsharp(15);
            Assert.AreEqual(res, 377);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_2()
        {
            Class2 fibonacci = new Class2();
            int res = fibonacci.ce103fibonacciNumbercsharpimported(15);
            Assert.AreEqual(res, 377);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_2()
        {
            Class1 fibonacci = new Class1();
            int res = fibonacci.ce103fibonacciNumbercsharp(15);
            Class2 fibonacci1 = new Class2();
            int res2 = fibonacci1.ce103fibonacciNumbercsharpimported(15);
            Assert.AreEqual(res, res2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_test_3()
        {
            Class1 fibonacci = new Class1();
            int res = fibonacci.ce103fibonacciNumbercsharp(4);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_cs_imported_test_3()
        {
            Class2 fibonacci = new Class2();
            int res = fibonacci.ce103fibonacciNumbercsharpimported(4);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void ce103_fibonacciNumber_importedcppcs_test_3()
        {
            Class1 fibonacci = new Class1();
            int res = fibonacci.ce103fibonacciNumbercsharp(4);
            Class2 fibonacci1 = new Class2();
            int res2 = fibonacci1.ce103fibonacciNumbercsharpimported(4);
            Assert.AreEqual(res, res2);
        }
        [TestMethod]
        public void ce103_strrev_cs_test_1()
        {
            Class1 stringreverse = new Class1();
            Assert.AreEqual(stringreverse.ce103strrevcsharp("Csharp"), "prahsC");
        }
  
        [TestMethod]
        public void ce103_strrev_cs_test_2()
        {
            Class1 stringreverse = new Class1();
            Assert.AreEqual(stringreverse.ce103strrevcsharp("Cplusplus"), "sulpsulpC");
        }
    
        [TestMethod]
        public void ce103_strrev_cs_test_3()
        {
            Class1 stringreverse = new Class1();
            Assert.AreEqual(stringreverse.ce103strrevcsharp("Python"), "nohtyP");         
        }
     
        [TestMethod]
        public void ce103_strlen_cs_test_1()
        {
            Class1 stringlength = new Class1();
            Assert.AreEqual(stringlength.ce103strlencsharp("Visual Studio"), 13);
        }

        [TestMethod]
        public void ce103_strlen_cs_test_2()
        {
            Class1 stringlength = new Class1();
            Assert.AreEqual(stringlength.ce103strlencsharp("Software"), 8);
        }
    
        [TestMethod]
        public void ce103_strlen_cs_test_3()
        {
            Class1 stringlength = new Class1();
            Assert.AreEqual(stringlength.ce103strlencsharp("Omer Faruk Varli"), 16);
        }

        [TestMethod]
        public void ce103_strcat_cs_test_1()
        {
            Class1 stringconcatenate = new Class1();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharp("Visual","Studio"),"VisualStudio");
        }
  
        [TestMethod]
        public void ce103_strcat_cs_test_2()
        {
            Class1 stringconcatenate = new Class1();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharp("Omer","Varli"),"OmerVarli");
        }
 
        [TestMethod]
        public void ce103_strcat_cs_test_3()
        {
            Class1 stringconcatenate = new Class1();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharp("Champion","Trabzon"),"ChampionTrabzon");
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_1()
        {
            Class1 stringcompare = new Class1();
            Assert.AreEqual(stringcompare.ce103strcmpcsharp("Trabzonspor", "Trabzonspor"), 0);
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_test_2()
        {
            Class1 stringcompare = new Class1();
            Assert.AreNotEqual(stringcompare.ce103strcmpcsharp("Software", "Engineering"), 0);
        }

        [TestMethod]
        public void ce103_strcmp_cs_test_3()
        {
            Class1 stringcompare = new Class1();
            Assert.AreNotEqual(stringcompare.ce103strcmpcsharp("Omer", "Faruk"), 0);
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_1()
        {
            Class1 stringcopy = new Class1();
            Assert.AreEqual(stringcopy.ce103strcpycsharp("Omer", "Hello"), "Hello");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_2()
        {
            Class1 stringcopy = new Class1();
            Assert.AreEqual(stringcopy.ce103strcpycsharp("Champion", "Trabzonspor"), "Trabzonspor");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_test_3()
        {
            Class1 stringcopy = new Class1();
            Assert.AreEqual(stringcopy.ce103strcpycsharp("Visual", "Studio"), "Studio");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_1()
        {
            Class2 stringreverse = new Class2();
            Assert.AreEqual(stringreverse.ce103strrevcsharpimported("Csharp"), "prahsC");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_1()
        {
            Class1 stringreverse = new Class1();
            Class2 stringreverse1 = new Class2();
            Assert.AreEqual(stringreverse.ce103strrevcsharp("Csharp"), "prahsC", stringreverse1.ce103strrevcsharpimported("Csharp"), "prahsC");
        }
 
        [TestMethod]
        public void ce103_strrev_cs_imported_test_2()
        {
            Class2 stringreverse = new Class2();
            Assert.AreEqual(stringreverse.ce103strrevcsharpimported("Cplusplus"), "sulpsulpC");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_2()
        {
            Class1 stringreverse = new Class1();
            Class2 stringreverse1 = new Class2();
            Assert.AreEqual(stringreverse.ce103strrevcsharp("Cplusplus"), "sulpsulpC", stringreverse1.ce103strrevcsharpimported("Cplusplus"), "sulpsulpC");
        }
     
        [TestMethod]
        public void ce103_strrev_cs_imported_test_3()
        {
            Class2 stringreverse = new Class2();
            Assert.AreEqual(stringreverse.ce103strrevcsharpimported("Python"), "nohtyP");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_3()
        {
            Class1 stringreverse = new Class1();
            Class2 stringreverse1 = new Class2();
            Assert.AreEqual(stringreverse.ce103strrevcsharp("Python"), "nohtyP", stringreverse1.ce103strrevcsharpimported("Python"), "nohtyP");
        }
       
        [TestMethod]
        public void ce103_strcat_cs_imported_test_1()
        {
            Class2 stringconcatenate = new Class2();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharpimported("Visual", "Studio"), "VisualStudio");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_1()
        {
            Class1 stringconcatenate = new Class1();
            Class2 stringconcatenate1 = new Class2();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharp("Visual", "Studio"), "VisualStudio", stringconcatenate1.ce103strcatcsharpimported("Visual", "Studio"), "VisualStudio");
        }
      
        [TestMethod]
        public void ce103_strcat_cs_imported_test_2()
        {
            Class2 stringconcatenate = new Class2();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharpimported("Omer", "Varli"), "OmerVarli");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_2()
        {
            Class1 stringconcatenate = new Class1();
            Class2 stringconcatenate1 = new Class2();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharp("Omer", "Varli"), "OmerVarli", stringconcatenate1.ce103strcatcsharpimported("Omer", "Varli"), "OmerVarli");
        }
        
        [TestMethod]
        public void ce103_strcat_cs_imported_test_3()
        {
            Class2 stringconcatenate = new Class2();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharpimported("Champion", "Trabzon"), "ChampionTrabzon");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_3()
        {
            Class1 stringconcatenate = new Class1();
            Class2 strinconcatenate1 = new Class2();
            Assert.AreEqual(stringconcatenate.ce103strcatcsharp("Champion", "Trabzon"), "ChampionTrabzon", strinconcatenate1.ce103strcatcsharpimported("Champion", "Trabzon"), "ChampionTrabzon");
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_1()
        {
            Class2 stringlength = new Class2();
            Assert.AreEqual(stringlength.ce103strlencsharpimported("Visual Studio"), 13);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_1()
        {
            Class1 stringlength = new Class1();
            Class2 stringlength1 = new Class2();
            Assert.AreEqual(stringlength.ce103strlencsharp("Visual Studio"), 13, stringlength1.ce103strlencsharpimported("Visual Studio"));
        }
    
        [TestMethod]
        public void ce103_strlen_cs_imported_test_2()
        {
            Class2 stringlength = new Class2();
            Assert.AreEqual(stringlength.ce103strlencsharpimported("Software"), 8);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_2()
        {
            Class1 stringlength = new Class1();
            Class2 stringlength1 = new Class2();
            Assert.AreEqual(stringlength.ce103strlencsharp("Software"), 8, stringlength1.ce103strlencsharpimported("Software"));
        }
  
        [TestMethod]
        public void ce103_strlen_cs_imported_test_3()
        {
            Class2 stringlength = new Class2();
            Assert.AreEqual(stringlength.ce103strlencsharpimported("Omer Faruk Varli"), 16);
        }
        [TestMethod]
        public void ce103_strlen_importedcppcs_test_3()
        {
            Class1 stringlength = new Class1();
            Class2 stringlength1 = new Class2();
            Assert.AreEqual(stringlength.ce103strlencsharp("Omer Faruk Varli"), 16, stringlength1.ce103strlencsharpimported("Omer Faruk Varli"));
        }

        [TestMethod]
        public void ce103_strcmp_cs_imported_test_1()
        {
            Class2 stringcompare = new Class2();
            Assert.AreEqual(stringcompare.ce103strcmpcsharpimported("Trabzonspor", "Trabzonspor"), 0);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_1()
        {
            Class1 stringcompare = new Class1();
            Class2 stringcompare1 = new Class2();
            Assert.AreEqual(stringcompare.ce103strcmpcsharp("Trabzonspor", "Trabzonspor"), 0, stringcompare1.ce103strcmpcsharpimported("Trabzonspor", "Trabzonspor"));
        }
     
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_2()
        {
            Class2 stringcompare = new Class2();
            Assert.AreNotEqual(stringcompare.ce103strcmpcsharpimported("Software", "Engineering"), 2);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_2()
        {
            Class1 stringcompare = new Class1();
            Class2 stringcompare1 = new Class2();
            Assert.AreNotEqual(stringcompare.ce103strcmpcsharp("Software", "Engineering"), 2, stringcompare1.ce103strcmpcsharpimported("Software", "Engineering"));
        }
 
        [TestMethod]
        public void ce103_strcmp_cs_imported_test_3()
        {
            Class2 stringcompare = new Class2();
            Assert.AreNotEqual(stringcompare.ce103strcmpcsharpimported("Omer", "Faruk"), 2);
        }
        [TestMethod]
        public void ce103_strcmp_importedcppcs_test_3()
        {
            Class1 stringcompare = new Class1();
            Class2 stringcompare1 = new Class2();
            Assert.AreNotEqual(stringcompare.ce103strcmpcsharp("Omer", "Faruk"), 2, stringcompare1.ce103strcmpcsharpimported("Omer", "Faruk"));
        }

        [TestMethod]
        public void ce103_strcpy_cs_imported_test_1()
        {
            Class2 stringcopy = new Class2();
            Assert.AreEqual(stringcopy.ce103strcpycsharpimported("Omer", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_1()
        {
            Class1 stringcopy = new Class1();
            Class2 stringcopy1 = new Class2();
            Assert.AreEqual(stringcopy.ce103strcpycsharp("Omer", "Hello"), "Hello", stringcopy1.ce103strcpycsharpimported("Omer", "Hello"), "Hello");
        }
 
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_2()
        {
            Class2 stringcopy = new Class2();
            Assert.AreEqual(stringcopy.ce103strcpycsharpimported("Champion", "Trabzonspor"), "Trabzonspor");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_2()
        {
            Class1 stringcopy = new Class1();
            Class2 stringcopy1 = new Class2();
            Assert.AreEqual(stringcopy.ce103strcpycsharp("Champion", "Trabzonspor"), "Trabzonspor", stringcopy1.ce103strcpycsharpimported("Champion", "Trabzonspor"), "Trabzonspor");
        }
     
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_3()
        {
            Class2 stringcopy = new Class2();
            Assert.AreEqual(stringcopy.ce103strcpycsharpimported("Visual", "Studio"), "Studio");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_3()
        {
            Class1 stringcopy = new Class1();
            Class2 stringcopy1 = new Class2();
            Assert.AreEqual(stringcopy.ce103strcpycsharp("Visual", "Studio"), "Studio", stringcopy1.ce103strcpycsharpimported("Visual", "Studio"), "Studio");
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test1()
        {
            Class1 binary2hexadecimal = new Class1();
            byte[] binary = { 0xCC, 0xAF, 0xBB, 0x45, 0x12, 0x33 };
            char[] hexadecimalstring1 = new char[binary.Length * 2];
            char[] hexadecimalstring = { 'C', 'C', 'A', 'F', 'B', 'B', '4', '5', '1', '2', '3', '3' };

            binary2hexadecimal.ce103bin2hexcsharp(binary, binary.Length, hexadecimalstring1);

            CollectionAssert.AreEqual(hexadecimalstring, hexadecimalstring1);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test1()
        {
            Class2 imported = new Class2();
            byte[] binary = { 0xAC, 0xBB, 0xDC, 0xCA, 0xEA, 0xEB, 0xFA, 0xFF };
            char[] hexadecimalstring2 = new char[binary.Length * 2];
            char[] hexadecimalstring = { 'A', 'C', 'B', 'B', 'D', 'C', 'C', 'A', 'E', 'A', 'E', 'B', 'F', 'A', 'F', 'F' };

            imported.ce103bin2hexcsharpimported(binary, binary.Length, hexadecimalstring2);

            CollectionAssert.AreEqual(hexadecimalstring, hexadecimalstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test1()
        {
            Class1 binary2hexadecimal = new Class1();
            Class2 imported = new Class2();
            byte[] binary = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexadecimalstring2 = new char[binary.Length * 2];
            char[] hexadecimalstring1 = new char[binary.Length * 2];
            binary2hexadecimal.ce103bin2hexcsharp(binary, binary.Length, hexadecimalstring1);
            imported.ce103bin2hexcsharpimported(binary, binary.Length, hexadecimalstring2);

            CollectionAssert.AreEqual(hexadecimalstring1, hexadecimalstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test2()
        {
            Class1 binary2hexadecimal = new Class1();
            byte[] binary = { 0x34, 0x22, 0x53, 0x13, 0x44 };
            char[] hexadecimalstring2 = new char[binary.Length * 2];
            char[] hexadecimalstring = { '3', '4', '2', '2', '5', '3', '1', '3', '4', '4' };

            binary2hexadecimal.ce103bin2hexcsharp(binary, binary.Length, hexadecimalstring2);

            CollectionAssert.AreEqual(hexadecimalstring, hexadecimalstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test2()
        {
            Class2 imported = new Class2();
            byte[] binary = { 0x32, 0x15, 0x44, 0x12, 0x11 };
            char[] hexadecimalstring2 = new char[binary.Length * 2];
            char[] hexadecimalstring = { '3', '2', '1', '5', '4', '4', '1', '2', '1', '1' };

            imported.ce103bin2hexcsharpimported(binary, binary.Length, hexadecimalstring2);

            CollectionAssert.AreEqual(hexadecimalstring, hexadecimalstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test2()
        {
            Class1 binary2hexadecimal = new Class1();
            Class2 imported = new Class2();
            byte[] binary = { 0xBB, 0xFB, 0xCD, 0x23, 0x43, 0x10 };
            char[] hexadecimalstring2 = new char[binary.Length * 2];
            char[] hexadecimalstring1 = new char[binary.Length * 2];
            binary2hexadecimal.ce103bin2hexcsharp(binary, binary.Length, hexadecimalstring1);
            imported.ce103bin2hexcsharpimported(binary, binary.Length, hexadecimalstring2);

            CollectionAssert.AreEqual(hexadecimalstring1, hexadecimalstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_cs_test3()
        {
            Class1 binary2hexadecimal = new Class1();
            byte[] binary = { 0xBB, 0xAC, 0xDD, 0xEC, 0xFA, 0xAA, 0xEE, 0xFF };
            char[] hexadecimalstring2 = new char[binary.Length * 2];
            char[] hexadecimalstring = { 'B', 'B', 'A', 'C', 'D', 'D', 'E', 'C', 'F', 'A', 'A', 'A', 'E', 'E', 'F', 'F' };

            binary2hexadecimal.ce103bin2hexcsharp(binary, binary.Length, hexadecimalstring2);

            CollectionAssert.AreEqual(hexadecimalstring, hexadecimalstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_imported_test3()
        {
            Class2 imported = new Class2();
            byte[] binary = { 0xAA, 0xFB, 0xCD, 0x23, 0x43, 0x24 };
            char[] hexadecimalstring2 = new char[binary.Length * 2];
            char[] hexadecimalstring = { 'A', 'A', 'F', 'B', 'C', 'D', '2', '3', '4', '3', '2', '4' };

            imported.ce103bin2hexcsharpimported(binary, binary.Length, hexadecimalstring2);

            CollectionAssert.AreEqual(hexadecimalstring, hexadecimalstring2);
        }
        [TestMethod]
        public void ce103_bin2hex_importedcppcs_test3()
        {
            Class1 binary2hexadecimal = new Class1();
            Class2 imported = new Class2();
            byte[] binary = { 0xAB, 0xCC, 0xED, 0xBA, 0xFD, 0xFB, 0xCB, 0xAE, 0xAC };
            char[] hexadecimalstring2 = new char[binary.Length * 2];
            char[] hexadecimalstring1 = new char[binary.Length * 2];
            binary2hexadecimal.ce103bin2hexcsharp(binary, binary.Length, hexadecimalstring1);
            imported.ce103bin2hexcsharpimported(binary, binary.Length, hexadecimalstring2);
            CollectionAssert.AreEqual(hexadecimalstring1, hexadecimalstring2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test1()
        {
            Class1 hexadecimal2binary = new Class1();
            string hexadecimalstring = "1563725435123812";
            byte[] expectedArray1 = { 0x15, 0x63, 0x72, 0x54, 0x35, 0x12, 0x38, 0x12 };
            byte[] hexadecimalArray = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharp(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArray1, hexadecimalArray);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test1()
        {
            Class2 hexadecimal2binary = new Class2();
            string hexadecimalstring = "AEFFBC456213";
            byte[] expectedArray1 = { 0xAE, 0xFF, 0xBC, 0x45, 0x62, 0x13 };
            byte[] hexadecimalArray = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharpimported(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArray1, hexadecimalArray);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test1()
        {
            Class2 imported = new Class2();
            Class1 hexadecimal2binary = new Class1();
            string hexadecimalstring = "FFFFFFFFFF";

            byte[] hexadecimalArray1 = new byte[hexadecimalstring.Length / 2];
            imported.ce103hex2bincsharpimported(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray1);

            byte[] hexadecimalArray2 = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharp(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray2);

            // assert by sequence
            CollectionAssert.AreEqual(hexadecimalArray1, hexadecimalArray2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test2()
        {
            Class1 hexadecimal2binary = new Class1();
            string hexadecimalstring = "2315753214331112";
            byte[] expectedArray1 = { 0x23, 0x15, 0x75, 0x32, 0x14, 0x33, 0x11, 0x12 };
            byte[] hexadecimalArray = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharp(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArray1, hexadecimalArray);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test2()
        {
            Class2 hexadecimal2binary = new Class2();
            string hexadecimalstring = "2348975982379872239487";
            byte[] expectedArray1 = { 0x23, 0x48, 0x97, 0x59, 0x82, 0x37, 0x98, 0x72, 0x23, 0x94, 0x87 };
            byte[] hexadecimalArray = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharpimported(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArray1, hexadecimalArray);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test2()
        {
            Class2 imported = new Class2();
            Class1 hexadecimal2binary = new Class1();
            string hexadecimalstring = "FFAEDDAA";
            byte[] expectedArray1 = { 0xFF, 0xAE, 0xDD, 0xAA };

            byte[] hexadecimalArray = new byte[hexadecimalstring.Length / 2];
            imported.ce103hex2bincsharpimported(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray);

            byte[] hexadecimalArray2 = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharp(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray2);

            // assert by sequence
            CollectionAssert.AreEqual(hexadecimalArray, hexadecimalArray2);
        }
        [TestMethod]
        public void ce103_hex2bin_cs_test3()
        {
            Class1 hexadecimal2binary = new Class1();
            string hexadecimalstring = "ABCCECBDAAFDCAFA";
            byte[] expectedArray1 = { 0xAB, 0xCC, 0xEC, 0xBD, 0xAA, 0xFD, 0xCA, 0xFA };
            byte[] hexadecimalArray = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharp(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArray1, hexadecimalArray);
        }
        [TestMethod]
        public void ce103_hex2bin_imported_test3()
        {
            Class2 hexadecimal2binary = new Class2();
            string hexadecimalstring = "2365231144521719778913";
            byte[] expectedArray1 = { 0x23, 0x65, 0x23, 0x11, 0x44, 0x52, 0x17, 0x19, 0x77, 0x89, 0x13 };
            byte[] hexadecimalArray = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharpimported(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArray1, hexadecimalArray);
        }
        [TestMethod]
        public void ce103_hex2bin_importedcppcs_test3()
        {
            Class2 imported = new Class2();
            Class1 hexadecimal2binary = new Class1();
            string hexadecimalstring = "91423FC23A234832FA";
            byte[] expectedArray = { 0x91, 0x42, 0x3F, 0xC2, 0x3A, 0x23, 0x48, 0x32, 0xFA };

            byte[] hexadecimalArray = new byte[hexadecimalstring.Length / 2];
            imported.ce103hex2bincsharpimported(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray);

            byte[] hexadecimalArray2 = new byte[hexadecimalstring.Length / 2];
            hexadecimal2binary.ce103hex2bincsharp(hexadecimalstring, hexadecimalstring.Length, hexadecimalArray2);

            // assert by sequence
            CollectionAssert.AreEqual(hexadecimalArray, hexadecimalArray2);
        }
    }
}
