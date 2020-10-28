using System;
using MRZCodeParser;

namespace MRZCode.Samples
{
    public static class GenericSample
    {
        public static void Run()
        {
            var codes = new[]
            {
                @"I<UTOD231458907<<<<<<<<<<<<<<<
7408122F1204159UTO<<<<<<<<<<<6
ERIKSSON<<ANNA<MARIA<<<<<<<<<<",
                @"I<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<
D231458907UTO7408122F1204159<<<<<<<6",
                @"P<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<
L898902C36UTO7408122F1204159ZE184226B<<<<<10",
                @"V<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<
L8988901C4XXX4009078F96121096ZE184226B<<<<<<",
                @"V<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<
L8988901C4XXX4009078F9612109<<<<<<<<"
            };

            Console.WriteLine("Parsing MRZ codes sample");
            foreach (var code in codes)
            {
                Console.WriteLine();
                Console.WriteLine(code);
                Console.WriteLine();
                
                var mrzCode = MrzCode.Parse(code);

                Console.WriteLine("Code type: {0}", mrzCode.Type);

                foreach (var fieldType in mrzCode.FieldTypes)
                {
                    Console.WriteLine("{0}: {1}", fieldType, mrzCode[fieldType]);    
                }
            }
        }
    }
}