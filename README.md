# MRZCode.NET
MRZ (machine readable zone) parser for .NET. It supports following formats:
- TD1 (3 lines, each has 30 characters),
- TD2 (2 lines, each has 36 characters),
- TD3 (2 lines, each has 44 characters),
- MRVA (2 lines, each has 44 characters),
- MRVB (2 lines, each has 36 characters).

Implementation bases on regex patterns form [ultimateMRZ project](https://www.doubango.org/SDKs/mrz/docs/MRZ_parser.html).

# Samples

```C#
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
```

More samples you can find in MRZCode.Samples folder.

# Change log

## v. 0.5.0
Support for Belgium ID cards by [tPeif](https://github.com/tPeif)

## v. 0.4.0
Support for Moldavian ID cards with no expiration date by [itfintech](https://github.com/itfintech)

## v. 0.3.0
Support for German ID cards by [daniels7](https://github.com/daniels7)