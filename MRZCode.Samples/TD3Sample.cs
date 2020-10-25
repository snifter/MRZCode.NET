using System;
using MRZCodeParser;

namespace MRZCode.Samples
{
    public class TD3Sample
    {
        public static void Run()
        {
            var text = @"P<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<
L898902C36UTO7408122F1204159ZE184226B<<<<<10";
            
            Console.WriteLine("TD3 code sample");
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
            
            var mrzCode = MrzCode.Parse(text);
            
            Console.WriteLine("DocumentType:             {0}", mrzCode.Fields[FieldType.DocumentType].Value);
            Console.WriteLine("CountryCode:              {0}", mrzCode.Fields[FieldType.CountryCode].Value);
            Console.WriteLine("PrimaryIdentifier:        {0}", mrzCode.Fields[FieldType.PrimaryIdentifier].Value);
            Console.WriteLine("DocumentNumber:           {0}", mrzCode.Fields[FieldType.DocumentNumber].Value);
            Console.WriteLine("DocumentNumberCheckDigit: {0}", mrzCode.Fields[FieldType.DocumentNumberCheckDigit].Value);
            Console.WriteLine("Nationality:              {0}", mrzCode.Fields[FieldType.Nationality].Value);
            Console.WriteLine("BirthDate:                {0}", mrzCode.Fields[FieldType.BirthDate].Value);
            Console.WriteLine("BirthDateCheckDigit:      {0}", mrzCode.Fields[FieldType.BirthDateCheckDigit].Value);
            Console.WriteLine("Sex:                      {0}", mrzCode.Fields[FieldType.Sex].Value);
            Console.WriteLine("ExpiryDate:               {0}", mrzCode.Fields[FieldType.ExpiryDate].Value);
            Console.WriteLine("ExpiryDateCheckDigit:     {0}", mrzCode.Fields[FieldType.ExpiryDateCheckDigit].Value);
            Console.WriteLine("OptionalData2:            {0}", mrzCode.Fields[FieldType.OptionalData2].Value);
            Console.WriteLine("OptionalData2CheckDigit:  {0}", mrzCode.Fields[FieldType.OptionalData2CheckDigit].Value);
            Console.WriteLine("OverallCheckDigit:        {0}", mrzCode.Fields[FieldType.OverallCheckDigit].Value);
            
            Console.WriteLine();
        }
    }
}