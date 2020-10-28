using System;
using MRZCodeParser;

namespace MRZCode.Samples
{
    public class TD2Sample
    {
        public static void Run()
        {
            var text = @"I<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<
D231458907UTO7408122F1204159<<<<<<<6";

            Console.WriteLine("TD2 code sample");
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();

            var mrzCode = MrzCode.Parse(text);

            Console.WriteLine("Code type:                {0}", mrzCode.Type);

            Console.WriteLine("DocumentType:             {0}", mrzCode[FieldType.DocumentType]);
            Console.WriteLine("CountryCode:              {0}", mrzCode[FieldType.CountryCode]);
            Console.WriteLine("PrimaryIdentifier:        {0}", mrzCode[FieldType.PrimaryIdentifier]);
            Console.WriteLine("DocumentNumber:           {0}", mrzCode[FieldType.DocumentNumber]);
            Console.WriteLine("DocumentNumberCheckDigit: {0}", mrzCode[FieldType.DocumentNumberCheckDigit]);
            Console.WriteLine("Nationality:              {0}", mrzCode[FieldType.Nationality]);
            Console.WriteLine("BirthDate:                {0}", mrzCode[FieldType.BirthDate]);
            Console.WriteLine("BirthDateCheckDigit:      {0}", mrzCode[FieldType.BirthDateCheckDigit]);
            Console.WriteLine("Sex:                      {0}", mrzCode[FieldType.Sex]);
            Console.WriteLine("ExpiryDate:               {0}", mrzCode[FieldType.ExpiryDate]);
            Console.WriteLine("ExpiryDateCheckDigit:     {0}", mrzCode[FieldType.ExpiryDateCheckDigit]);
            Console.WriteLine("OptionalData2:            {0}", mrzCode[FieldType.OptionalData2]);
            Console.WriteLine("OverallCheckDigit:        {0}", mrzCode[FieldType.OverallCheckDigit]);

            Console.WriteLine();
        }
    }
}