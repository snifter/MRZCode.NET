# MRZCode.NET
MRZ (machine readable zone) parser for .NET. It supports following formats:
- TD1 (3 lines, each has 30 characters),
- TD2 (2 lines, each has 36 characters),
- TD3 (2 lines, each has 44 characters),
- MRVA (2 lines, each has 44 characters),
- MRVB (2 lines, each has 36 characters).

Implementation bases on regex patterns form [ultimateMRZ project](https://www.doubango.org/SDKs/mrz/docs/MRZ_parser.html).

# Samples
## Read a TD1 code

```C#
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
```

## Read a TD2 code

```C#
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
```

## Read a TD3 code

```C#
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
            Console.WriteLine("OptionalData2CheckDigit:  {0}", mrzCode[FieldType.OptionalData2CheckDigit]);
            Console.WriteLine("OverallCheckDigit:        {0}", mrzCode[FieldType.OverallCheckDigit]);
            
            Console.WriteLine();
        }
    }
```

## Read a MRVA code

```C#
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
```


## Read a MRVB code

```C#
    public class MRVBSample
    {
        public static void Run()
        {
            var text =  @"V<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<
L8988901C4XXX4009078F9612109<<<<<<<<";
            
            Console.WriteLine("MRVB code sample");
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
            
            var mrzCode = MrzCode.Parse(text);
            
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
```