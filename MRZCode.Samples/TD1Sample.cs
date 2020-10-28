using System;
using MRZCodeParser;

namespace MRZCode.Samples
{
    public static class TD1Sample
    {
        public static void Run()
        {
            var text = @"I<UTOD231458907<<<<<<<<<<<<<<<
7408122F1204159UTO<<<<<<<<<<<6
ERIKSSON<<ANNA<MARIA<<<<<<<<<<";

            Console.WriteLine("TD1 code sample");
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();

            var mrzCode = MrzCode.Parse(text);

            Console.WriteLine("Code type:                {0}", mrzCode.Type);

            Console.WriteLine("DocumentType:             {0}", mrzCode[FieldType.DocumentType]);
            Console.WriteLine("CountryCode:              {0}", mrzCode[FieldType.CountryCode]);
            Console.WriteLine("DocumentNumber:           {0}", mrzCode[FieldType.DocumentNumber]);
            Console.WriteLine("DocumentNumberCheckDigit: {0}", mrzCode[FieldType.DocumentNumberCheckDigit]);
            Console.WriteLine("BirthDate:                {0}", mrzCode[FieldType.BirthDate]);
            Console.WriteLine("BirthDateCheckDigit:      {0}", mrzCode[FieldType.BirthDateCheckDigit]);
            Console.WriteLine("Sex:                      {0}", mrzCode[FieldType.Sex]);
            Console.WriteLine("ExpiryDate:               {0}", mrzCode[FieldType.ExpiryDate]);
            Console.WriteLine("ExpiryDateCheckDigit:     {0}", mrzCode[FieldType.ExpiryDateCheckDigit]);
            Console.WriteLine("Nationality:              {0}", mrzCode[FieldType.Nationality]);
            Console.WriteLine("OptionalData2:            {0}", mrzCode[FieldType.OptionalData2]);
            Console.WriteLine("OverallCheckDigit:        {0}", mrzCode[FieldType.OverallCheckDigit]);
            Console.WriteLine("Names:                    {0}", mrzCode[FieldType.Names]);

            Console.WriteLine();
        }
    }
}