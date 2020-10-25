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
            Console.WriteLine("OverallCheckDigit:        {0}", mrzCode.Fields[FieldType.OverallCheckDigit].Value);
            
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
            
            Console.WriteLine();
        }
    }
```