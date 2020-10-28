using System;
using MRZCodeParser;

namespace MRZCode.Samples
{
    public class MRVASample
    {
        public static void Run()
        {
            var text = @"V<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<
L8988901C4XXX4009078F96121096ZE184226B<<<<<<";

            Console.WriteLine("MRVA code sample");
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

            Console.WriteLine();
        }
    }
}