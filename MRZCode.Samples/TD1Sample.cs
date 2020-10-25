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
            
            Console.WriteLine("DocumentType:             {0}", mrzCode.Fields[FieldType.DocumentType].Value);
            Console.WriteLine("CountryCode:              {0}", mrzCode.Fields[FieldType.CountryCode].Value);
            Console.WriteLine("DocumentNumber:           {0}", mrzCode.Fields[FieldType.DocumentNumber].Value);
            Console.WriteLine("DocumentNumberCheckDigit: {0}", mrzCode.Fields[FieldType.DocumentNumberCheckDigit].Value);
            Console.WriteLine("BirthDate:                {0}", mrzCode.Fields[FieldType.BirthDate].Value);
            Console.WriteLine("BirthDateCheckDigit:      {0}", mrzCode.Fields[FieldType.BirthDateCheckDigit].Value);
            Console.WriteLine("Sex:                      {0}", mrzCode.Fields[FieldType.Sex].Value);
            Console.WriteLine("ExpiryDate:               {0}", mrzCode.Fields[FieldType.ExpiryDate].Value);
            Console.WriteLine("ExpiryDateCheckDigit:     {0}", mrzCode.Fields[FieldType.ExpiryDateCheckDigit].Value);
            Console.WriteLine("Nationality:              {0}", mrzCode.Fields[FieldType.Nationality].Value);
            Console.WriteLine("OptionalData2:            {0}", mrzCode.Fields[FieldType.OptionalData2].Value);
            Console.WriteLine("OverallCheckDigit:        {0}", mrzCode.Fields[FieldType.OverallCheckDigit].Value);
            Console.WriteLine("Names:                    {0}", mrzCode.Fields[FieldType.Names].Value);
            
            Console.WriteLine();
        }
    }
}