namespace MRZCodeParser.Tests
{
    public static class MrzSamples
    {
        public const string TD1 = @"I<UTOD231458907<<<<<<<<<<<<<<<
7408122F1204159UTO<<<<<<<<<<<6
ERIKSSON<<ANNA<MARIA<<<<<<<<<<";
        
        public const string TD1_NO_EXPIRY_DATE = @"I<UTOD231458907<<<<<<<<<<<<<<<
7408122F<<<<<<0UTO<<<<<<<<<<<6
ERIKSSON<<ANNA<MARIA<<<<<<<<<<";

        public const string TD1_SINGLE_LETTER_COUNTRY_CODE = @"I<D<<D231458907<<<<<<<<<<<<<<<
7408122F1204159D<<<<<<<<<<<<<6
ERIKSSON<<ANNA<MARIA<<<<<<<<<<";

        public const string TD1_LONGER_DOCUMENT_ID = @"IDBEL111111111<5227<<<<<<<<<<<
7408122F2912207BEL110801555552
ERIKSSON<<ANNA<MARIA<<<<<<<<<<";

        public const string TD2 = @"I<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<
D231458907UTO7408122F1204159<<<<<<<6";

        public const string TD2_SINGLE_LETTER_COUNTRY_CODE = @"I<D<<ERIKSSON<<ANNA<MARIA<<<<<<<<<<<
D231458907D<<7408122F1204159<<<<<<<6";
        
        public const string TD2_NO_EXPIRY_DATE = @"I<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<
D231458907UTO7408122F<<<<<<0<<<<<<<6";

        public const string TD3 = @"P<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<
L898902C36UTO7408122F1204159ZE184226B<<<<<10";

        public const string TD3_SINGLE_LETTER_COUNTRY_CODE = @"P<D<<ERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<
L898902C36D<<7408122F1204159ZE184226B<<<<<10";

        public const string MRVA = @"V<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<<<<<<<<<
L8988901C4XXX4009078F96121096ZE184226B<<<<<<";

        public const string MRVB = @"V<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<<
L8988901C4XXX4009078F9612109<<<<<<<<";

        public const string UNKNOWN = @"V<UTOERIKSSON<<ANNA<MARIA<<<<<<<<<<
L8988901C4XXX4009078F9612109<<<<<<<";
    }
}