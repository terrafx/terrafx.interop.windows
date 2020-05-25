// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int ANYSIZE_ARRAY = 1;

        public const int ALL_PROCESSOR_GROUPS = 0xFFFF;

        public const uint APPLICATION_ERROR_MASK = 0x20000000;

        public const uint ERROR_SEVERITY_SUCCESS = 0x00000000;

        public const uint ERROR_SEVERITY_INFORMATIONAL = 0x40000000;

        public const uint ERROR_SEVERITY_WARNING = 0x80000000;

        public const uint ERROR_SEVERITY_ERROR = 0xC0000000;

        public const sbyte MINCHAR = unchecked((sbyte)0x80);

        public const sbyte MAXCHAR = 0x7F;

        public const short MINSHORT = unchecked((short)0x8000);

        public const short MAXSHORT = 0x7FFF;

        public const int MINLONG = unchecked((int)0x80000000);

        public const int MAXLONG = 0x7FFFFFFF;

        public const byte MAXBYTE = 0xFF;

        public const ushort MAXWORD = 0xFFFF;

        public const uint MAXDWORD = 0xFFFFFFFF;

        public const int ENCLAVE_SHORT_ID_LENGTH = 16;

        public const int ENCLAVE_LONG_ID_LENGTH = 32;

        public const uint VER_SERVER_NT = 0x80000000;

        public const uint VER_WORKSTATION_NT = 0x40000000;

        public const uint VER_SUITE_SMALLBUSINESS = 0x00000001;

        public const uint VER_SUITE_ENTERPRISE = 0x00000002;

        public const uint VER_SUITE_BACKOFFICE = 0x00000004;

        public const uint VER_SUITE_COMMUNICATIONS = 0x00000008;

        public const uint VER_SUITE_TERMINAL = 0x00000010;

        public const uint VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;

        public const uint VER_SUITE_EMBEDDEDNT = 0x00000040;

        public const uint VER_SUITE_DATACENTER = 0x00000080;

        public const uint VER_SUITE_SINGLEUSERTS = 0x00000100;

        public const uint VER_SUITE_PERSONAL = 0x00000200;

        public const uint VER_SUITE_BLADE = 0x00000400;

        public const uint VER_SUITE_EMBEDDED_RESTRICTED = 0x00000800;

        public const uint VER_SUITE_SECURITY_APPLIANCE = 0x00001000;

        public const uint VER_SUITE_STORAGE_SERVER = 0x00002000;

        public const uint VER_SUITE_COMPUTE_SERVER = 0x00004000;

        public const uint VER_SUITE_WH_SERVER = 0x00008000;

        public const uint VER_SUITE_MULTIUSERTS = 0x00020000;

        public const uint PRODUCT_UNDEFINED = 0x00000000;

        public const uint PRODUCT_ULTIMATE = 0x00000001;

        public const uint PRODUCT_HOME_BASIC = 0x00000002;

        public const uint PRODUCT_HOME_PREMIUM = 0x00000003;

        public const uint PRODUCT_ENTERPRISE = 0x00000004;

        public const uint PRODUCT_HOME_BASIC_N = 0x00000005;

        public const uint PRODUCT_BUSINESS = 0x00000006;

        public const uint PRODUCT_STANDARD_SERVER = 0x00000007;

        public const uint PRODUCT_DATACENTER_SERVER = 0x00000008;

        public const uint PRODUCT_SMALLBUSINESS_SERVER = 0x00000009;

        public const uint PRODUCT_ENTERPRISE_SERVER = 0x0000000A;

        public const uint PRODUCT_STARTER = 0x0000000B;

        public const uint PRODUCT_DATACENTER_SERVER_CORE = 0x0000000C;

        public const uint PRODUCT_STANDARD_SERVER_CORE = 0x0000000D;

        public const uint PRODUCT_ENTERPRISE_SERVER_CORE = 0x0000000E;

        public const uint PRODUCT_ENTERPRISE_SERVER_IA64 = 0x0000000F;

        public const uint PRODUCT_BUSINESS_N = 0x00000010;

        public const uint PRODUCT_WEB_SERVER = 0x00000011;

        public const uint PRODUCT_CLUSTER_SERVER = 0x00000012;

        public const uint PRODUCT_HOME_SERVER = 0x00000013;

        public const uint PRODUCT_STORAGE_EXPRESS_SERVER = 0x00000014;

        public const uint PRODUCT_STORAGE_STANDARD_SERVER = 0x00000015;

        public const uint PRODUCT_STORAGE_WORKGROUP_SERVER = 0x00000016;

        public const uint PRODUCT_STORAGE_ENTERPRISE_SERVER = 0x00000017;

        public const uint PRODUCT_SERVER_FOR_SMALLBUSINESS = 0x00000018;

        public const uint PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 0x00000019;

        public const uint PRODUCT_HOME_PREMIUM_N = 0x0000001A;

        public const uint PRODUCT_ENTERPRISE_N = 0x0000001B;

        public const uint PRODUCT_ULTIMATE_N = 0x0000001C;

        public const uint PRODUCT_WEB_SERVER_CORE = 0x0000001D;

        public const uint PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 0x0000001E;

        public const uint PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 0x0000001F;

        public const uint PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 0x00000020;

        public const uint PRODUCT_SERVER_FOUNDATION = 0x00000021;

        public const uint PRODUCT_HOME_PREMIUM_SERVER = 0x00000022;

        public const uint PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 0x00000023;

        public const uint PRODUCT_STANDARD_SERVER_V = 0x00000024;

        public const uint PRODUCT_DATACENTER_SERVER_V = 0x00000025;

        public const uint PRODUCT_ENTERPRISE_SERVER_V = 0x00000026;

        public const uint PRODUCT_DATACENTER_SERVER_CORE_V = 0x00000027;

        public const uint PRODUCT_STANDARD_SERVER_CORE_V = 0x00000028;

        public const uint PRODUCT_ENTERPRISE_SERVER_CORE_V = 0x00000029;

        public const uint PRODUCT_HYPERV = 0x0000002A;

        public const uint PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 0x0000002B;

        public const uint PRODUCT_STORAGE_STANDARD_SERVER_CORE = 0x0000002C;

        public const uint PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 0x0000002D;

        public const uint PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 0x0000002E;

        public const uint PRODUCT_STARTER_N = 0x0000002F;

        public const uint PRODUCT_PROFESSIONAL = 0x00000030;

        public const uint PRODUCT_PROFESSIONAL_N = 0x00000031;

        public const uint PRODUCT_SB_SOLUTION_SERVER = 0x00000032;

        public const uint PRODUCT_SERVER_FOR_SB_SOLUTIONS = 0x00000033;

        public const uint PRODUCT_STANDARD_SERVER_SOLUTIONS = 0x00000034;

        public const uint PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 0x00000035;

        public const uint PRODUCT_SB_SOLUTION_SERVER_EM = 0x00000036;

        public const uint PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 0x00000037;

        public const uint PRODUCT_SOLUTION_EMBEDDEDSERVER = 0x00000038;

        public const uint PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 0x00000039;

        public const uint PRODUCT_PROFESSIONAL_EMBEDDED = 0x0000003A;

        public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 0x0000003B;

        public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 0x0000003C;

        public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 0x0000003D;

        public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 0x0000003E;

        public const uint PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 0x0000003F;

        public const uint PRODUCT_CLUSTER_SERVER_V = 0x00000040;

        public const uint PRODUCT_EMBEDDED = 0x00000041;

        public const uint PRODUCT_STARTER_E = 0x00000042;

        public const uint PRODUCT_HOME_BASIC_E = 0x00000043;

        public const uint PRODUCT_HOME_PREMIUM_E = 0x00000044;

        public const uint PRODUCT_PROFESSIONAL_E = 0x00000045;

        public const uint PRODUCT_ENTERPRISE_E = 0x00000046;

        public const uint PRODUCT_ULTIMATE_E = 0x00000047;

        public const uint PRODUCT_ENTERPRISE_EVALUATION = 0x00000048;

        public const uint PRODUCT_MULTIPOINT_STANDARD_SERVER = 0x0000004C;

        public const uint PRODUCT_MULTIPOINT_PREMIUM_SERVER = 0x0000004D;

        public const uint PRODUCT_STANDARD_EVALUATION_SERVER = 0x0000004F;

        public const uint PRODUCT_DATACENTER_EVALUATION_SERVER = 0x00000050;

        public const uint PRODUCT_ENTERPRISE_N_EVALUATION = 0x00000054;

        public const uint PRODUCT_EMBEDDED_AUTOMOTIVE = 0x00000055;

        public const uint PRODUCT_EMBEDDED_INDUSTRY_A = 0x00000056;

        public const uint PRODUCT_THINPC = 0x00000057;

        public const uint PRODUCT_EMBEDDED_A = 0x00000058;

        public const uint PRODUCT_EMBEDDED_INDUSTRY = 0x00000059;

        public const uint PRODUCT_EMBEDDED_E = 0x0000005A;

        public const uint PRODUCT_EMBEDDED_INDUSTRY_E = 0x0000005B;

        public const uint PRODUCT_EMBEDDED_INDUSTRY_A_E = 0x0000005C;

        public const uint PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 0x0000005F;

        public const uint PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 0x00000060;

        public const uint PRODUCT_CORE_ARM = 0x00000061;

        public const uint PRODUCT_CORE_N = 0x00000062;

        public const uint PRODUCT_CORE_COUNTRYSPECIFIC = 0x00000063;

        public const uint PRODUCT_CORE_SINGLELANGUAGE = 0x00000064;

        public const uint PRODUCT_CORE = 0x00000065;

        public const uint PRODUCT_PROFESSIONAL_WMC = 0x00000067;

        public const uint PRODUCT_EMBEDDED_INDUSTRY_EVAL = 0x00000069;

        public const uint PRODUCT_EMBEDDED_INDUSTRY_E_EVAL = 0x0000006A;

        public const uint PRODUCT_EMBEDDED_EVAL = 0x0000006B;

        public const uint PRODUCT_EMBEDDED_E_EVAL = 0x0000006C;

        public const uint PRODUCT_NANO_SERVER = 0x0000006D;

        public const uint PRODUCT_CLOUD_STORAGE_SERVER = 0x0000006E;

        public const uint PRODUCT_CORE_CONNECTED = 0x0000006F;

        public const uint PRODUCT_PROFESSIONAL_STUDENT = 0x00000070;

        public const uint PRODUCT_CORE_CONNECTED_N = 0x00000071;

        public const uint PRODUCT_PROFESSIONAL_STUDENT_N = 0x00000072;

        public const uint PRODUCT_CORE_CONNECTED_SINGLELANGUAGE = 0x00000073;

        public const uint PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC = 0x00000074;

        public const uint PRODUCT_CONNECTED_CAR = 0x00000075;

        public const uint PRODUCT_INDUSTRY_HANDHELD = 0x00000076;

        public const uint PRODUCT_PPI_PRO = 0x00000077;

        public const uint PRODUCT_ARM64_SERVER = 0x00000078;

        public const uint PRODUCT_EDUCATION = 0x00000079;

        public const uint PRODUCT_EDUCATION_N = 0x0000007A;

        public const uint PRODUCT_IOTUAP = 0x0000007B;

        public const uint PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER = 0x0000007C;

        public const uint PRODUCT_ENTERPRISE_S = 0x0000007D;

        public const uint PRODUCT_ENTERPRISE_S_N = 0x0000007E;

        public const uint PRODUCT_PROFESSIONAL_S = 0x0000007F;

        public const uint PRODUCT_PROFESSIONAL_S_N = 0x00000080;

        public const uint PRODUCT_ENTERPRISE_S_EVALUATION = 0x00000081;

        public const uint PRODUCT_ENTERPRISE_S_N_EVALUATION = 0x00000082;

        public const uint PRODUCT_HOLOGRAPHIC = 0x00000087;

        public const uint PRODUCT_HOLOGRAPHIC_BUSINESS = 0x00000088;

        public const uint PRODUCT_PRO_SINGLE_LANGUAGE = 0x0000008A;

        public const uint PRODUCT_PRO_CHINA = 0x0000008B;

        public const uint PRODUCT_ENTERPRISE_SUBSCRIPTION = 0x0000008C;

        public const uint PRODUCT_ENTERPRISE_SUBSCRIPTION_N = 0x0000008D;

        public const uint PRODUCT_DATACENTER_NANO_SERVER = 0x0000008F;

        public const uint PRODUCT_STANDARD_NANO_SERVER = 0x00000090;

        public const uint PRODUCT_DATACENTER_A_SERVER_CORE = 0x00000091;

        public const uint PRODUCT_STANDARD_A_SERVER_CORE = 0x00000092;

        public const uint PRODUCT_DATACENTER_WS_SERVER_CORE = 0x00000093;

        public const uint PRODUCT_STANDARD_WS_SERVER_CORE = 0x00000094;

        public const uint PRODUCT_UTILITY_VM = 0x00000095;

        public const uint PRODUCT_DATACENTER_EVALUATION_SERVER_CORE = 0x0000009F;

        public const uint PRODUCT_STANDARD_EVALUATION_SERVER_CORE = 0x000000A0;

        public const uint PRODUCT_PRO_WORKSTATION = 0x000000A1;

        public const uint PRODUCT_PRO_WORKSTATION_N = 0x000000A2;

        public const uint PRODUCT_PRO_FOR_EDUCATION = 0x000000A4;

        public const uint PRODUCT_PRO_FOR_EDUCATION_N = 0x000000A5;

        public const uint PRODUCT_AZURE_SERVER_CORE = 0x000000A8;

        public const uint PRODUCT_AZURE_NANO_SERVER = 0x000000A9;

        public const uint PRODUCT_ENTERPRISEG = 0x000000AB;

        public const uint PRODUCT_ENTERPRISEGN = 0x000000AC;

        public const uint PRODUCT_SERVERRDSH = 0x000000AF;

        public const uint PRODUCT_CLOUD = 0x000000B2;

        public const uint PRODUCT_CLOUDN = 0x000000B3;

        public const uint PRODUCT_HUBOS = 0x000000B4;

        public const uint PRODUCT_ONECOREUPDATEOS = 0x000000B6;

        public const uint PRODUCT_CLOUDE = 0x000000B7;

        public const uint PRODUCT_ANDROMEDA = 0x000000B8;

        public const uint PRODUCT_IOTOS = 0x000000B9;

        public const uint PRODUCT_CLOUDEN = 0x000000BA;

        public const uint PRODUCT_IOTEDGEOS = 0x000000BB;

        public const uint PRODUCT_IOTENTERPRISE = 0x000000BC;

        public const uint PRODUCT_LITE = 0x000000BD;

        public const uint PRODUCT_IOTENTERPRISES = 0x000000BF;

        public const uint PRODUCT_UNLICENSED = 0xABCDABCD;

        public const int LANG_NEUTRAL = 0x00;

        public const int LANG_INVARIANT = 0x7F;

        public const int LANG_AFRIKAANS = 0x36;

        public const int LANG_ALBANIAN = 0x1C;

        public const int LANG_ALSATIAN = 0x84;

        public const int LANG_AMHARIC = 0x5E;

        public const int LANG_ARABIC = 0x01;

        public const int LANG_ARMENIAN = 0x2B;

        public const int LANG_ASSAMESE = 0x4D;

        public const int LANG_AZERI = 0x2C;

        public const int LANG_AZERBAIJANI = 0x2C;

        public const int LANG_BANGLA = 0x45;

        public const int LANG_BASHKIR = 0x6D;

        public const int LANG_BASQUE = 0x2D;

        public const int LANG_BELARUSIAN = 0x23;

        public const int LANG_BENGALI = 0x45;

        public const int LANG_BRETON = 0x7E;

        public const int LANG_BOSNIAN = 0x1A;

        public const int LANG_BOSNIAN_NEUTRAL = 0x781A;

        public const int LANG_BULGARIAN = 0x02;

        public const int LANG_CATALAN = 0x03;

        public const int LANG_CENTRAL_KURDISH = 0x92;

        public const int LANG_CHEROKEE = 0x5C;

        public const int LANG_CHINESE = 0x04;

        public const int LANG_CHINESE_SIMPLIFIED = 0x04;

        public const int LANG_CHINESE_TRADITIONAL = 0x7C04;

        public const int LANG_CORSICAN = 0x83;

        public const int LANG_CROATIAN = 0x1A;

        public const int LANG_CZECH = 0x05;

        public const int LANG_DANISH = 0x06;

        public const int LANG_DARI = 0x8C;

        public const int LANG_DIVEHI = 0x65;

        public const int LANG_DUTCH = 0x13;

        public const int LANG_ENGLISH = 0x09;

        public const int LANG_ESTONIAN = 0x25;

        public const int LANG_FAEROESE = 0x38;

        public const int LANG_FARSI = 0x29;

        public const int LANG_FILIPINO = 0x64;

        public const int LANG_FINNISH = 0x0B;

        public const int LANG_FRENCH = 0x0C;

        public const int LANG_FRISIAN = 0x62;

        public const int LANG_FULAH = 0x67;

        public const int LANG_GALICIAN = 0x56;

        public const int LANG_GEORGIAN = 0x37;

        public const int LANG_GERMAN = 0x07;

        public const int LANG_GREEK = 0x08;

        public const int LANG_GREENLANDIC = 0x6F;

        public const int LANG_GUJARATI = 0x47;

        public const int LANG_HAUSA = 0x68;

        public const int LANG_HAWAIIAN = 0x75;

        public const int LANG_HEBREW = 0x0D;

        public const int LANG_HINDI = 0x39;

        public const int LANG_HUNGARIAN = 0x0E;

        public const int LANG_ICELANDIC = 0x0F;

        public const int LANG_IGBO = 0x70;

        public const int LANG_INDONESIAN = 0x21;

        public const int LANG_INUKTITUT = 0x5D;

        public const int LANG_IRISH = 0x3C;

        public const int LANG_ITALIAN = 0x10;

        public const int LANG_JAPANESE = 0x11;

        public const int LANG_KANNADA = 0x4B;

        public const int LANG_KASHMIRI = 0x60;

        public const int LANG_KAZAK = 0x3F;

        public const int LANG_KHMER = 0x53;

        public const int LANG_KICHE = 0x86;

        public const int LANG_KINYARWANDA = 0x87;

        public const int LANG_KONKANI = 0x57;

        public const int LANG_KOREAN = 0x12;

        public const int LANG_KYRGYZ = 0x40;

        public const int LANG_LAO = 0x54;

        public const int LANG_LATVIAN = 0x26;

        public const int LANG_LITHUANIAN = 0x27;

        public const int LANG_LOWER_SORBIAN = 0x2E;

        public const int LANG_LUXEMBOURGISH = 0x6E;

        public const int LANG_MACEDONIAN = 0x2F;

        public const int LANG_MALAY = 0x3E;

        public const int LANG_MALAYALAM = 0x4C;

        public const int LANG_MALTESE = 0x3A;

        public const int LANG_MANIPURI = 0x58;

        public const int LANG_MAORI = 0x81;

        public const int LANG_MAPUDUNGUN = 0x7A;

        public const int LANG_MARATHI = 0x4E;

        public const int LANG_MOHAWK = 0x7C;

        public const int LANG_MONGOLIAN = 0x50;

        public const int LANG_NEPALI = 0x61;

        public const int LANG_NORWEGIAN = 0x14;

        public const int LANG_OCCITAN = 0x82;

        public const int LANG_ODIA = 0x48;

        public const int LANG_ORIYA = 0x48;

        public const int LANG_PASHTO = 0x63;

        public const int LANG_PERSIAN = 0x29;

        public const int LANG_POLISH = 0x15;

        public const int LANG_PORTUGUESE = 0x16;

        public const int LANG_PULAR = 0x67;

        public const int LANG_PUNJABI = 0x46;

        public const int LANG_QUECHUA = 0x6B;

        public const int LANG_ROMANIAN = 0x18;

        public const int LANG_ROMANSH = 0x17;

        public const int LANG_RUSSIAN = 0x19;

        public const int LANG_SAKHA = 0x85;

        public const int LANG_SAMI = 0x3B;

        public const int LANG_SANSKRIT = 0x4F;

        public const int LANG_SCOTTISH_GAELIC = 0x91;

        public const int LANG_SERBIAN = 0x1A;

        public const int LANG_SERBIAN_NEUTRAL = 0x7C1A;

        public const int LANG_SINDHI = 0x59;

        public const int LANG_SINHALESE = 0x5B;

        public const int LANG_SLOVAK = 0x1B;

        public const int LANG_SLOVENIAN = 0x24;

        public const int LANG_SOTHO = 0x6C;

        public const int LANG_SPANISH = 0x0A;

        public const int LANG_SWAHILI = 0x41;

        public const int LANG_SWEDISH = 0x1D;

        public const int LANG_SYRIAC = 0x5A;

        public const int LANG_TAJIK = 0x28;

        public const int LANG_TAMAZIGHT = 0x5F;

        public const int LANG_TAMIL = 0x49;

        public const int LANG_TATAR = 0x44;

        public const int LANG_TELUGU = 0x4A;

        public const int LANG_THAI = 0x1E;

        public const int LANG_TIBETAN = 0x51;

        public const int LANG_TIGRIGNA = 0x73;

        public const int LANG_TIGRINYA = 0x73;

        public const int LANG_TSWANA = 0x32;

        public const int LANG_TURKISH = 0x1F;

        public const int LANG_TURKMEN = 0x42;

        public const int LANG_UIGHUR = 0x80;

        public const int LANG_UKRAINIAN = 0x22;

        public const int LANG_UPPER_SORBIAN = 0x2E;

        public const int LANG_URDU = 0x20;

        public const int LANG_UZBEK = 0x43;

        public const int LANG_VALENCIAN = 0x03;

        public const int LANG_VIETNAMESE = 0x2A;

        public const int LANG_WELSH = 0x52;

        public const int LANG_WOLOF = 0x88;

        public const int LANG_XHOSA = 0x34;

        public const int LANG_YAKUT = 0x85;

        public const int LANG_YI = 0x78;

        public const int LANG_YORUBA = 0x6A;

        public const int LANG_ZULU = 0x35;

        public const int SUBLANG_NEUTRAL = 0x00;

        public const int SUBLANG_DEFAULT = 0x01;

        public const int SUBLANG_SYS_DEFAULT = 0x02;

        public const int SUBLANG_CUSTOM_DEFAULT = 0x03;

        public const int SUBLANG_CUSTOM_UNSPECIFIED = 0x04;

        public const int SUBLANG_UI_CUSTOM_DEFAULT = 0x05;

        public const int SUBLANG_AFRIKAANS_SOUTH_AFRICA = 0x01;

        public const int SUBLANG_ALBANIAN_ALBANIA = 0x01;

        public const int SUBLANG_ALSATIAN_FRANCE = 0x01;

        public const int SUBLANG_AMHARIC_ETHIOPIA = 0x01;

        public const int SUBLANG_ARABIC_SAUDI_ARABIA = 0x01;

        public const int SUBLANG_ARABIC_IRAQ = 0x02;

        public const int SUBLANG_ARABIC_EGYPT = 0x03;

        public const int SUBLANG_ARABIC_LIBYA = 0x04;

        public const int SUBLANG_ARABIC_ALGERIA = 0x05;

        public const int SUBLANG_ARABIC_MOROCCO = 0x06;

        public const int SUBLANG_ARABIC_TUNISIA = 0x07;

        public const int SUBLANG_ARABIC_OMAN = 0x08;

        public const int SUBLANG_ARABIC_YEMEN = 0x09;

        public const int SUBLANG_ARABIC_SYRIA = 0x0A;

        public const int SUBLANG_ARABIC_JORDAN = 0x0B;

        public const int SUBLANG_ARABIC_LEBANON = 0x0C;

        public const int SUBLANG_ARABIC_KUWAIT = 0x0D;

        public const int SUBLANG_ARABIC_UAE = 0x0E;

        public const int SUBLANG_ARABIC_BAHRAIN = 0x0F;

        public const int SUBLANG_ARABIC_QATAR = 0x10;

        public const int SUBLANG_ARMENIAN_ARMENIA = 0x01;

        public const int SUBLANG_ASSAMESE_INDIA = 0x01;

        public const int SUBLANG_AZERI_LATIN = 0x01;

        public const int SUBLANG_AZERI_CYRILLIC = 0x02;

        public const int SUBLANG_AZERBAIJANI_AZERBAIJAN_LATIN = 0x01;

        public const int SUBLANG_AZERBAIJANI_AZERBAIJAN_CYRILLIC = 0x02;

        public const int SUBLANG_BANGLA_INDIA = 0x01;

        public const int SUBLANG_BANGLA_BANGLADESH = 0x02;

        public const int SUBLANG_BASHKIR_RUSSIA = 0x01;

        public const int SUBLANG_BASQUE_BASQUE = 0x01;

        public const int SUBLANG_BELARUSIAN_BELARUS = 0x01;

        public const int SUBLANG_BENGALI_INDIA = 0x01;

        public const int SUBLANG_BENGALI_BANGLADESH = 0x02;

        public const int SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_LATIN = 0x05;

        public const int SUBLANG_BOSNIAN_BOSNIA_HERZEGOVINA_CYRILLIC = 0x08;

        public const int SUBLANG_BRETON_FRANCE = 0x01;

        public const int SUBLANG_BULGARIAN_BULGARIA = 0x01;

        public const int SUBLANG_CATALAN_CATALAN = 0x01;

        public const int SUBLANG_CENTRAL_KURDISH_IRAQ = 0x01;

        public const int SUBLANG_CHEROKEE_CHEROKEE = 0x01;

        public const int SUBLANG_CHINESE_TRADITIONAL = 0x01;

        public const int SUBLANG_CHINESE_SIMPLIFIED = 0x02;

        public const int SUBLANG_CHINESE_HONGKONG = 0x03;

        public const int SUBLANG_CHINESE_SINGAPORE = 0x04;

        public const int SUBLANG_CHINESE_MACAU = 0x05;

        public const int SUBLANG_CORSICAN_FRANCE = 0x01;

        public const int SUBLANG_CZECH_CZECH_REPUBLIC = 0x01;

        public const int SUBLANG_CROATIAN_CROATIA = 0x01;

        public const int SUBLANG_CROATIAN_BOSNIA_HERZEGOVINA_LATIN = 0x04;

        public const int SUBLANG_DANISH_DENMARK = 0x01;

        public const int SUBLANG_DARI_AFGHANISTAN = 0x01;

        public const int SUBLANG_DIVEHI_MALDIVES = 0x01;

        public const int SUBLANG_DUTCH = 0x01;

        public const int SUBLANG_DUTCH_BELGIAN = 0x02;

        public const int SUBLANG_ENGLISH_US = 0x01;

        public const int SUBLANG_ENGLISH_UK = 0x02;

        public const int SUBLANG_ENGLISH_AUS = 0x03;

        public const int SUBLANG_ENGLISH_CAN = 0x04;

        public const int SUBLANG_ENGLISH_NZ = 0x05;

        public const int SUBLANG_ENGLISH_EIRE = 0x06;

        public const int SUBLANG_ENGLISH_SOUTH_AFRICA = 0x07;

        public const int SUBLANG_ENGLISH_JAMAICA = 0x08;

        public const int SUBLANG_ENGLISH_CARIBBEAN = 0x09;

        public const int SUBLANG_ENGLISH_BELIZE = 0x0A;

        public const int SUBLANG_ENGLISH_TRINIDAD = 0x0B;

        public const int SUBLANG_ENGLISH_ZIMBABWE = 0x0C;

        public const int SUBLANG_ENGLISH_PHILIPPINES = 0x0D;

        public const int SUBLANG_ENGLISH_INDIA = 0x10;

        public const int SUBLANG_ENGLISH_MALAYSIA = 0x11;

        public const int SUBLANG_ENGLISH_SINGAPORE = 0x12;

        public const int SUBLANG_ESTONIAN_ESTONIA = 0x01;

        public const int SUBLANG_FAEROESE_FAROE_ISLANDS = 0x01;

        public const int SUBLANG_FILIPINO_PHILIPPINES = 0x01;

        public const int SUBLANG_FINNISH_FINLAND = 0x01;

        public const int SUBLANG_FRENCH = 0x01;

        public const int SUBLANG_FRENCH_BELGIAN = 0x02;

        public const int SUBLANG_FRENCH_CANADIAN = 0x03;

        public const int SUBLANG_FRENCH_SWISS = 0x04;

        public const int SUBLANG_FRENCH_LUXEMBOURG = 0x05;

        public const int SUBLANG_FRENCH_MONACO = 0x06;

        public const int SUBLANG_FRISIAN_NETHERLANDS = 0x01;

        public const int SUBLANG_FULAH_SENEGAL = 0x02;

        public const int SUBLANG_GALICIAN_GALICIAN = 0x01;

        public const int SUBLANG_GEORGIAN_GEORGIA = 0x01;

        public const int SUBLANG_GERMAN = 0x01;

        public const int SUBLANG_GERMAN_SWISS = 0x02;

        public const int SUBLANG_GERMAN_AUSTRIAN = 0x03;

        public const int SUBLANG_GERMAN_LUXEMBOURG = 0x04;

        public const int SUBLANG_GERMAN_LIECHTENSTEIN = 0x05;

        public const int SUBLANG_GREEK_GREECE = 0x01;

        public const int SUBLANG_GREENLANDIC_GREENLAND = 0x01;

        public const int SUBLANG_GUJARATI_INDIA = 0x01;

        public const int SUBLANG_HAUSA_NIGERIA_LATIN = 0x01;

        public const int SUBLANG_HAWAIIAN_US = 0x01;

        public const int SUBLANG_HEBREW_ISRAEL = 0x01;

        public const int SUBLANG_HINDI_INDIA = 0x01;

        public const int SUBLANG_HUNGARIAN_HUNGARY = 0x01;

        public const int SUBLANG_ICELANDIC_ICELAND = 0x01;

        public const int SUBLANG_IGBO_NIGERIA = 0x01;

        public const int SUBLANG_INDONESIAN_INDONESIA = 0x01;

        public const int SUBLANG_INUKTITUT_CANADA = 0x01;

        public const int SUBLANG_INUKTITUT_CANADA_LATIN = 0x02;

        public const int SUBLANG_IRISH_IRELAND = 0x02;

        public const int SUBLANG_ITALIAN = 0x01;

        public const int SUBLANG_ITALIAN_SWISS = 0x02;

        public const int SUBLANG_JAPANESE_JAPAN = 0x01;

        public const int SUBLANG_KANNADA_INDIA = 0x01;

        public const int SUBLANG_KASHMIRI_SASIA = 0x02;

        public const int SUBLANG_KASHMIRI_INDIA = 0x02;

        public const int SUBLANG_KAZAK_KAZAKHSTAN = 0x01;

        public const int SUBLANG_KHMER_CAMBODIA = 0x01;

        public const int SUBLANG_KICHE_GUATEMALA = 0x01;

        public const int SUBLANG_KINYARWANDA_RWANDA = 0x01;

        public const int SUBLANG_KONKANI_INDIA = 0x01;

        public const int SUBLANG_KOREAN = 0x01;

        public const int SUBLANG_KYRGYZ_KYRGYZSTAN = 0x01;

        public const int SUBLANG_LAO_LAO = 0x01;

        public const int SUBLANG_LATVIAN_LATVIA = 0x01;

        public const int SUBLANG_LITHUANIAN = 0x01;

        public const int SUBLANG_LOWER_SORBIAN_GERMANY = 0x02;

        public const int SUBLANG_LUXEMBOURGISH_LUXEMBOURG = 0x01;

        public const int SUBLANG_MACEDONIAN_MACEDONIA = 0x01;

        public const int SUBLANG_MALAY_MALAYSIA = 0x01;

        public const int SUBLANG_MALAY_BRUNEI_DARUSSALAM = 0x02;

        public const int SUBLANG_MALAYALAM_INDIA = 0x01;

        public const int SUBLANG_MALTESE_MALTA = 0x01;

        public const int SUBLANG_MAORI_NEW_ZEALAND = 0x01;

        public const int SUBLANG_MAPUDUNGUN_CHILE = 0x01;

        public const int SUBLANG_MARATHI_INDIA = 0x01;

        public const int SUBLANG_MOHAWK_MOHAWK = 0x01;

        public const int SUBLANG_MONGOLIAN_CYRILLIC_MONGOLIA = 0x01;

        public const int SUBLANG_MONGOLIAN_PRC = 0x02;

        public const int SUBLANG_NEPALI_INDIA = 0x02;

        public const int SUBLANG_NEPALI_NEPAL = 0x01;

        public const int SUBLANG_NORWEGIAN_BOKMAL = 0x01;

        public const int SUBLANG_NORWEGIAN_NYNORSK = 0x02;

        public const int SUBLANG_OCCITAN_FRANCE = 0x01;

        public const int SUBLANG_ODIA_INDIA = 0x01;

        public const int SUBLANG_ORIYA_INDIA = 0x01;

        public const int SUBLANG_PASHTO_AFGHANISTAN = 0x01;

        public const int SUBLANG_PERSIAN_IRAN = 0x01;

        public const int SUBLANG_POLISH_POLAND = 0x01;

        public const int SUBLANG_PORTUGUESE = 0x02;

        public const int SUBLANG_PORTUGUESE_BRAZILIAN = 0x01;

        public const int SUBLANG_PULAR_SENEGAL = 0x02;

        public const int SUBLANG_PUNJABI_INDIA = 0x01;

        public const int SUBLANG_PUNJABI_PAKISTAN = 0x02;

        public const int SUBLANG_QUECHUA_BOLIVIA = 0x01;

        public const int SUBLANG_QUECHUA_ECUADOR = 0x02;

        public const int SUBLANG_QUECHUA_PERU = 0x03;

        public const int SUBLANG_ROMANIAN_ROMANIA = 0x01;

        public const int SUBLANG_ROMANSH_SWITZERLAND = 0x01;

        public const int SUBLANG_RUSSIAN_RUSSIA = 0x01;

        public const int SUBLANG_SAKHA_RUSSIA = 0x01;

        public const int SUBLANG_SAMI_NORTHERN_NORWAY = 0x01;

        public const int SUBLANG_SAMI_NORTHERN_SWEDEN = 0x02;

        public const int SUBLANG_SAMI_NORTHERN_FINLAND = 0x03;

        public const int SUBLANG_SAMI_LULE_NORWAY = 0x04;

        public const int SUBLANG_SAMI_LULE_SWEDEN = 0x05;

        public const int SUBLANG_SAMI_SOUTHERN_NORWAY = 0x06;

        public const int SUBLANG_SAMI_SOUTHERN_SWEDEN = 0x07;

        public const int SUBLANG_SAMI_SKOLT_FINLAND = 0x08;

        public const int SUBLANG_SAMI_INARI_FINLAND = 0x09;

        public const int SUBLANG_SANSKRIT_INDIA = 0x01;

        public const int SUBLANG_SCOTTISH_GAELIC = 0x01;

        public const int SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_LATIN = 0x06;

        public const int SUBLANG_SERBIAN_BOSNIA_HERZEGOVINA_CYRILLIC = 0x07;

        public const int SUBLANG_SERBIAN_MONTENEGRO_LATIN = 0x0B;

        public const int SUBLANG_SERBIAN_MONTENEGRO_CYRILLIC = 0x0C;

        public const int SUBLANG_SERBIAN_SERBIA_LATIN = 0x09;

        public const int SUBLANG_SERBIAN_SERBIA_CYRILLIC = 0x0A;

        public const int SUBLANG_SERBIAN_CROATIA = 0x01;

        public const int SUBLANG_SERBIAN_LATIN = 0x02;

        public const int SUBLANG_SERBIAN_CYRILLIC = 0x03;

        public const int SUBLANG_SINDHI_INDIA = 0x01;

        public const int SUBLANG_SINDHI_PAKISTAN = 0x02;

        public const int SUBLANG_SINDHI_AFGHANISTAN = 0x02;

        public const int SUBLANG_SINHALESE_SRI_LANKA = 0x01;

        public const int SUBLANG_SOTHO_NORTHERN_SOUTH_AFRICA = 0x01;

        public const int SUBLANG_SLOVAK_SLOVAKIA = 0x01;

        public const int SUBLANG_SLOVENIAN_SLOVENIA = 0x01;

        public const int SUBLANG_SPANISH = 0x01;

        public const int SUBLANG_SPANISH_MEXICAN = 0x02;

        public const int SUBLANG_SPANISH_MODERN = 0x03;

        public const int SUBLANG_SPANISH_GUATEMALA = 0x04;

        public const int SUBLANG_SPANISH_COSTA_RICA = 0x05;

        public const int SUBLANG_SPANISH_PANAMA = 0x06;

        public const int SUBLANG_SPANISH_DOMINICAN_REPUBLIC = 0x07;

        public const int SUBLANG_SPANISH_VENEZUELA = 0x08;

        public const int SUBLANG_SPANISH_COLOMBIA = 0x09;

        public const int SUBLANG_SPANISH_PERU = 0x0A;

        public const int SUBLANG_SPANISH_ARGENTINA = 0x0B;

        public const int SUBLANG_SPANISH_ECUADOR = 0x0C;

        public const int SUBLANG_SPANISH_CHILE = 0x0D;

        public const int SUBLANG_SPANISH_URUGUAY = 0x0E;

        public const int SUBLANG_SPANISH_PARAGUAY = 0x0F;

        public const int SUBLANG_SPANISH_BOLIVIA = 0x10;

        public const int SUBLANG_SPANISH_EL_SALVADOR = 0x11;

        public const int SUBLANG_SPANISH_HONDURAS = 0x12;

        public const int SUBLANG_SPANISH_NICARAGUA = 0x13;

        public const int SUBLANG_SPANISH_PUERTO_RICO = 0x14;

        public const int SUBLANG_SPANISH_US = 0x15;

        public const int SUBLANG_SWAHILI_KENYA = 0x01;

        public const int SUBLANG_SWEDISH = 0x01;

        public const int SUBLANG_SWEDISH_FINLAND = 0x02;

        public const int SUBLANG_SYRIAC_SYRIA = 0x01;

        public const int SUBLANG_TAJIK_TAJIKISTAN = 0x01;

        public const int SUBLANG_TAMAZIGHT_ALGERIA_LATIN = 0x02;

        public const int SUBLANG_TAMAZIGHT_MOROCCO_TIFINAGH = 0x04;

        public const int SUBLANG_TAMIL_INDIA = 0x01;

        public const int SUBLANG_TAMIL_SRI_LANKA = 0x02;

        public const int SUBLANG_TATAR_RUSSIA = 0x01;

        public const int SUBLANG_TELUGU_INDIA = 0x01;

        public const int SUBLANG_THAI_THAILAND = 0x01;

        public const int SUBLANG_TIBETAN_PRC = 0x01;

        public const int SUBLANG_TIGRIGNA_ERITREA = 0x02;

        public const int SUBLANG_TIGRINYA_ERITREA = 0x02;

        public const int SUBLANG_TIGRINYA_ETHIOPIA = 0x01;

        public const int SUBLANG_TSWANA_BOTSWANA = 0x02;

        public const int SUBLANG_TSWANA_SOUTH_AFRICA = 0x01;

        public const int SUBLANG_TURKISH_TURKEY = 0x01;

        public const int SUBLANG_TURKMEN_TURKMENISTAN = 0x01;

        public const int SUBLANG_UIGHUR_PRC = 0x01;

        public const int SUBLANG_UKRAINIAN_UKRAINE = 0x01;

        public const int SUBLANG_UPPER_SORBIAN_GERMANY = 0x01;

        public const int SUBLANG_URDU_PAKISTAN = 0x01;

        public const int SUBLANG_URDU_INDIA = 0x02;

        public const int SUBLANG_UZBEK_LATIN = 0x01;

        public const int SUBLANG_UZBEK_CYRILLIC = 0x02;

        public const int SUBLANG_VALENCIAN_VALENCIA = 0x02;

        public const int SUBLANG_VIETNAMESE_VIETNAM = 0x01;

        public const int SUBLANG_WELSH_UNITED_KINGDOM = 0x01;

        public const int SUBLANG_WOLOF_SENEGAL = 0x01;

        public const int SUBLANG_XHOSA_SOUTH_AFRICA = 0x01;

        public const int SUBLANG_YAKUT_RUSSIA = 0x01;

        public const int SUBLANG_YI_PRC = 0x01;

        public const int SUBLANG_YORUBA_NIGERIA = 0x01;

        public const int SUBLANG_ZULU_SOUTH_AFRICA = 0x01;

        public const int SORT_DEFAULT = 0x0;

        public const int SORT_INVARIANT_MATH = 0x1;

        public const int SORT_JAPANESE_XJIS = 0x0;

        public const int SORT_JAPANESE_UNICODE = 0x1;

        public const int SORT_JAPANESE_RADICALSTROKE = 0x4;

        public const int SORT_CHINESE_BIG5 = 0x0;

        public const int SORT_CHINESE_PRCP = 0x0;

        public const int SORT_CHINESE_UNICODE = 0x1;

        public const int SORT_CHINESE_PRC = 0x2;

        public const int SORT_CHINESE_BOPOMOFO = 0x3;

        public const int SORT_CHINESE_RADICALSTROKE = 0x4;

        public const int SORT_KOREAN_KSC = 0x0;

        public const int SORT_KOREAN_UNICODE = 0x1;

        public const int SORT_GERMAN_PHONE_BOOK = 0x1;

        public const int SORT_HUNGARIAN_DEFAULT = 0x0;

        public const int SORT_HUNGARIAN_TECHNICAL = 0x1;

        public const int SORT_GEORGIAN_TRADITIONAL = 0x0;

        public const int SORT_GEORGIAN_MODERN = 0x1;

        public const int NLS_VALID_LOCALE_MASK = 0x000FFFFF;

        public const int LOCALE_NAME_MAX_LENGTH = 85;

        public const int LOCALE_TRANSIENT_KEYBOARD1 = 0x2000;

        public const int LOCALE_TRANSIENT_KEYBOARD2 = 0x2400;

        public const int LOCALE_TRANSIENT_KEYBOARD3 = 0x2800;

        public const int LOCALE_TRANSIENT_KEYBOARD4 = 0x2C00;

        public const int MAXIMUM_WAIT_OBJECTS = 64;

        public const int MAXIMUM_SUPPORTED_EXTENSION = 512;

        public const int WOW64_CONTEXT_i386 = 0x00010000;

        public const int WOW64_CONTEXT_i486 = 0x00010000;

        public const int WOW64_CONTEXT_EXCEPTION_ACTIVE = 0x08000000;

        public const int WOW64_CONTEXT_SERVICE_ACTIVE = 0x10000000;

        public const int WOW64_CONTEXT_EXCEPTION_REQUEST = 0x40000000;

        public const uint WOW64_CONTEXT_EXCEPTION_REPORTING = 0x80000000;

        public const int WOW64_SIZE_OF_80387_REGISTERS = 80;

        public const int WOW64_MAXIMUM_SUPPORTED_EXTENSION = 512;

        public const int EXCEPTION_NONCONTINUABLE = 0x1;

        public const int EXCEPTION_UNWINDING = 0x2;

        public const int EXCEPTION_EXIT_UNWIND = 0x4;

        public const int EXCEPTION_STACK_INVALID = 0x8;

        public const int EXCEPTION_NESTED_CALL = 0x10;

        public const int EXCEPTION_TARGET_UNWIND = 0x20;

        public const int EXCEPTION_COLLIDED_UNWIND = 0x40;

        public const int EXCEPTION_MAXIMUM_PARAMETERS = 15;

        public const int SID_HASH_SIZE = 32;

        public const uint SECURITY_TRUSTED_INSTALLER_RID1 = 956008885;

        public const uint SECURITY_TRUSTED_INSTALLER_RID2 = 3418522649;

        public const uint SECURITY_TRUSTED_INSTALLER_RID3 = 1831038044;

        public const uint SECURITY_TRUSTED_INSTALLER_RID4 = 1853292631;

        public const uint SECURITY_TRUSTED_INSTALLER_RID5 = 2271478464;

        public const int SYSTEM_MANDATORY_LABEL_NO_WRITE_UP = 0x1;

        public const int SYSTEM_MANDATORY_LABEL_NO_READ_UP = 0x2;

        public const int SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP = 0x4;

        public const uint SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK = 0x00FFFFFF;

        public const uint SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK = 0xFFFFFFFF;

        public const uint SYSTEM_ACCESS_FILTER_VALID_MASK = 0x00FFFFFF;

        public const uint SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK = 0xFFFFFFFF;

        public const int ACE_OBJECT_TYPE_PRESENT = 0x1;

        public const int ACE_INHERITED_OBJECT_TYPE_PRESENT = 0x2;

        public const int ACCESS_OBJECT_GUID = 0;

        public const int ACCESS_PROPERTY_SET_GUID = 1;

        public const int ACCESS_PROPERTY_GUID = 2;

        public const int ACCESS_MAX_LEVEL = 4;

        public const int AUDIT_ALLOW_NO_PRIVILEGE = 0x1;

        // DS
        public static ReadOnlySpan<sbyte> ACCESS_DS_SOURCE_A => new sbyte[] { 0x44, 0x53, 0x00 };

        public const string ACCESS_DS_SOURCE_W = "DS";

        // Directory Service Object
        public static ReadOnlySpan<sbyte> ACCESS_DS_OBJECT_TYPE_NAME_A => new sbyte[] { 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x20, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x20, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        public const string ACCESS_DS_OBJECT_TYPE_NAME_W = "Directory Service Object";

        public const uint ACCESS_REASON_TYPE_MASK = 0x00FF0000;

        public const uint ACCESS_REASON_DATA_MASK = 0x0000FFFF;

        public const uint ACCESS_REASON_STAGING_MASK = 0x80000000;

        public const uint ACCESS_REASON_EXDATA_MASK = 0x7F000000;

        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_OWNER_ACE = 0x00000001;

        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_LABEL_ACE = 0x00000002;

        public const int SE_SECURITY_DESCRIPTOR_FLAG_NO_ACCESS_FILTER_ACE = 0x00000004;

        public const int SE_SECURITY_DESCRIPTOR_VALID_FLAGS = 0x00000007;

        public const int SE_ACCESS_CHECK_FLAG_NO_LEARNING_MODE_LOGGING = 0x00000008;

        public const int SE_ACCESS_CHECK_VALID_FLAGS = 0x00000008;

        public const string SE_ACTIVATE_AS_USER_CAPABILITY = "activateAsUser";

        public const string SE_CONSTRAINED_IMPERSONATION_CAPABILITY = "constrainedImpersonation";

        public const string SE_SESSION_IMPERSONATION_CAPABILITY = "sessionImpersonation";

        public const string SE_MUMA_CAPABILITY = "muma";

        public const string SE_DEVELOPMENT_MODE_NETWORK_CAPABILITY = "developmentModeNetwork";

        public const int TOKEN_MANDATORY_POLICY_OFF = 0x0;

        public const int TOKEN_MANDATORY_POLICY_NO_WRITE_UP = 0x1;

        public const int TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN = 0x2;

        public const int TOKEN_SOURCE_LENGTH = 8;

        public const uint CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID = 0x00;

        public const uint CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 = 0x01;

        public const uint CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 = 0x02;

        public const uint CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING = 0x03;

        public const uint CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN = 0x04;

        public const uint CLAIM_SECURITY_ATTRIBUTE_TYPE_SID = 0x05;

        public const uint CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = 0x06;

        public const uint CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = 0x10;

        public const uint CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE = 0x0001;

        public const uint CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = 0x0002;

        public const uint CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY = 0x0004;

        public const uint CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT = 0x0008;

        public const uint CLAIM_SECURITY_ATTRIBUTE_DISABLED = 0x0010;

        public const uint CLAIM_SECURITY_ATTRIBUTE_MANDATORY = 0x0020;

        public const uint CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS = 0xFFFF0000;

        public const ushort CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 = 1;

        public const int DISABLE_MAX_PRIVILEGE = 0x1;

        public const int SANDBOX_INERT = 0x2;

        public const int LUA_TOKEN = 0x4;

        public const int WRITE_RESTRICTED = 0x8;

        public const byte SE_SIGNING_LEVEL_UNCHECKED = 0x00000000;

        public const byte SE_SIGNING_LEVEL_UNSIGNED = 0x00000001;

        public const byte SE_SIGNING_LEVEL_ENTERPRISE = 0x00000002;

        public const byte SE_SIGNING_LEVEL_CUSTOM_1 = 0x00000003;

        public const byte SE_SIGNING_LEVEL_AUTHENTICODE = 0x00000004;

        public const byte SE_SIGNING_LEVEL_CUSTOM_2 = 0x00000005;

        public const byte SE_SIGNING_LEVEL_STORE = 0x00000006;

        public const byte SE_SIGNING_LEVEL_CUSTOM_3 = 0x00000007;

        public const byte SE_SIGNING_LEVEL_MICROSOFT = 0x00000008;

        public const byte SE_SIGNING_LEVEL_CUSTOM_4 = 0x00000009;

        public const byte SE_SIGNING_LEVEL_CUSTOM_5 = 0x0000000A;

        public const byte SE_SIGNING_LEVEL_DYNAMIC_CODEGEN = 0x0000000B;

        public const byte SE_SIGNING_LEVEL_WINDOWS = 0x0000000C;

        public const byte SE_SIGNING_LEVEL_CUSTOM_7 = 0x0000000D;

        public const byte SE_SIGNING_LEVEL_WINDOWS_TCB = 0x0000000E;

        public const byte SE_SIGNING_LEVEL_CUSTOM_6 = 0x0000000F;

        public const int SE_LEARNING_MODE_FLAG_PERMISSIVE = 0x00000001;

        public const int FLS_MAXIMUM_AVAILABLE = 4080;

        public const int TLS_MINIMUM_AVAILABLE = 64;

        public const int THREAD_DYNAMIC_CODE_ALLOW = 1;

        public const int THREAD_BASE_PRIORITY_LOWRT = 15;

        public const int THREAD_BASE_PRIORITY_MAX = 2;

        public const int MEMORY_PRIORITY_LOWEST = 0;

        public const int MEMORY_PRIORITY_VERY_LOW = 1;

        public const int MEMORY_PRIORITY_LOW = 2;

        public const int MEMORY_PRIORITY_MEDIUM = 3;

        public const int MEMORY_PRIORITY_BELOW_NORMAL = 4;

        public const int MEMORY_PRIORITY_NORMAL = 5;

        public const int QUOTA_LIMITS_HARDWS_MIN_ENABLE = 0x00000001;

        public const int QUOTA_LIMITS_HARDWS_MIN_DISABLE = 0x00000002;

        public const int QUOTA_LIMITS_HARDWS_MAX_ENABLE = 0x00000004;

        public const int QUOTA_LIMITS_HARDWS_MAX_DISABLE = 0x00000008;

        public const int QUOTA_LIMITS_USE_DEFAULT_LIMITS = 0x00000010;

        public const int MAX_HW_COUNTERS = 16;

        public const int THREAD_PROFILING_FLAG_DISPATCH = 0x00000001;

        public const int JOB_OBJECT_NET_RATE_CONTROL_MAX_DSCP_TAG = 64;

        public const int JOB_OBJECT_TERMINATE_AT_END_OF_JOB = 0;

        public const int JOB_OBJECT_POST_AT_END_OF_JOB = 1;

        public const int JOB_OBJECT_MSG_END_OF_JOB_TIME = 1;

        public const int JOB_OBJECT_MSG_END_OF_PROCESS_TIME = 2;

        public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT = 3;

        public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO = 4;

        public const int JOB_OBJECT_MSG_NEW_PROCESS = 6;

        public const int JOB_OBJECT_MSG_EXIT_PROCESS = 7;

        public const int JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS = 8;

        public const int JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT = 9;

        public const int JOB_OBJECT_MSG_JOB_MEMORY_LIMIT = 10;

        public const int JOB_OBJECT_MSG_NOTIFICATION_LIMIT = 11;

        public const int JOB_OBJECT_MSG_JOB_CYCLE_TIME_LIMIT = 12;

        public const int JOB_OBJECT_MSG_SILO_TERMINATED = 13;

        public const int JOB_OBJECT_MSG_MINIMUM = 1;

        public const int JOB_OBJECT_MSG_MAXIMUM = 13;

        public const int JOB_OBJECT_LIMIT_WORKINGSET = 0x00000001;

        public const int JOB_OBJECT_LIMIT_PROCESS_TIME = 0x00000002;

        public const int JOB_OBJECT_LIMIT_JOB_TIME = 0x00000004;

        public const int JOB_OBJECT_LIMIT_ACTIVE_PROCESS = 0x00000008;

        public const int JOB_OBJECT_LIMIT_AFFINITY = 0x00000010;

        public const int JOB_OBJECT_LIMIT_PRIORITY_CLASS = 0x00000020;

        public const int JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = 0x00000040;

        public const int JOB_OBJECT_LIMIT_SCHEDULING_CLASS = 0x00000080;

        public const int JOB_OBJECT_LIMIT_PROCESS_MEMORY = 0x00000100;

        public const int JOB_OBJECT_LIMIT_JOB_MEMORY = 0x00000200;

        public const int JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = 0x00000400;

        public const int JOB_OBJECT_LIMIT_BREAKAWAY_OK = 0x00000800;

        public const int JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = 0x00001000;

        public const int JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 0x00002000;

        public const int JOB_OBJECT_LIMIT_SUBSET_AFFINITY = 0x00004000;

        public const int JOB_OBJECT_LIMIT_JOB_MEMORY_LOW = 0x00008000;

        public const int JOB_OBJECT_LIMIT_JOB_READ_BYTES = 0x00010000;

        public const int JOB_OBJECT_LIMIT_JOB_WRITE_BYTES = 0x00020000;

        public const int JOB_OBJECT_LIMIT_RATE_CONTROL = 0x00040000;

        public const int JOB_OBJECT_LIMIT_IO_RATE_CONTROL = 0x00080000;

        public const int JOB_OBJECT_LIMIT_NET_RATE_CONTROL = 0x00100000;

        public const int JOB_OBJECT_LIMIT_VALID_FLAGS = 0x0007FFFF;

        public const int JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS = 0x000000FF;

        public const int JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS = 0x00007FFF;

        public const int JOB_OBJECT_UILIMIT_NONE = 0x00000000;

        public const int JOB_OBJECT_UILIMIT_HANDLES = 0x00000001;

        public const int JOB_OBJECT_UILIMIT_READCLIPBOARD = 0x00000002;

        public const int JOB_OBJECT_UILIMIT_WRITECLIPBOARD = 0x00000004;

        public const int JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS = 0x00000008;

        public const int JOB_OBJECT_UILIMIT_DISPLAYSETTINGS = 0x00000010;

        public const int JOB_OBJECT_UILIMIT_GLOBALATOMS = 0x00000020;

        public const int JOB_OBJECT_UILIMIT_DESKTOP = 0x00000040;

        public const int JOB_OBJECT_UILIMIT_EXITWINDOWS = 0x00000080;

        public const int JOB_OBJECT_UILIMIT_ALL = 0x000000FF;

        public const int JOB_OBJECT_UI_VALID_FLAGS = 0x000000FF;

        public const int JOB_OBJECT_SECURITY_NO_ADMIN = 0x00000001;

        public const int JOB_OBJECT_SECURITY_RESTRICTED_TOKEN = 0x00000002;

        public const int JOB_OBJECT_SECURITY_ONLY_TOKEN = 0x00000004;

        public const int JOB_OBJECT_SECURITY_FILTER_TOKENS = 0x00000008;

        public const int JOB_OBJECT_SECURITY_VALID_FLAGS = 0x0000000F;

        public const int JOB_OBJECT_CPU_RATE_CONTROL_ENABLE = 0x1;

        public const int JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED = 0x2;

        public const int JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP = 0x4;

        public const int JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY = 0x8;

        public const int JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE = 0x10;

        public const int JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS = 0x1F;

        public const int EVENT_MODIFY_STATE = 0x0002;

        public const int MUTANT_QUERY_STATE = 0x0001;

        public const int SEMAPHORE_MODIFY_STATE = 0x0002;

        public const int TIMER_QUERY_STATE = 0x0001;

        public const int TIMER_MODIFY_STATE = 0x0002;

        public const int TIME_ZONE_ID_UNKNOWN = 0;

        public const int TIME_ZONE_ID_STANDARD = 1;

        public const int TIME_ZONE_ID_DAYLIGHT = 2;

        public const int LTP_PC_SMT = 0x1;

        public const int CACHE_FULLY_ASSOCIATIVE = 0xFF;

        public const int SYSTEM_CPU_SET_INFORMATION_PARKED = 0x1;

        public const int SYSTEM_CPU_SET_INFORMATION_ALLOCATED = 0x2;

        public const int SYSTEM_CPU_SET_INFORMATION_ALLOCATED_TO_TARGET_PROCESS = 0x4;

        public const int SYSTEM_CPU_SET_INFORMATION_REALTIME = 0x8;

        public const int PROCESSOR_INTEL_386 = 386;

        public const int PROCESSOR_INTEL_486 = 486;

        public const int PROCESSOR_INTEL_PENTIUM = 586;

        public const int PROCESSOR_INTEL_IA64 = 2200;

        public const int PROCESSOR_AMD_X8664 = 8664;

        public const int PROCESSOR_MIPS_R4000 = 4000;

        public const int PROCESSOR_ALPHA_21064 = 21064;

        public const int PROCESSOR_PPC_601 = 601;

        public const int PROCESSOR_PPC_603 = 603;

        public const int PROCESSOR_PPC_604 = 604;

        public const int PROCESSOR_PPC_620 = 620;

        public const int PROCESSOR_HITACHI_SH3 = 10003;

        public const int PROCESSOR_HITACHI_SH3E = 10004;

        public const int PROCESSOR_HITACHI_SH4 = 10005;

        public const int PROCESSOR_MOTOROLA_821 = 821;

        public const int PROCESSOR_SHx_SH3 = 103;

        public const int PROCESSOR_SHx_SH4 = 104;

        public const int PROCESSOR_STRONGARM = 2577;

        public const int PROCESSOR_ARM720 = 1824;

        public const int PROCESSOR_ARM820 = 2080;

        public const int PROCESSOR_ARM920 = 2336;

        public const int PROCESSOR_ARM_7TDMI = 70001;

        public const int PROCESSOR_OPTIL = 0x494F;

        public const int PROCESSOR_ARCHITECTURE_INTEL = 0;

        public const int PROCESSOR_ARCHITECTURE_MIPS = 1;

        public const int PROCESSOR_ARCHITECTURE_ALPHA = 2;

        public const int PROCESSOR_ARCHITECTURE_PPC = 3;

        public const int PROCESSOR_ARCHITECTURE_SHX = 4;

        public const int PROCESSOR_ARCHITECTURE_ARM = 5;

        public const int PROCESSOR_ARCHITECTURE_IA64 = 6;

        public const int PROCESSOR_ARCHITECTURE_ALPHA64 = 7;

        public const int PROCESSOR_ARCHITECTURE_MSIL = 8;

        public const int PROCESSOR_ARCHITECTURE_AMD64 = 9;

        public const int PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 = 10;

        public const int PROCESSOR_ARCHITECTURE_NEUTRAL = 11;

        public const int PROCESSOR_ARCHITECTURE_ARM64 = 12;

        public const int PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64 = 13;

        public const int PROCESSOR_ARCHITECTURE_IA32_ON_ARM64 = 14;

        public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF;

        public const int PF_FLOATING_POINT_PRECISION_ERRATA = 0;

        public const int PF_FLOATING_POINT_EMULATED = 1;

        public const int PF_COMPARE_EXCHANGE_DOUBLE = 2;

        public const int PF_MMX_INSTRUCTIONS_AVAILABLE = 3;

        public const int PF_PPC_MOVEMEM_64BIT_OK = 4;

        public const int PF_ALPHA_BYTE_INSTRUCTIONS = 5;

        public const int PF_XMMI_INSTRUCTIONS_AVAILABLE = 6;

        public const int PF_3DNOW_INSTRUCTIONS_AVAILABLE = 7;

        public const int PF_RDTSC_INSTRUCTION_AVAILABLE = 8;

        public const int PF_PAE_ENABLED = 9;

        public const int PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10;

        public const int PF_SSE_DAZ_MODE_AVAILABLE = 11;

        public const int PF_NX_ENABLED = 12;

        public const int PF_SSE3_INSTRUCTIONS_AVAILABLE = 13;

        public const int PF_COMPARE_EXCHANGE128 = 14;

        public const int PF_COMPARE64_EXCHANGE128 = 15;

        public const int PF_CHANNELS_ENABLED = 16;

        public const int PF_XSAVE_ENABLED = 17;

        public const int PF_ARM_VFP_32_REGISTERS_AVAILABLE = 18;

        public const int PF_ARM_NEON_INSTRUCTIONS_AVAILABLE = 19;

        public const int PF_SECOND_LEVEL_ADDRESS_TRANSLATION = 20;

        public const int PF_VIRT_FIRMWARE_ENABLED = 21;

        public const int PF_RDWRFSGSBASE_AVAILABLE = 22;

        public const int PF_FASTFAIL_AVAILABLE = 23;

        public const int PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE = 24;

        public const int PF_ARM_64BIT_LOADSTORE_ATOMIC = 25;

        public const int PF_ARM_EXTERNAL_CACHE_AVAILABLE = 26;

        public const int PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE = 27;

        public const int PF_RDRAND_INSTRUCTION_AVAILABLE = 28;

        public const int PF_ARM_V8_INSTRUCTIONS_AVAILABLE = 29;

        public const int PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE = 30;

        public const int PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE = 31;

        public const int PF_RDTSCP_INSTRUCTION_AVAILABLE = 32;

        public const int PF_RDPID_INSTRUCTION_AVAILABLE = 33;

        public const int PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE = 34;

        public const int PF_MONITORX_INSTRUCTION_AVAILABLE = 35;

        public const int SECTION_QUERY = 0x0001;

        public const int SECTION_MAP_WRITE = 0x0002;

        public const int SECTION_MAP_READ = 0x0004;

        public const int SECTION_MAP_EXECUTE = 0x0008;

        public const int SECTION_EXTEND_SIZE = 0x0010;

        public const int SECTION_MAP_EXECUTE_EXPLICIT = 0x0020;

        public const uint SESSION_QUERY_ACCESS = 0x0001;

        public const uint SESSION_MODIFY_ACCESS = 0x0002;

        public const uint PAGE_NOACCESS = 0x01;

        public const uint PAGE_READONLY = 0x02;

        public const uint PAGE_READWRITE = 0x04;

        public const uint PAGE_WRITECOPY = 0x08;

        public const uint PAGE_EXECUTE = 0x10;

        public const uint PAGE_EXECUTE_READ = 0x20;

        public const uint PAGE_EXECUTE_READWRITE = 0x40;

        public const uint PAGE_EXECUTE_WRITECOPY = 0x80;

        public const uint PAGE_GUARD = 0x100;

        public const uint PAGE_NOCACHE = 0x200;

        public const uint PAGE_WRITECOMBINE = 0x400;

        public const uint PAGE_GRAPHICS_NOACCESS = 0x0800;

        public const uint PAGE_GRAPHICS_READONLY = 0x1000;

        public const uint PAGE_GRAPHICS_READWRITE = 0x2000;

        public const uint PAGE_GRAPHICS_EXECUTE = 0x4000;

        public const uint PAGE_GRAPHICS_EXECUTE_READ = 0x8000;

        public const uint PAGE_GRAPHICS_EXECUTE_READWRITE = 0x10000;

        public const uint PAGE_GRAPHICS_COHERENT = 0x20000;

        public const uint PAGE_ENCLAVE_THREAD_CONTROL = 0x80000000;

        public const uint PAGE_REVERT_TO_FILE_MAP = 0x80000000;

        public const uint PAGE_TARGETS_NO_UPDATE = 0x40000000;

        public const uint PAGE_TARGETS_INVALID = 0x40000000;

        public const uint PAGE_ENCLAVE_UNVALIDATED = 0x20000000;

        public const uint PAGE_ENCLAVE_DECOMMIT = 0x10000000;

        public const uint MEM_COMMIT = 0x00001000;

        public const uint MEM_RESERVE = 0x00002000;

        public const uint MEM_REPLACE_PLACEHOLDER = 0x00004000;

        public const uint MEM_RESERVE_PLACEHOLDER = 0x00040000;

        public const uint MEM_RESET = 0x00080000;

        public const uint MEM_TOP_DOWN = 0x00100000;

        public const uint MEM_WRITE_WATCH = 0x00200000;

        public const uint MEM_PHYSICAL = 0x00400000;

        public const uint MEM_ROTATE = 0x00800000;

        public const uint MEM_DIFFERENT_IMAGE_BASE_OK = 0x00800000;

        public const uint MEM_RESET_UNDO = 0x01000000;

        public const uint MEM_LARGE_PAGES = 0x20000000;

        public const uint MEM_4MB_PAGES = 0x80000000;

        public const uint MEM_UNMAP_WITH_TRANSIENT_BOOST = 0x00000001;

        public const uint MEM_COALESCE_PLACEHOLDERS = 0x00000001;

        public const uint MEM_PRESERVE_PLACEHOLDER = 0x00000002;

        public const uint MEM_DECOMMIT = 0x00004000;

        public const uint MEM_RELEASE = 0x00008000;

        public const uint MEM_FREE = 0x00010000;

        public const int MEM_EXTENDED_PARAMETER_GRAPHICS = 0x00000001;

        public const int MEM_EXTENDED_PARAMETER_NONPAGED = 0x00000002;

        public const int MEM_EXTENDED_PARAMETER_ZERO_PAGES_OPTIONAL = 0x00000004;

        public const int MEM_EXTENDED_PARAMETER_NONPAGED_LARGE = 0x00000008;

        public const int MEM_EXTENDED_PARAMETER_NONPAGED_HUGE = 0x00000010;

        public const int MEM_EXTENDED_PARAMETER_TYPE_BITS = 8;

        public const uint SEC_PARTITION_OWNER_HANDLE = 0x00040000;

        public const uint SEC_64K_PAGES = 0x00080000;

        public const uint SEC_FILE = 0x00800000;

        public const uint SEC_IMAGE = 0x01000000;

        public const uint SEC_PROTECTED_IMAGE = 0x02000000;

        public const uint SEC_RESERVE = 0x04000000;

        public const uint SEC_COMMIT = 0x08000000;

        public const uint SEC_NOCACHE = 0x10000000;

        public const uint SEC_WRITECOMBINE = 0x40000000;

        public const uint SEC_LARGE_PAGES = 0x80000000;

        public const uint MEM_PRIVATE = 0x00020000;

        public const uint MEM_MAPPED = 0x00040000;

        public const uint MEM_IMAGE = 0x01000000;

        public const int WRITE_WATCH_FLAG_RESET = 0x01;

        public const int ENCLAVE_TYPE_SGX = 0x00000001;

        public const int ENCLAVE_TYPE_SGX2 = 0x00000002;

        public const int ENCLAVE_TYPE_VBS = 0x00000010;

        public const int ENCLAVE_VBS_FLAG_DEBUG = 0x00000001;

        public const int ENCLAVE_TYPE_VBS_BASIC = 0x00000011;

        public const int VBS_BASIC_PAGE_MEASURED_DATA = 0x00000001;

        public const int VBS_BASIC_PAGE_UNMEASURED_DATA = 0x00000002;

        public const int VBS_BASIC_PAGE_ZERO_FILL = 0x00000003;

        public const int VBS_BASIC_PAGE_THREAD_DESCRIPTOR = 0x00000004;

        public const int VBS_BASIC_PAGE_SYSTEM_CALL = 0x00000005;

        public const uint FILE_SHARE_READ = 0x00000001;

        public const uint FILE_SHARE_WRITE = 0x00000002;

        public const uint FILE_SHARE_DELETE = 0x00000004;

        public const uint FILE_ATTRIBUTE_READONLY = 0x00000001;

        public const uint FILE_ATTRIBUTE_HIDDEN = 0x00000002;

        public const uint FILE_ATTRIBUTE_SYSTEM = 0x00000004;

        public const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;

        public const uint FILE_ATTRIBUTE_ARCHIVE = 0x00000020;

        public const uint FILE_ATTRIBUTE_DEVICE = 0x00000040;

        public const uint FILE_ATTRIBUTE_NORMAL = 0x00000080;

        public const uint FILE_ATTRIBUTE_TEMPORARY = 0x00000100;

        public const uint FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200;

        public const uint FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400;

        public const uint FILE_ATTRIBUTE_COMPRESSED = 0x00000800;

        public const uint FILE_ATTRIBUTE_OFFLINE = 0x00001000;

        public const uint FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000;

        public const uint FILE_ATTRIBUTE_ENCRYPTED = 0x00004000;

        public const uint FILE_ATTRIBUTE_INTEGRITY_STREAM = 0x00008000;

        public const uint FILE_ATTRIBUTE_VIRTUAL = 0x00010000;

        public const uint FILE_ATTRIBUTE_NO_SCRUB_DATA = 0x00020000;

        public const uint FILE_ATTRIBUTE_EA = 0x00040000;

        public const uint FILE_ATTRIBUTE_PINNED = 0x00080000;

        public const uint FILE_ATTRIBUTE_UNPINNED = 0x00100000;

        public const uint FILE_ATTRIBUTE_RECALL_ON_OPEN = 0x00040000;

        public const uint FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS = 0x00400000;

        public const uint TREE_CONNECT_ATTRIBUTE_PRIVACY = 0x00004000;

        public const uint TREE_CONNECT_ATTRIBUTE_INTEGRITY = 0x00008000;

        public const uint TREE_CONNECT_ATTRIBUTE_GLOBAL = 0x00000004;

        public const uint TREE_CONNECT_ATTRIBUTE_PINNED = 0x00000002;

        public const uint FILE_ATTRIBUTE_STRICTLY_SEQUENTIAL = 0x20000000;

        public const uint FILE_NOTIFY_CHANGE_FILE_NAME = 0x00000001;

        public const uint FILE_NOTIFY_CHANGE_DIR_NAME = 0x00000002;

        public const uint FILE_NOTIFY_CHANGE_ATTRIBUTES = 0x00000004;

        public const uint FILE_NOTIFY_CHANGE_SIZE = 0x00000008;

        public const uint FILE_NOTIFY_CHANGE_LAST_WRITE = 0x00000010;

        public const uint FILE_NOTIFY_CHANGE_LAST_ACCESS = 0x00000020;

        public const uint FILE_NOTIFY_CHANGE_CREATION = 0x00000040;

        public const uint FILE_NOTIFY_CHANGE_SECURITY = 0x00000100;

        public const uint FILE_ACTION_ADDED = 0x00000001;

        public const uint FILE_ACTION_REMOVED = 0x00000002;

        public const uint FILE_ACTION_MODIFIED = 0x00000003;

        public const uint FILE_ACTION_RENAMED_OLD_NAME = 0x00000004;

        public const uint FILE_ACTION_RENAMED_NEW_NAME = 0x00000005;

        public const uint FILE_CASE_SENSITIVE_SEARCH = 0x00000001;

        public const uint FILE_CASE_PRESERVED_NAMES = 0x00000002;

        public const uint FILE_UNICODE_ON_DISK = 0x00000004;

        public const uint FILE_PERSISTENT_ACLS = 0x00000008;

        public const uint FILE_FILE_COMPRESSION = 0x00000010;

        public const uint FILE_VOLUME_QUOTAS = 0x00000020;

        public const uint FILE_SUPPORTS_SPARSE_FILES = 0x00000040;

        public const uint FILE_SUPPORTS_REPARSE_POINTS = 0x00000080;

        public const uint FILE_SUPPORTS_REMOTE_STORAGE = 0x00000100;

        public const uint FILE_RETURNS_CLEANUP_RESULT_INFO = 0x00000200;

        public const uint FILE_SUPPORTS_POSIX_UNLINK_RENAME = 0x00000400;

        public const uint FILE_VOLUME_IS_COMPRESSED = 0x00008000;

        public const uint FILE_SUPPORTS_OBJECT_IDS = 0x00010000;

        public const uint FILE_SUPPORTS_ENCRYPTION = 0x00020000;

        public const uint FILE_NAMED_STREAMS = 0x00040000;

        public const uint FILE_READ_ONLY_VOLUME = 0x00080000;

        public const uint FILE_SEQUENTIAL_WRITE_ONCE = 0x00100000;

        public const uint FILE_SUPPORTS_TRANSACTIONS = 0x00200000;

        public const uint FILE_SUPPORTS_HARD_LINKS = 0x00400000;

        public const uint FILE_SUPPORTS_EXTENDED_ATTRIBUTES = 0x00800000;

        public const uint FILE_SUPPORTS_OPEN_BY_FILE_ID = 0x01000000;

        public const uint FILE_SUPPORTS_USN_JOURNAL = 0x02000000;

        public const uint FILE_SUPPORTS_uintEGRITY_STREAMS = 0x04000000;

        public const uint FILE_SUPPORTS_BLOCK_REFCOUNTING = 0x08000000;

        public const uint FILE_SUPPORTS_SPARSE_VDL = 0x10000000;

        public const uint FILE_DAX_VOLUME = 0x20000000;

        public const uint FILE_SUPPORTS_GHOSTING = 0x40000000;

        public const uint FILE_CS_FLAG_CASE_SENSITIVE_DIR = 0x00000001;

        public const int FLUSH_FLAGS_FILE_DATA_ONLY = 0x00000001;

        public const int FLUSH_FLAGS_NO_SYNC = 0x00000002;

        public const int FLUSH_FLAGS_FILE_DATA_SYNC_ONLY = 0x00000004;

        public const int SCRUB_DATA_INPUT_FLAG_RESUME = 0x00000001;

        public const int SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC = 0x00000002;

        public const int SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA = 0x00000004;

        public const int SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY = 0x00000008;

        public const int SCRUB_DATA_INPUT_FLAG_SKIP_DATA = 0x00000010;

        public const int SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID = 0x00000020;

        public const int SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE = 0x00000001;

        public const int SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE = 0x00010000;

        public const int SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED = 0x00020000;

        public const int SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED = 0x00040000;

        public const int IO_COMPLETION_MODIFY_STATE = 0x0002;

        public const ulong IO_QOS_MAX_RESERVATION = 1000000000;

        // ClusteredApplicationInstance
        public static ReadOnlySpan<sbyte> SMB_CCF_APP_INSTANCE_EA_NAME => new sbyte[] { 0x43, 0x6C, 0x75, 0x73, 0x74, 0x65, 0x72, 0x65, 0x64, 0x41, 0x70, 0x70, 0x6C, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x49, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65, 0x00 };

        public const int NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR = 0x00000001;

        public const int DUPLICATE_CLOSE_SOURCE = 0x00000001;

        public const int DUPLICATE_SAME_ACCESS = 0x00000002;

        public const int POWERBUTTON_ACTION_INDEX_NOTHING = 0;

        public const int POWERBUTTON_ACTION_INDEX_SLEEP = 1;

        public const int POWERBUTTON_ACTION_INDEX_HIBERNATE = 2;

        public const int POWERBUTTON_ACTION_INDEX_SHUTDOWN = 3;

        public const int POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY = 4;

        public const int POWERBUTTON_ACTION_VALUE_NOTHING = 0;

        public const int POWERBUTTON_ACTION_VALUE_SLEEP = 2;

        public const int POWERBUTTON_ACTION_VALUE_HIBERNATE = 3;

        public const int POWERBUTTON_ACTION_VALUE_SHUTDOWN = 6;

        public const int POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY = 8;

        public const int PERFSTATE_POLICY_CHANGE_IDEAL = 0;

        public const int PERFSTATE_POLICY_CHANGE_SINGLE = 1;

        public const int PERFSTATE_POLICY_CHANGE_ROCKET = 2;

        public const int PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE = 3;

        public const int PROCESSOR_THROTTLE_DISABLED = 0;

        public const int PROCESSOR_THROTTLE_ENABLED = 1;

        public const int PROCESSOR_THROTTLE_AUTOMATIC = 2;

        public const int PROCESSOR_PERF_BOOST_POLICY_DISABLED = 0;

        public const int PROCESSOR_PERF_BOOST_POLICY_MAX = 100;

        public const int PROCESSOR_PERF_BOOST_MODE_DISABLED = 0;

        public const int PROCESSOR_PERF_BOOST_MODE_ENABLED = 1;

        public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE = 2;

        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED = 3;

        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE = 4;

        public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED = 5;

        public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED = 6;

        public const int PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED = 0;

        public const int PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED = 1;

        public const int PROCESSOR_PERF_PERFORMANCE_PREFERENCE = 0xFF;

        public const int PROCESSOR_PERF_ENERGY_PREFERENCE = 0;

        public const int PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW = 0;

        public const int PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW = 1270000000;

        public const int PROCESSOR_DUTY_CYCLING_DISABLED = 0;

        public const int PROCESSOR_DUTY_CYCLING_ENABLED = 1;

        public const int CORE_PARKING_POLICY_CHANGE_IDEAL = 0;

        public const int CORE_PARKING_POLICY_CHANGE_SINGLE = 1;

        public const int CORE_PARKING_POLICY_CHANGE_ROCKET = 2;

        public const int CORE_PARKING_POLICY_CHANGE_MULTISTEP = 3;

        public const int POWER_DEVICE_IDLE_POLICY_PERFORMANCE = 0;

        public const int POWER_DEVICE_IDLE_POLICY_CONSERVATIVE = 1;

        public const int POWER_CONNECTIVITY_IN_STANDBY_DISABLED = 0;

        public const int POWER_CONNECTIVITY_IN_STANDBY_ENABLED = 1;

        public const int POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED = 2;

        public const int POWER_DISCONNECTED_STANDBY_MODE_NORMAL = 0;

        public const int POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE = 1;

        public const int POWER_SYSTEM_MAXIMUM = 7;

        public const uint DIAGNOSTIC_REASON_VERSION = 0;

        public const uint DIAGNOSTIC_REASON_SIMPLE_STRING = 0x00000001;

        public const uint DIAGNOSTIC_REASON_DETAILED_STRING = 0x00000002;

        public const uint DIAGNOSTIC_REASON_NOT_SPECIFIED = 0x80000000;

        public const int PDCAP_D0_SUPPORTED = 0x00000001;

        public const int PDCAP_D1_SUPPORTED = 0x00000002;

        public const int PDCAP_D2_SUPPORTED = 0x00000004;

        public const int PDCAP_D3_SUPPORTED = 0x00000008;

        public const int PDCAP_WAKE_FROM_D0_SUPPORTED = 0x00000010;

        public const int PDCAP_WAKE_FROM_D1_SUPPORTED = 0x00000020;

        public const int PDCAP_WAKE_FROM_D2_SUPPORTED = 0x00000040;

        public const int PDCAP_WAKE_FROM_D3_SUPPORTED = 0x00000080;

        public const int PDCAP_WARM_EJECT_SUPPORTED = 0x00000100;

        public const int PROC_IDLE_BUCKET_COUNT = 6;

        public const int PROC_IDLE_BUCKET_COUNT_EX = 16;

        public const int ACPI_PPM_SOFTWARE_ALL = 0xFC;

        public const int ACPI_PPM_SOFTWARE_ANY = 0xFD;

        public const int ACPI_PPM_HARDWARE_ALL = 0xFE;

        public const int MS_PPM_SOFTWARE_ALL = 0x1;

        public const int PPM_FIRMWARE_ACPI1C2 = 0x00000001;

        public const int PPM_FIRMWARE_ACPI1C3 = 0x00000002;

        public const int PPM_FIRMWARE_ACPI1TSTATES = 0x00000004;

        public const int PPM_FIRMWARE_CST = 0x00000008;

        public const int PPM_FIRMWARE_CSD = 0x00000010;

        public const int PPM_FIRMWARE_PCT = 0x00000020;

        public const int PPM_FIRMWARE_PSS = 0x00000040;

        public const int PPM_FIRMWARE_XPSS = 0x00000080;

        public const int PPM_FIRMWARE_PPC = 0x00000100;

        public const int PPM_FIRMWARE_PSD = 0x00000200;

        public const int PPM_FIRMWARE_PTC = 0x00000400;

        public const int PPM_FIRMWARE_TSS = 0x00000800;

        public const int PPM_FIRMWARE_TPC = 0x00001000;

        public const int PPM_FIRMWARE_TSD = 0x00002000;

        public const int PPM_FIRMWARE_PCCH = 0x00004000;

        public const int PPM_FIRMWARE_PCCP = 0x00008000;

        public const int PPM_FIRMWARE_OSC = 0x00010000;

        public const int PPM_FIRMWARE_PDC = 0x00020000;

        public const int PPM_FIRMWARE_CPC = 0x00040000;

        public const int PPM_FIRMWARE_LPI = 0x00080000;

        public const int PPM_PERFORMANCE_IMPLEMENTATION_NONE = 0x00000000;

        public const int PPM_PERFORMANCE_IMPLEMENTATION_PSTATES = 0x00000001;

        public const int PPM_PERFORMANCE_IMPLEMENTATION_PCCV1 = 0x00000002;

        public const int PPM_PERFORMANCE_IMPLEMENTATION_CPPC = 0x00000003;

        public const int PPM_PERFORMANCE_IMPLEMENTATION_PEP = 0x00000004;

        public const int PPM_IDLE_IMPLEMENTATION_NONE = 0x00000000;

        public const int PPM_IDLE_IMPLEMENTATION_CSTATES = 0x00000001;

        public const int PPM_IDLE_IMPLEMENTATION_PEP = 0x00000002;

        public const int PPM_IDLE_IMPLEMENTATION_MICROPEP = 0x00000003;

        public const int PPM_IDLE_IMPLEMENTATION_LPISTATES = 0x00000004;

        public const uint POWER_ACTION_QUERY_ALLOWED = 0x00000001;

        public const uint POWER_ACTION_UI_ALLOWED = 0x00000002;

        public const uint POWER_ACTION_OVERRIDE_APPS = 0x00000004;

        public const uint POWER_ACTION_HIBERBOOT = 0x00000008;

        public const uint POWER_ACTION_USER_NOTIFY = 0x00000010;

        public const uint POWER_ACTION_DOZE_TO_HIBERNATE = 0x00000020;

        public const uint POWER_ACTION_ACPI_CRITICAL = 0x01000000;

        public const uint POWER_ACTION_ACPI_USER_NOTIFY = 0x02000000;

        public const uint POWER_ACTION_DIRECTED_DRIPS = 0x04000000;

        public const uint POWER_ACTION_PSEUDO_TRANSITION = 0x08000000;

        public const uint POWER_ACTION_LIGHTEST_FIRST = 0x10000000;

        public const uint POWER_ACTION_LOCK_CONSOLE = 0x20000000;

        public const uint POWER_ACTION_DISABLE_WAKES = 0x40000000;

        public const uint POWER_ACTION_CRITICAL = 0x80000000;

        public const uint POWER_LEVEL_USER_NOTIFY_TEXT = 0x00000001;

        public const uint POWER_LEVEL_USER_NOTIFY_SOUND = 0x00000002;

        public const uint POWER_LEVEL_USER_NOTIFY_EXEC = 0x00000004;

        public const uint POWER_USER_NOTIFY_BUTTON = 0x00000008;

        public const uint POWER_USER_NOTIFY_SHUTDOWN = 0x00000010;

        public const uint POWER_USER_NOTIFY_FORCED_SHUTDOWN = 0x00000020;

        public const uint POWER_FORCE_TRIGGER_RESET = 0x80000000;

        public const uint BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK = 0x00000007;

        public const uint BATTERY_DISCHARGE_FLAGS_ENABLE = 0x80000000;

        public const int NUM_DISCHARGE_POLICIES = 4;

        public const int DISCHARGE_POLICY_CRITICAL = 0;

        public const int DISCHARGE_POLICY_LOW = 1;

        public const int PROCESSOR_IDLESTATE_POLICY_COUNT = 0x3;

        public const int PO_THROTTLE_NONE = 0;

        public const int PO_THROTTLE_CONSTANT = 1;

        public const int PO_THROTTLE_DEGRADE = 2;

        public const int PO_THROTTLE_ADAPTIVE = 3;

        public const int PO_THROTTLE_MAXIMUM = 4;

        public const int HIBERFILE_TYPE_NONE = 0x00;

        public const int HIBERFILE_TYPE_REDUCED = 0x01;

        public const int HIBERFILE_TYPE_FULL = 0x02;

        public const int HIBERFILE_TYPE_MAX = 0x03;

        public const int IMAGE_DOS_SIGNATURE = 0x5A4D;

        public const int IMAGE_OS2_SIGNATURE = 0x454E;

        public const int IMAGE_OS2_SIGNATURE_LE = 0x454C;

        public const int IMAGE_VXD_SIGNATURE = 0x454C;

        public const int IMAGE_NT_SIGNATURE = 0x00004550;

        public const int IMAGE_SIZEOF_FILE_HEADER = 20;

        public const ushort IMAGE_FILE_RELOCS_STRIPPED = 0x0001;

        public const ushort IMAGE_FILE_EXECUTABLE_IMAGE = 0x0002;

        public const ushort IMAGE_FILE_LINE_NUMS_STRIPPED = 0x0004;

        public const ushort IMAGE_FILE_LOCAL_SYMS_STRIPPED = 0x0008;

        public const ushort IMAGE_FILE_AGGRESIVE_WS_TRIM = 0x0010;

        public const ushort IMAGE_FILE_LARGE_ADDRESS_AWARE = 0x0020;

        public const ushort IMAGE_FILE_BYTES_REVERSED_LO = 0x0080;

        public const ushort IMAGE_FILE_32BIT_MACHINE = 0x0100;

        public const ushort IMAGE_FILE_DEBUG_STRIPPED = 0x0200;

        public const ushort IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = 0x0400;

        public const ushort IMAGE_FILE_NET_RUN_FROM_SWAP = 0x0800;

        public const ushort IMAGE_FILE_SYSTEM = 0x1000;

        public const ushort IMAGE_FILE_DLL = 0x2000;

        public const ushort IMAGE_FILE_UP_SYSTEM_ONLY = 0x4000;

        public const ushort IMAGE_FILE_BYTES_REVERSED_HI = 0x8000;

        public const ushort IMAGE_FILE_MACHINE_UNKNOWN = 0;

        public const ushort IMAGE_FILE_MACHINE_TARGET_HOST = 0x0001;

        public const ushort IMAGE_FILE_MACHINE_I386 = 0x014C;

        public const ushort IMAGE_FILE_MACHINE_R3000 = 0x0162;

        public const ushort IMAGE_FILE_MACHINE_R4000 = 0x0166;

        public const ushort IMAGE_FILE_MACHINE_R10000 = 0x0168;

        public const ushort IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x0169;

        public const ushort IMAGE_FILE_MACHINE_ALPHA = 0x0184;

        public const ushort IMAGE_FILE_MACHINE_SH3 = 0x01A2;

        public const ushort IMAGE_FILE_MACHINE_SH3DSP = 0x01A3;

        public const ushort IMAGE_FILE_MACHINE_SH3E = 0x01A4;

        public const ushort IMAGE_FILE_MACHINE_SH4 = 0x01A6;

        public const ushort IMAGE_FILE_MACHINE_SH5 = 0x01A8;

        public const ushort IMAGE_FILE_MACHINE_ARM = 0x01C0;

        public const ushort IMAGE_FILE_MACHINE_THUMB = 0x01C2;

        public const ushort IMAGE_FILE_MACHINE_ARMNT = 0x01C4;

        public const ushort IMAGE_FILE_MACHINE_AM33 = 0x01D3;

        public const ushort IMAGE_FILE_MACHINE_POWERPC = 0x01F0;

        public const ushort IMAGE_FILE_MACHINE_POWERPCFP = 0x01F1;

        public const ushort IMAGE_FILE_MACHINE_IA64 = 0x0200;

        public const ushort IMAGE_FILE_MACHINE_MIPS16 = 0x0266;

        public const ushort IMAGE_FILE_MACHINE_ALPHA64 = 0x0284;

        public const ushort IMAGE_FILE_MACHINE_MIPSFPU = 0x0366;

        public const ushort IMAGE_FILE_MACHINE_MIPSFPU16 = 0x0466;

        public const ushort IMAGE_FILE_MACHINE_TRICORE = 0x0520;

        public const ushort IMAGE_FILE_MACHINE_CEF = 0x0CEF;

        public const ushort IMAGE_FILE_MACHINE_EBC = 0x0EBC;

        public const ushort IMAGE_FILE_MACHINE_AMD64 = 0x8664;

        public const ushort IMAGE_FILE_MACHINE_M32R = 0x9041;

        public const ushort IMAGE_FILE_MACHINE_ARM64 = 0xAA64;

        public const ushort IMAGE_FILE_MACHINE_CEE = 0xC0EE;

        public const int IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;

        public const int IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10B;

        public const int IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20B;

        public const int IMAGE_ROM_OPTIONAL_HDR_MAGIC = 0x107;

        public const int IMAGE_SUBSYSTEM_UNKNOWN = 0;

        public const int IMAGE_SUBSYSTEM_NATIVE = 1;

        public const int IMAGE_SUBSYSTEM_WINDOWS_GUI = 2;

        public const int IMAGE_SUBSYSTEM_WINDOWS_CUI = 3;

        public const int IMAGE_SUBSYSTEM_OS2_CUI = 5;

        public const int IMAGE_SUBSYSTEM_POSIX_CUI = 7;

        public const int IMAGE_SUBSYSTEM_NATIVE_WINDOWS = 8;

        public const int IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9;

        public const int IMAGE_SUBSYSTEM_EFI_APPLICATION = 10;

        public const int IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11;

        public const int IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12;

        public const int IMAGE_SUBSYSTEM_EFI_ROM = 13;

        public const int IMAGE_SUBSYSTEM_XBOX = 14;

        public const int IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION = 16;

        public const int IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG = 17;

        public const ushort IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA = 0x0020;

        public const ushort IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE = 0x0040;

        public const ushort IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY = 0x0080;

        public const ushort IMAGE_DLLCHARACTERISTICS_NX_COMPAT = 0x0100;

        public const ushort IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 0x0200;

        public const ushort IMAGE_DLLCHARACTERISTICS_NO_SEH = 0x0400;

        public const ushort IMAGE_DLLCHARACTERISTICS_NO_BIND = 0x0800;

        public const ushort IMAGE_DLLCHARACTERISTICS_APPCONTAINER = 0x1000;

        public const ushort IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 0x2000;

        public const ushort IMAGE_DLLCHARACTERISTICS_GUARD_CF = 0x4000;

        public const ushort IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 0x8000;

        public const int IMAGE_DIRECTORY_ENTRY_EXPORT = 0;

        public const int IMAGE_DIRECTORY_ENTRY_IMPORT = 1;

        public const int IMAGE_DIRECTORY_ENTRY_RESOURCE = 2;

        public const int IMAGE_DIRECTORY_ENTRY_EXCEPTION = 3;

        public const int IMAGE_DIRECTORY_ENTRY_SECURITY = 4;

        public const int IMAGE_DIRECTORY_ENTRY_BASERELOC = 5;

        public const int IMAGE_DIRECTORY_ENTRY_DEBUG = 6;

        public const int IMAGE_DIRECTORY_ENTRY_ARCHITECTURE = 7;

        public const int IMAGE_DIRECTORY_ENTRY_GLOBALPTR = 8;

        public const int IMAGE_DIRECTORY_ENTRY_TLS = 9;

        public const int IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG = 10;

        public const int IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT = 11;

        public const int IMAGE_DIRECTORY_ENTRY_IAT = 12;

        public const int IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT = 13;

        public const int IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR = 14;

        public const int IMAGE_SIZEOF_SHORT_NAME = 8;

        public const int IMAGE_SIZEOF_SECTION_HEADER = 40;

        public const uint IMAGE_SCN_TYPE_NO_PAD = 0x00000008;

        public const uint IMAGE_SCN_CNT_CODE = 0x00000020;

        public const uint IMAGE_SCN_CNT_INITIALIZED_DATA = 0x00000040;

        public const uint IMAGE_SCN_CNT_UNINITIALIZED_DATA = 0x00000080;

        public const uint IMAGE_SCN_LNK_OTHER = 0x00000100;

        public const uint IMAGE_SCN_LNK_INFO = 0x00000200;

        public const uint IMAGE_SCN_LNK_REMOVE = 0x00000800;

        public const uint IMAGE_SCN_LNK_COMDAT = 0x00001000;

        public const uint IMAGE_SCN_NO_DEFER_SPEC_EXC = 0x00004000;

        public const uint IMAGE_SCN_GPREL = 0x00008000;

        public const uint IMAGE_SCN_MEM_FARDATA = 0x00008000;

        public const uint IMAGE_SCN_MEM_PURGEABLE = 0x00020000;

        public const uint IMAGE_SCN_MEM_16BIT = 0x00020000;

        public const uint IMAGE_SCN_MEM_LOCKED = 0x00040000;

        public const uint IMAGE_SCN_MEM_PRELOAD = 0x00080000;

        public const uint IMAGE_SCN_ALIGN_1BYTES = 0x00100000;

        public const uint IMAGE_SCN_ALIGN_2BYTES = 0x00200000;

        public const uint IMAGE_SCN_ALIGN_4BYTES = 0x00300000;

        public const uint IMAGE_SCN_ALIGN_8BYTES = 0x00400000;

        public const uint IMAGE_SCN_ALIGN_16BYTES = 0x00500000;

        public const uint IMAGE_SCN_ALIGN_32BYTES = 0x00600000;

        public const uint IMAGE_SCN_ALIGN_64BYTES = 0x00700000;

        public const uint IMAGE_SCN_ALIGN_128BYTES = 0x00800000;

        public const uint IMAGE_SCN_ALIGN_256BYTES = 0x00900000;

        public const uint IMAGE_SCN_ALIGN_512BYTES = 0x00A00000;

        public const uint IMAGE_SCN_ALIGN_1024BYTES = 0x00B00000;

        public const uint IMAGE_SCN_ALIGN_2048BYTES = 0x00C00000;

        public const uint IMAGE_SCN_ALIGN_4096BYTES = 0x00D00000;

        public const uint IMAGE_SCN_ALIGN_8192BYTES = 0x00E00000;

        public const uint IMAGE_SCN_ALIGN_MASK = 0x00F00000;

        public const uint IMAGE_SCN_LNK_NRELOC_OVFL = 0x01000000;

        public const uint IMAGE_SCN_MEM_DISCARDABLE = 0x02000000;

        public const uint IMAGE_SCN_MEM_NOT_CACHED = 0x04000000;

        public const uint IMAGE_SCN_MEM_NOT_PAGED = 0x08000000;

        public const uint IMAGE_SCN_MEM_SHARED = 0x10000000;

        public const uint IMAGE_SCN_MEM_EXECUTE = 0x20000000;

        public const uint IMAGE_SCN_MEM_READ = 0x40000000;

        public const uint IMAGE_SCN_MEM_WRITE = 0x80000000;

        public const uint IMAGE_SCN_SCALE_INDEX = 0x00000001;

        public const int IMAGE_SIZEOF_SYMBOL = 18;

        public const short IMAGE_SYM_SECTION_MAX = unchecked((short)0xFEFF);

        public const short IMAGE_SYM_TYPE_NULL = 0x0000;

        public const short IMAGE_SYM_TYPE_VOID = 0x0001;

        public const short IMAGE_SYM_TYPE_CHAR = 0x0002;

        public const short IMAGE_SYM_TYPE_SHORT = 0x0003;

        public const short IMAGE_SYM_TYPE_INT = 0x0004;

        public const short IMAGE_SYM_TYPE_LONG = 0x0005;

        public const short IMAGE_SYM_TYPE_FLOAT = 0x0006;

        public const short IMAGE_SYM_TYPE_DOUBLE = 0x0007;

        public const short IMAGE_SYM_TYPE_STRUCT = 0x0008;

        public const short IMAGE_SYM_TYPE_UNION = 0x0009;

        public const short IMAGE_SYM_TYPE_ENUM = 0x000A;

        public const short IMAGE_SYM_TYPE_MOE = 0x000B;

        public const short IMAGE_SYM_TYPE_BYTE = 0x000C;

        public const short IMAGE_SYM_TYPE_WORD = 0x000D;

        public const short IMAGE_SYM_TYPE_UINT = 0x000E;

        public const short IMAGE_SYM_TYPE_DWORD = 0x000F;

        public const short IMAGE_SYM_TYPE_PCODE = unchecked((short)0x8000);

        public const byte IMAGE_SYM_DTYPE_NULL = 0;

        public const byte IMAGE_SYM_DTYPE_POINTER = 1;

        public const byte IMAGE_SYM_DTYPE_FUNCTION = 2;

        public const byte IMAGE_SYM_DTYPE_ARRAY = 3;

        public const byte IMAGE_SYM_CLASS_NULL = 0x0000;

        public const byte IMAGE_SYM_CLASS_AUTOMATIC = 0x0001;

        public const byte IMAGE_SYM_CLASS_EXTERNAL = 0x0002;

        public const byte IMAGE_SYM_CLASS_STATIC = 0x0003;

        public const byte IMAGE_SYM_CLASS_REGISTER = 0x0004;

        public const byte IMAGE_SYM_CLASS_EXTERNAL_DEF = 0x0005;

        public const byte IMAGE_SYM_CLASS_LABEL = 0x0006;

        public const byte IMAGE_SYM_CLASS_UNDEFINED_LABEL = 0x0007;

        public const byte IMAGE_SYM_CLASS_MEMBER_OF_STRUCT = 0x0008;

        public const byte IMAGE_SYM_CLASS_ARGUMENT = 0x0009;

        public const byte IMAGE_SYM_CLASS_STRUCT_TAG = 0x000A;

        public const byte IMAGE_SYM_CLASS_MEMBER_OF_UNION = 0x000B;

        public const byte IMAGE_SYM_CLASS_UNION_TAG = 0x000C;

        public const byte IMAGE_SYM_CLASS_TYPE_DEFINITION = 0x000D;

        public const byte IMAGE_SYM_CLASS_UNDEFINED_STATIC = 0x000E;

        public const byte IMAGE_SYM_CLASS_ENUM_TAG = 0x000F;

        public const byte IMAGE_SYM_CLASS_MEMBER_OF_ENUM = 0x0010;

        public const byte IMAGE_SYM_CLASS_REGISTER_PARAM = 0x0011;

        public const byte IMAGE_SYM_CLASS_BIT_FIELD = 0x0012;

        public const byte IMAGE_SYM_CLASS_FAR_EXTERNAL = 0x0044;

        public const byte IMAGE_SYM_CLASS_BLOCK = 0x0064;

        public const byte IMAGE_SYM_CLASS_FUNCTION = 0x0065;

        public const byte IMAGE_SYM_CLASS_END_OF_STRUCT = 0x0066;

        public const byte IMAGE_SYM_CLASS_FILE = 0x0067;

        public const byte IMAGE_SYM_CLASS_SECTION = 0x0068;

        public const byte IMAGE_SYM_CLASS_WEAK_EXTERNAL = 0x0069;

        public const byte IMAGE_SYM_CLASS_CLR_TOKEN = 0x006B;

        public const int N_BTMASK = 0x000F;

        public const int N_TMASK = 0x0030;

        public const int N_TMASK1 = 0x00C0;

        public const int N_TMASK2 = 0x00F0;

        public const int N_BTSHFT = 4;

        public const int N_TSHIFT = 2;

        public const int IMAGE_COMDAT_SELECT_NODUPLICATES = 1;

        public const int IMAGE_COMDAT_SELECT_ANY = 2;

        public const int IMAGE_COMDAT_SELECT_SAME_SIZE = 3;

        public const int IMAGE_COMDAT_SELECT_EXACT_MATCH = 4;

        public const int IMAGE_COMDAT_SELECT_ASSOCIATIVE = 5;

        public const int IMAGE_COMDAT_SELECT_LARGEST = 6;

        public const int IMAGE_COMDAT_SELECT_NEWEST = 7;

        public const int IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY = 1;

        public const int IMAGE_WEAK_EXTERN_SEARCH_LIBRARY = 2;

        public const int IMAGE_WEAK_EXTERN_SEARCH_ALIAS = 3;

        public const int IMAGE_WEAK_EXTERN_ANTI_DEPENDENCY = 4;

        public const short IMAGE_REL_I386_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_I386_DIR16 = 0x0001;

        public const short IMAGE_REL_I386_REL16 = 0x0002;

        public const short IMAGE_REL_I386_DIR32 = 0x0006;

        public const short IMAGE_REL_I386_DIR32NB = 0x0007;

        public const short IMAGE_REL_I386_SEG12 = 0x0009;

        public const short IMAGE_REL_I386_SECTION = 0x000A;

        public const short IMAGE_REL_I386_SECREL = 0x000B;

        public const short IMAGE_REL_I386_TOKEN = 0x000C;

        public const short IMAGE_REL_I386_SECREL7 = 0x000D;

        public const short IMAGE_REL_I386_REL32 = 0x0014;

        public const short IMAGE_REL_MIPS_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_MIPS_REFHALF = 0x0001;

        public const short IMAGE_REL_MIPS_REFWORD = 0x0002;

        public const short IMAGE_REL_MIPS_JMPADDR = 0x0003;

        public const short IMAGE_REL_MIPS_REFHI = 0x0004;

        public const short IMAGE_REL_MIPS_REFLO = 0x0005;

        public const short IMAGE_REL_MIPS_GPREL = 0x0006;

        public const short IMAGE_REL_MIPS_LITERAL = 0x0007;

        public const short IMAGE_REL_MIPS_SECTION = 0x000A;

        public const short IMAGE_REL_MIPS_SECREL = 0x000B;

        public const short IMAGE_REL_MIPS_SECRELLO = 0x000C;

        public const short IMAGE_REL_MIPS_SECRELHI = 0x000D;

        public const short IMAGE_REL_MIPS_TOKEN = 0x000E;

        public const short IMAGE_REL_MIPS_JMPADDR16 = 0x0010;

        public const short IMAGE_REL_MIPS_REFWORDNB = 0x0022;

        public const short IMAGE_REL_MIPS_PAIR = 0x0025;

        public const short IMAGE_REL_ALPHA_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_ALPHA_REFLONG = 0x0001;

        public const short IMAGE_REL_ALPHA_REFQUAD = 0x0002;

        public const short IMAGE_REL_ALPHA_GPREL32 = 0x0003;

        public const short IMAGE_REL_ALPHA_LITERAL = 0x0004;

        public const short IMAGE_REL_ALPHA_LITUSE = 0x0005;

        public const short IMAGE_REL_ALPHA_GPDISP = 0x0006;

        public const short IMAGE_REL_ALPHA_BRADDR = 0x0007;

        public const short IMAGE_REL_ALPHA_HINT = 0x0008;

        public const short IMAGE_REL_ALPHA_INLINE_REFLONG = 0x0009;

        public const short IMAGE_REL_ALPHA_REFHI = 0x000A;

        public const short IMAGE_REL_ALPHA_REFLO = 0x000B;

        public const short IMAGE_REL_ALPHA_PAIR = 0x000C;

        public const short IMAGE_REL_ALPHA_MATCH = 0x000D;

        public const short IMAGE_REL_ALPHA_SECTION = 0x000E;

        public const short IMAGE_REL_ALPHA_SECREL = 0x000F;

        public const short IMAGE_REL_ALPHA_REFLONGNB = 0x0010;

        public const short IMAGE_REL_ALPHA_SECRELLO = 0x0011;

        public const short IMAGE_REL_ALPHA_SECRELHI = 0x0012;

        public const short IMAGE_REL_ALPHA_REFQ3 = 0x0013;

        public const short IMAGE_REL_ALPHA_REFQ2 = 0x0014;

        public const short IMAGE_REL_ALPHA_REFQ1 = 0x0015;

        public const short IMAGE_REL_ALPHA_GPRELLO = 0x0016;

        public const short IMAGE_REL_ALPHA_GPRELHI = 0x0017;

        public const short IMAGE_REL_PPC_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_PPC_ADDR64 = 0x0001;

        public const short IMAGE_REL_PPC_ADDR32 = 0x0002;

        public const short IMAGE_REL_PPC_ADDR24 = 0x0003;

        public const short IMAGE_REL_PPC_ADDR16 = 0x0004;

        public const short IMAGE_REL_PPC_ADDR14 = 0x0005;

        public const short IMAGE_REL_PPC_REL24 = 0x0006;

        public const short IMAGE_REL_PPC_REL14 = 0x0007;

        public const short IMAGE_REL_PPC_TOCREL16 = 0x0008;

        public const short IMAGE_REL_PPC_TOCREL14 = 0x0009;

        public const short IMAGE_REL_PPC_ADDR32NB = 0x000A;

        public const short IMAGE_REL_PPC_SECREL = 0x000B;

        public const short IMAGE_REL_PPC_SECTION = 0x000C;

        public const short IMAGE_REL_PPC_IFGLUE = 0x000D;

        public const short IMAGE_REL_PPC_IMGLUE = 0x000E;

        public const short IMAGE_REL_PPC_SECREL16 = 0x000F;

        public const short IMAGE_REL_PPC_REFHI = 0x0010;

        public const short IMAGE_REL_PPC_REFLO = 0x0011;

        public const short IMAGE_REL_PPC_PAIR = 0x0012;

        public const short IMAGE_REL_PPC_SECRELLO = 0x0013;

        public const short IMAGE_REL_PPC_SECRELHI = 0x0014;

        public const short IMAGE_REL_PPC_GPREL = 0x0015;

        public const short IMAGE_REL_PPC_TOKEN = 0x0016;

        public const short IMAGE_REL_PPC_TYPEMASK = 0x00FF;

        public const short IMAGE_REL_PPC_NEG = 0x0100;

        public const short IMAGE_REL_PPC_BRTAKEN = 0x0200;

        public const short IMAGE_REL_PPC_BRNTAKEN = 0x0400;

        public const short IMAGE_REL_PPC_TOCDEFN = 0x0800;

        public const short IMAGE_REL_SH3_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_SH3_DIRECT16 = 0x0001;

        public const short IMAGE_REL_SH3_DIRECT32 = 0x0002;

        public const short IMAGE_REL_SH3_DIRECT8 = 0x0003;

        public const short IMAGE_REL_SH3_DIRECT8_WORD = 0x0004;

        public const short IMAGE_REL_SH3_DIRECT8_LONG = 0x0005;

        public const short IMAGE_REL_SH3_DIRECT4 = 0x0006;

        public const short IMAGE_REL_SH3_DIRECT4_WORD = 0x0007;

        public const short IMAGE_REL_SH3_DIRECT4_LONG = 0x0008;

        public const short IMAGE_REL_SH3_PCREL8_WORD = 0x0009;

        public const short IMAGE_REL_SH3_PCREL8_LONG = 0x000A;

        public const short IMAGE_REL_SH3_PCREL12_WORD = 0x000B;

        public const short IMAGE_REL_SH3_STARTOF_SECTION = 0x000C;

        public const short IMAGE_REL_SH3_SIZEOF_SECTION = 0x000D;

        public const short IMAGE_REL_SH3_SECTION = 0x000E;

        public const short IMAGE_REL_SH3_SECREL = 0x000F;

        public const short IMAGE_REL_SH3_DIRECT32_NB = 0x0010;

        public const short IMAGE_REL_SH3_GPREL4_LONG = 0x0011;

        public const short IMAGE_REL_SH3_TOKEN = 0x0012;

        public const short IMAGE_REL_SHM_PCRELPT = 0x0013;

        public const short IMAGE_REL_SHM_REFLO = 0x0014;

        public const short IMAGE_REL_SHM_REFHALF = 0x0015;

        public const short IMAGE_REL_SHM_RELLO = 0x0016;

        public const short IMAGE_REL_SHM_RELHALF = 0x0017;

        public const short IMAGE_REL_SHM_PAIR = 0x0018;

        public const short IMAGE_REL_SH_NOMODE = unchecked((short)0x8000);

        public const short IMAGE_REL_ARM_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_ARM_ADDR32 = 0x0001;

        public const short IMAGE_REL_ARM_ADDR32NB = 0x0002;

        public const short IMAGE_REL_ARM_BRANCH24 = 0x0003;

        public const short IMAGE_REL_ARM_BRANCH11 = 0x0004;

        public const short IMAGE_REL_ARM_TOKEN = 0x0005;

        public const short IMAGE_REL_ARM_GPREL12 = 0x0006;

        public const short IMAGE_REL_ARM_GPREL7 = 0x0007;

        public const short IMAGE_REL_ARM_BLX24 = 0x0008;

        public const short IMAGE_REL_ARM_BLX11 = 0x0009;

        public const short IMAGE_REL_ARM_SECTION = 0x000E;

        public const short IMAGE_REL_ARM_SECREL = 0x000F;

        public const short IMAGE_REL_ARM_MOV32A = 0x0010;

        public const short IMAGE_REL_ARM_MOV32 = 0x0010;

        public const short IMAGE_REL_ARM_MOV32T = 0x0011;

        public const short IMAGE_REL_THUMB_MOV32 = 0x0011;

        public const short IMAGE_REL_ARM_BRANCH20T = 0x0012;

        public const short IMAGE_REL_THUMB_BRANCH20 = 0x0012;

        public const short IMAGE_REL_ARM_BRANCH24T = 0x0014;

        public const short IMAGE_REL_THUMB_BRANCH24 = 0x0014;

        public const short IMAGE_REL_ARM_BLX23T = 0x0015;

        public const short IMAGE_REL_THUMB_BLX23 = 0x0015;

        public const short IMAGE_REL_AM_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_AM_ADDR32 = 0x0001;

        public const short IMAGE_REL_AM_ADDR32NB = 0x0002;

        public const short IMAGE_REL_AM_CALL32 = 0x0003;

        public const short IMAGE_REL_AM_FUNCINFO = 0x0004;

        public const short IMAGE_REL_AM_REL32_1 = 0x0005;

        public const short IMAGE_REL_AM_REL32_2 = 0x0006;

        public const short IMAGE_REL_AM_SECREL = 0x0007;

        public const short IMAGE_REL_AM_SECTION = 0x0008;

        public const short IMAGE_REL_AM_TOKEN = 0x0009;

        public const short IMAGE_REL_ARM64_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_ARM64_ADDR32 = 0x0001;

        public const short IMAGE_REL_ARM64_ADDR32NB = 0x0002;

        public const short IMAGE_REL_ARM64_BRANCH26 = 0x0003;

        public const short IMAGE_REL_ARM64_PAGEBASE_REL21 = 0x0004;

        public const short IMAGE_REL_ARM64_REL21 = 0x0005;

        public const short IMAGE_REL_ARM64_PAGEOFFSET_12A = 0x0006;

        public const short IMAGE_REL_ARM64_PAGEOFFSET_12L = 0x0007;

        public const short IMAGE_REL_ARM64_SECREL = 0x0008;

        public const short IMAGE_REL_ARM64_SECREL_LOW12A = 0x0009;

        public const short IMAGE_REL_ARM64_SECREL_HIGH12A = 0x000A;

        public const short IMAGE_REL_ARM64_SECREL_LOW12L = 0x000B;

        public const short IMAGE_REL_ARM64_TOKEN = 0x000C;

        public const short IMAGE_REL_ARM64_SECTION = 0x000D;

        public const short IMAGE_REL_ARM64_ADDR64 = 0x000E;

        public const short IMAGE_REL_ARM64_BRANCH19 = 0x000F;

        public const short IMAGE_REL_AMD64_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_AMD64_ADDR64 = 0x0001;

        public const short IMAGE_REL_AMD64_ADDR32 = 0x0002;

        public const short IMAGE_REL_AMD64_ADDR32NB = 0x0003;

        public const short IMAGE_REL_AMD64_REL32 = 0x0004;

        public const short IMAGE_REL_AMD64_REL32_1 = 0x0005;

        public const short IMAGE_REL_AMD64_REL32_2 = 0x0006;

        public const short IMAGE_REL_AMD64_REL32_3 = 0x0007;

        public const short IMAGE_REL_AMD64_REL32_4 = 0x0008;

        public const short IMAGE_REL_AMD64_REL32_5 = 0x0009;

        public const short IMAGE_REL_AMD64_SECTION = 0x000A;

        public const short IMAGE_REL_AMD64_SECREL = 0x000B;

        public const short IMAGE_REL_AMD64_SECREL7 = 0x000C;

        public const short IMAGE_REL_AMD64_TOKEN = 0x000D;

        public const short IMAGE_REL_AMD64_SREL32 = 0x000E;

        public const short IMAGE_REL_AMD64_PAIR = 0x000F;

        public const short IMAGE_REL_AMD64_SSPAN32 = 0x0010;

        public const short IMAGE_REL_AMD64_EHANDLER = 0x0011;

        public const short IMAGE_REL_AMD64_IMPORT_BR = 0x0012;

        public const short IMAGE_REL_AMD64_IMPORT_CALL = 0x0013;

        public const short IMAGE_REL_AMD64_CFG_BR = 0x0014;

        public const short IMAGE_REL_AMD64_CFG_BR_REX = 0x0015;

        public const short IMAGE_REL_AMD64_CFG_CALL = 0x0016;

        public const short IMAGE_REL_AMD64_INDIR_BR = 0x0017;

        public const short IMAGE_REL_AMD64_INDIR_BR_REX = 0x0018;

        public const short IMAGE_REL_AMD64_INDIR_CALL = 0x0019;

        public const short IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_FIRST = 0x0020;

        public const short IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_LAST = 0x002F;

        public const short IMAGE_REL_IA64_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_IA64_IMM14 = 0x0001;

        public const short IMAGE_REL_IA64_IMM22 = 0x0002;

        public const short IMAGE_REL_IA64_IMM64 = 0x0003;

        public const short IMAGE_REL_IA64_DIR32 = 0x0004;

        public const short IMAGE_REL_IA64_DIR64 = 0x0005;

        public const short IMAGE_REL_IA64_PCREL21B = 0x0006;

        public const short IMAGE_REL_IA64_PCREL21M = 0x0007;

        public const short IMAGE_REL_IA64_PCREL21F = 0x0008;

        public const short IMAGE_REL_IA64_GPREL22 = 0x0009;

        public const short IMAGE_REL_IA64_LTOFF22 = 0x000A;

        public const short IMAGE_REL_IA64_SECTION = 0x000B;

        public const short IMAGE_REL_IA64_SECREL22 = 0x000C;

        public const short IMAGE_REL_IA64_SECREL64I = 0x000D;

        public const short IMAGE_REL_IA64_SECREL32 = 0x000E;

        public const short IMAGE_REL_IA64_DIR32NB = 0x0010;

        public const short IMAGE_REL_IA64_SREL14 = 0x0011;

        public const short IMAGE_REL_IA64_SREL22 = 0x0012;

        public const short IMAGE_REL_IA64_SREL32 = 0x0013;

        public const short IMAGE_REL_IA64_UREL32 = 0x0014;

        public const short IMAGE_REL_IA64_PCREL60X = 0x0015;

        public const short IMAGE_REL_IA64_PCREL60B = 0x0016;

        public const short IMAGE_REL_IA64_PCREL60F = 0x0017;

        public const short IMAGE_REL_IA64_PCREL60I = 0x0018;

        public const short IMAGE_REL_IA64_PCREL60M = 0x0019;

        public const short IMAGE_REL_IA64_IMMGPREL64 = 0x001A;

        public const short IMAGE_REL_IA64_TOKEN = 0x001B;

        public const short IMAGE_REL_IA64_GPREL32 = 0x001C;

        public const short IMAGE_REL_IA64_ADDEND = 0x001F;

        public const short IMAGE_REL_CEF_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_CEF_ADDR32 = 0x0001;

        public const short IMAGE_REL_CEF_ADDR64 = 0x0002;

        public const short IMAGE_REL_CEF_ADDR32NB = 0x0003;

        public const short IMAGE_REL_CEF_SECTION = 0x0004;

        public const short IMAGE_REL_CEF_SECREL = 0x0005;

        public const short IMAGE_REL_CEF_TOKEN = 0x0006;

        public const short IMAGE_REL_CEE_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_CEE_ADDR32 = 0x0001;

        public const short IMAGE_REL_CEE_ADDR64 = 0x0002;

        public const short IMAGE_REL_CEE_ADDR32NB = 0x0003;

        public const short IMAGE_REL_CEE_SECTION = 0x0004;

        public const short IMAGE_REL_CEE_SECREL = 0x0005;

        public const short IMAGE_REL_CEE_TOKEN = 0x0006;

        public const short IMAGE_REL_M32R_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_M32R_ADDR32 = 0x0001;

        public const short IMAGE_REL_M32R_ADDR32NB = 0x0002;

        public const short IMAGE_REL_M32R_ADDR24 = 0x0003;

        public const short IMAGE_REL_M32R_GPREL16 = 0x0004;

        public const short IMAGE_REL_M32R_PCREL24 = 0x0005;

        public const short IMAGE_REL_M32R_PCREL16 = 0x0006;

        public const short IMAGE_REL_M32R_PCREL8 = 0x0007;

        public const short IMAGE_REL_M32R_REFHALF = 0x0008;

        public const short IMAGE_REL_M32R_REFHI = 0x0009;

        public const short IMAGE_REL_M32R_REFLO = 0x000A;

        public const short IMAGE_REL_M32R_PAIR = 0x000B;

        public const short IMAGE_REL_M32R_SECTION = 0x000C;

        public const short IMAGE_REL_M32R_SECREL32 = 0x000D;

        public const short IMAGE_REL_M32R_TOKEN = 0x000E;

        public const short IMAGE_REL_EBC_ABSOLUTE = 0x0000;

        public const short IMAGE_REL_EBC_ADDR32NB = 0x0001;

        public const short IMAGE_REL_EBC_REL32 = 0x0002;

        public const short IMAGE_REL_EBC_SECTION = 0x0003;

        public const short IMAGE_REL_EBC_SECREL = 0x0004;

        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_X = 3;

        public const int EMARCH_ENC_I17_IMM7B_SIZE_X = 7;

        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X = 4;

        public const int EMARCH_ENC_I17_IMM7B_VAL_POS_X = 0;

        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_X = 3;

        public const int EMARCH_ENC_I17_IMM9D_SIZE_X = 9;

        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X = 18;

        public const int EMARCH_ENC_I17_IMM9D_VAL_POS_X = 7;

        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_X = 3;

        public const int EMARCH_ENC_I17_IMM5C_SIZE_X = 5;

        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X = 13;

        public const int EMARCH_ENC_I17_IMM5C_VAL_POS_X = 16;

        public const int EMARCH_ENC_I17_IC_INST_WORD_X = 3;

        public const int EMARCH_ENC_I17_IC_SIZE_X = 1;

        public const int EMARCH_ENC_I17_IC_INST_WORD_POS_X = 12;

        public const int EMARCH_ENC_I17_IC_VAL_POS_X = 21;

        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_X = 1;

        public const int EMARCH_ENC_I17_IMM41a_SIZE_X = 10;

        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X = 14;

        public const int EMARCH_ENC_I17_IMM41a_VAL_POS_X = 22;

        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_X = 1;

        public const int EMARCH_ENC_I17_IMM41b_SIZE_X = 8;

        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X = 24;

        public const int EMARCH_ENC_I17_IMM41b_VAL_POS_X = 32;

        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_X = 2;

        public const int EMARCH_ENC_I17_IMM41c_SIZE_X = 23;

        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X = 0;

        public const int EMARCH_ENC_I17_IMM41c_VAL_POS_X = 40;

        public const int EMARCH_ENC_I17_SIGN_INST_WORD_X = 3;

        public const int EMARCH_ENC_I17_SIGN_SIZE_X = 1;

        public const int EMARCH_ENC_I17_SIGN_INST_WORD_POS_X = 27;

        public const int EMARCH_ENC_I17_SIGN_VAL_POS_X = 63;

        public const int X3_OPCODE_INST_WORD_X = 3;

        public const int X3_OPCODE_SIZE_X = 4;

        public const int X3_OPCODE_INST_WORD_POS_X = 28;

        public const int X3_OPCODE_SIGN_VAL_POS_X = 0;

        public const int X3_I_INST_WORD_X = 3;

        public const int X3_I_SIZE_X = 1;

        public const int X3_I_INST_WORD_POS_X = 27;

        public const int X3_I_SIGN_VAL_POS_X = 59;

        public const int X3_D_WH_INST_WORD_X = 3;

        public const int X3_D_WH_SIZE_X = 3;

        public const int X3_D_WH_INST_WORD_POS_X = 24;

        public const int X3_D_WH_SIGN_VAL_POS_X = 0;

        public const int X3_IMM20_INST_WORD_X = 3;

        public const int X3_IMM20_SIZE_X = 20;

        public const int X3_IMM20_INST_WORD_POS_X = 4;

        public const int X3_IMM20_SIGN_VAL_POS_X = 0;

        public const int X3_IMM39_1_INST_WORD_X = 2;

        public const int X3_IMM39_1_SIZE_X = 23;

        public const int X3_IMM39_1_INST_WORD_POS_X = 0;

        public const int X3_IMM39_1_SIGN_VAL_POS_X = 36;

        public const int X3_IMM39_2_INST_WORD_X = 1;

        public const int X3_IMM39_2_SIZE_X = 16;

        public const int X3_IMM39_2_INST_WORD_POS_X = 16;

        public const int X3_IMM39_2_SIGN_VAL_POS_X = 20;

        public const int X3_P_INST_WORD_X = 3;

        public const int X3_P_SIZE_X = 4;

        public const int X3_P_INST_WORD_POS_X = 0;

        public const int X3_P_SIGN_VAL_POS_X = 0;

        public const int X3_TMPLT_INST_WORD_X = 0;

        public const int X3_TMPLT_SIZE_X = 4;

        public const int X3_TMPLT_INST_WORD_POS_X = 0;

        public const int X3_TMPLT_SIGN_VAL_POS_X = 0;

        public const int X3_BTYPE_QP_INST_WORD_X = 2;

        public const int X3_BTYPE_QP_SIZE_X = 9;

        public const int X3_BTYPE_QP_INST_WORD_POS_X = 23;

        public const int X3_BTYPE_QP_INST_VAL_POS_X = 0;

        public const int X3_EMPTY_INST_WORD_X = 1;

        public const int X3_EMPTY_SIZE_X = 2;

        public const int X3_EMPTY_INST_WORD_POS_X = 14;

        public const int X3_EMPTY_INST_VAL_POS_X = 0;

        public const int IMAGE_REL_BASED_ABSOLUTE = 0;

        public const int IMAGE_REL_BASED_HIGH = 1;

        public const int IMAGE_REL_BASED_LOW = 2;

        public const int IMAGE_REL_BASED_HIGHLOW = 3;

        public const int IMAGE_REL_BASED_HIGHADJ = 4;

        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_5 = 5;

        public const int IMAGE_REL_BASED_RESERVED = 6;

        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_7 = 7;

        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_8 = 8;

        public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_9 = 9;

        public const int IMAGE_REL_BASED_DIR64 = 10;

        public const int IMAGE_REL_BASED_IA64_IMM64 = 9;

        public const int IMAGE_REL_BASED_MIPS_JMPADDR = 5;

        public const int IMAGE_REL_BASED_MIPS_JMPADDR16 = 9;

        public const int IMAGE_REL_BASED_ARM_MOV32 = 5;

        public const int IMAGE_REL_BASED_THUMB_MOV32 = 7;

        public const int IMAGE_ARCHIVE_START_SIZE = 8;

        // !<arch>
        public static ReadOnlySpan<sbyte> IMAGE_ARCHIVE_START => new sbyte[] { 0x21, 0x3C, 0x61, 0x72, 0x63, 0x68, 0x3E, 0x0A, 0x00 };

        // `
        public static ReadOnlySpan<sbyte> IMAGE_ARCHIVE_END => new sbyte[] { 0x60, 0x0A, 0x00 };

        // 
        public static ReadOnlySpan<sbyte> IMAGE_ARCHIVE_PAD => new sbyte[] { 0x0A, 0x00 };

        // /               
        public static ReadOnlySpan<sbyte> IMAGE_ARCHIVE_LINKER_MEMBER => new sbyte[] { 0x2F, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };

        // //              
        public static ReadOnlySpan<sbyte> IMAGE_ARCHIVE_LONGNAMES_MEMBER => new sbyte[] { 0x2F, 0x2F, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };

        // /<HYBRIDMAP>/   
        public static ReadOnlySpan<sbyte> IMAGE_ARCHIVE_HYBRIDMAP_MEMBER => new sbyte[] { 0x2F, 0x3C, 0x48, 0x59, 0x42, 0x52, 0x49, 0x44, 0x4D, 0x41, 0x50, 0x3E, 0x2F, 0x20, 0x20, 0x20, 0x00 };

        public const int IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR = 60;

        public const ulong IMAGE_ORDINAL_FLAG64 = 0x8000000000000000;

        public const uint IMAGE_ORDINAL_FLAG32 = 0x80000000;

        public const uint IMAGE_RESOURCE_NAME_IS_STRING = 0x80000000;

        public const uint IMAGE_RESOURCE_DATA_IS_DIRECTORY = 0x80000000;

        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_RF_PROLOGUE = 0x00000001;

        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_RF_EPILOGUE = 0x00000002;

        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_IMPORT_CONTROL_TRANSFER = 0x00000003;

        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_INDIR_CONTROL_TRANSFER = 0x00000004;

        public const int IMAGE_DYNAMIC_RELOCATION_GUARD_SWITCHTABLE_BRANCH = 0x00000005;

        public const uint IMAGE_HOT_PATCH_BASE_OBLIGATORY = 0x00000001;

        public const uint IMAGE_HOT_PATCH_BASE_CAN_ROLL_BACK = 0x00000002;

        public const uint IMAGE_HOT_PATCH_CHUNK_INVERSE = 0x80000000;

        public const uint IMAGE_HOT_PATCH_CHUNK_OBLIGATORY = 0x40000000;

        public const uint IMAGE_HOT_PATCH_CHUNK_RESERVED = 0x3FF03000;

        public const uint IMAGE_HOT_PATCH_CHUNK_TYPE = 0x000FC000;

        public const uint IMAGE_HOT_PATCH_CHUNK_SOURCE_RVA = 0x00008000;

        public const uint IMAGE_HOT_PATCH_CHUNK_TARGET_RVA = 0x00004000;

        public const uint IMAGE_HOT_PATCH_CHUNK_SIZE = 0x00000FFF;

        public const uint IMAGE_HOT_PATCH_NONE = 0x00000000;

        public const uint IMAGE_HOT_PATCH_FUNCTION = 0x0001C000;

        public const uint IMAGE_HOT_PATCH_ABSOLUTE = 0x0002C000;

        public const uint IMAGE_HOT_PATCH_REL32 = 0x0003C000;

        public const uint IMAGE_HOT_PATCH_CALL_TARGET = 0x00044000;

        public const uint IMAGE_HOT_PATCH_INDIRECT = 0x0005C000;

        public const uint IMAGE_HOT_PATCH_NO_CALL_TARGET = 0x00064000;

        public const uint IMAGE_HOT_PATCH_DYNAMIC_VALUE = 0x00078000;

        public const uint IMAGE_GUARD_CF_INSTRUMENTED = 0x00000100;

        public const uint IMAGE_GUARD_CFW_INSTRUMENTED = 0x00000200;

        public const uint IMAGE_GUARD_CF_FUNCTION_TABLE_PRESENT = 0x00000400;

        public const uint IMAGE_GUARD_SECURITY_COOKIE_UNUSED = 0x00000800;

        public const uint IMAGE_GUARD_PROTECT_DELAYLOAD_IAT = 0x00001000;

        public const uint IMAGE_GUARD_DELAYLOAD_IAT_IN_ITS_OWN_SECTION = 0x00002000;

        public const uint IMAGE_GUARD_CF_EXPORT_SUPPRESSION_INFO_PRESENT = 0x00004000;

        public const uint IMAGE_GUARD_CF_ENABLE_EXPORT_SUPPRESSION = 0x00008000;

        public const uint IMAGE_GUARD_CF_LONGJUMP_TABLE_PRESENT = 0x00010000;

        public const uint IMAGE_GUARD_RF_INSTRUMENTED = 0x00020000;

        public const uint IMAGE_GUARD_RF_ENABLE = 0x00040000;

        public const uint IMAGE_GUARD_RF_STRICT = 0x00080000;

        public const uint IMAGE_GUARD_RETPOLINE_PRESENT = 0x00100000;

        public const uint IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_MASK = 0xF0000000;

        public const int IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_SHIFT = 28;

        public const int IMAGE_GUARD_FLAG_FID_SUPPRESSED = 0x01;

        public const int IMAGE_GUARD_FLAG_EXPORT_SUPPRESSED = 0x02;

        public const int IMAGE_ENCLAVE_POLICY_DEBUGGABLE = 0x00000001;

        public const int IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE = 0x00000001;

        public const int IMAGE_ENCLAVE_IMPORT_MATCH_NONE = 0x00000000;

        public const int IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID = 0x00000001;

        public const int IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID = 0x00000002;

        public const int IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID = 0x00000003;

        public const int IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID = 0x00000004;

        public const int IMAGE_DEBUG_TYPE_UNKNOWN = 0;

        public const int IMAGE_DEBUG_TYPE_COFF = 1;

        public const int IMAGE_DEBUG_TYPE_CODEVIEW = 2;

        public const int IMAGE_DEBUG_TYPE_FPO = 3;

        public const int IMAGE_DEBUG_TYPE_MISC = 4;

        public const int IMAGE_DEBUG_TYPE_EXCEPTION = 5;

        public const int IMAGE_DEBUG_TYPE_FIXUP = 6;

        public const int IMAGE_DEBUG_TYPE_OMAP_TO_SRC = 7;

        public const int IMAGE_DEBUG_TYPE_OMAP_FROM_SRC = 8;

        public const int IMAGE_DEBUG_TYPE_BORLAND = 9;

        public const int IMAGE_DEBUG_TYPE_RESERVED10 = 10;

        public const int IMAGE_DEBUG_TYPE_CLSID = 11;

        public const int IMAGE_DEBUG_TYPE_VC_FEATURE = 12;

        public const int IMAGE_DEBUG_TYPE_POGO = 13;

        public const int IMAGE_DEBUG_TYPE_ILTCG = 14;

        public const int IMAGE_DEBUG_TYPE_MPX = 15;

        public const int IMAGE_DEBUG_TYPE_REPRO = 16;

        public const int FRAME_FPO = 0;

        public const int FRAME_TRAP = 1;

        public const int FRAME_TSS = 2;

        public const int FRAME_NONFPO = 3;

        public const int SIZEOF_RFPO_DATA = 16;

        public const int IMAGE_DEBUG_MISC_EXENAME = 1;

        public const ushort IMAGE_SEPARATE_DEBUG_FLAGS_MASK = 0x8000;

        public const ushort IMAGE_SEPARATE_DEBUG_MISMATCH = 0x8000;

        public const ushort IMPORT_OBJECT_HDR_SIG2 = 0xFFFF;

        public const uint RTL_RUN_ONCE_CHECK_ONLY = 0x00000001;

        public const uint RTL_RUN_ONCE_ASYNC = 0x00000002;

        public const uint RTL_RUN_ONCE_INIT_FAILED = 0x00000004;

        public const int RTL_RUN_ONCE_CTX_RESERVED_BITS = 2;

        public const uint FAST_FAIL_LEGACY_GS_VIOLATION = 0;

        public const uint FAST_FAIL_VTGUARD_CHECK_FAILURE = 1;

        public const uint FAST_FAIL_STACK_COOKIE_CHECK_FAILURE = 2;

        public const uint FAST_FAIL_CORRUPT_LIST_ENTRY = 3;

        public const uint FAST_FAIL_INCORRECT_STACK = 4;

        public const uint FAST_FAIL_INVALID_ARG = 5;

        public const uint FAST_FAIL_GS_COOKIE_INIT = 6;

        public const uint FAST_FAIL_FATAL_APP_EXIT = 7;

        public const uint FAST_FAIL_RANGE_CHECK_FAILURE = 8;

        public const uint FAST_FAIL_UNSAFE_REGISTRY_ACCESS = 9;

        public const uint FAST_FAIL_GUARD_ICALL_CHECK_FAILURE = 10;

        public const uint FAST_FAIL_GUARD_WRITE_CHECK_FAILURE = 11;

        public const uint FAST_FAIL_INVALID_FIBER_SWITCH = 12;

        public const uint FAST_FAIL_INVALID_SET_OF_CONTEXT = 13;

        public const uint FAST_FAIL_INVALID_REFERENCE_COUNT = 14;

        public const uint FAST_FAIL_INVALID_JUMP_BUFFER = 18;

        public const uint FAST_FAIL_MRDATA_MODIFIED = 19;

        public const uint FAST_FAIL_CERTIFICATION_FAILURE = 20;

        public const uint FAST_FAIL_INVALID_EXCEPTION_CHAIN = 21;

        public const uint FAST_FAIL_CRYPTO_LIBRARY = 22;

        public const uint FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT = 23;

        public const uint FAST_FAIL_INVALID_IMAGE_BASE = 24;

        public const uint FAST_FAIL_DLOAD_PROTECTION_FAILURE = 25;

        public const uint FAST_FAIL_UNSAFE_EXTENSION_CALL = 26;

        public const uint FAST_FAIL_DEPRECATED_SERVICE_INVOKED = 27;

        public const uint FAST_FAIL_INVALID_BUFFER_ACCESS = 28;

        public const uint FAST_FAIL_INVALID_BALANCED_TREE = 29;

        public const uint FAST_FAIL_INVALID_NEXT_THREAD = 30;

        public const uint FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED = 31;

        public const uint FAST_FAIL_APCS_DISABLED = 32;

        public const uint FAST_FAIL_INVALID_IDLE_STATE = 33;

        public const uint FAST_FAIL_MRDATA_PROTECTION_FAILURE = 34;

        public const uint FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION = 35;

        public const uint FAST_FAIL_INVALID_LOCK_STATE = 36;

        public const uint FAST_FAIL_GUARD_JUMPTABLE = 37;

        public const uint FAST_FAIL_INVALID_LONGJUMP_TARGET = 38;

        public const uint FAST_FAIL_INVALID_DISPATCH_CONTEXT = 39;

        public const uint FAST_FAIL_INVALID_THREAD = 40;

        public const uint FAST_FAIL_INVALID_SYSCALL_NUMBER = 41;

        public const uint FAST_FAIL_INVALID_FILE_OPERATION = 42;

        public const uint FAST_FAIL_LPAC_ACCESS_DENIED = 43;

        public const uint FAST_FAIL_GUARD_SS_FAILURE = 44;

        public const uint FAST_FAIL_LOADER_CONTINUITY_FAILURE = 45;

        public const uint FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE = 46;

        public const uint FAST_FAIL_INVALID_CONTROL_STACK = 47;

        public const uint FAST_FAIL_SET_CONTEXT_DENIED = 48;

        public const uint FAST_FAIL_INVALID_IAT = 49;

        public const uint FAST_FAIL_HEAP_METADATA_CORRUPTION = 50;

        public const uint FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION = 51;

        public const uint FAST_FAIL_LOW_LABEL_ACCESS_DENIED = 52;

        public const uint FAST_FAIL_ENCLAVE_CALL_FAILURE = 53;

        public const uint FAST_FAIL_UNHANDLED_LSS_EXCEPTON = 54;

        public const uint FAST_FAIL_ADMINLESS_ACCESS_DENIED = 55;

        public const uint FAST_FAIL_UNEXPECTED_CALL = 56;

        public const uint FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS = 57;

        public const uint FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR = 58;

        public const uint FAST_FAIL_FLAGS_CORRUPTION = 59;

        public const uint FAST_FAIL_INVALID_FAST_FAIL_CODE = 0xFFFFFFFF;

        public const int HEAP_NO_SERIALIZE = 0x00000001;

        public const int HEAP_GROWABLE = 0x00000002;

        public const int HEAP_GENERATE_EXCEPTIONS = 0x00000004;

        public const int HEAP_ZERO_MEMORY = 0x00000008;

        public const int HEAP_REALLOC_IN_PLACE_ONLY = 0x00000010;

        public const int HEAP_TAIL_CHECKING_ENABLED = 0x00000020;

        public const int HEAP_FREE_CHECKING_ENABLED = 0x00000040;

        public const int HEAP_DISABLE_COALESCE_ON_FREE = 0x00000080;

        public const int HEAP_CREATE_ALIGN_16 = 0x00010000;

        public const int HEAP_CREATE_ENABLE_TRACING = 0x00020000;

        public const int HEAP_CREATE_ENABLE_EXECUTE = 0x00040000;

        public const int HEAP_MAXIMUM_TAG = 0x0FFF;

        public const int HEAP_PSEUDO_TAG_FLAG = 0x8000;

        public const int HEAP_TAG_SHIFT = 18;

        public const int HEAP_CREATE_SEGMENT_HEAP = 0x00000100;

        public const int HEAP_CREATE_HARDENED = 0x00000200;

        public const int IS_TEXT_UNICODE_ASCII16 = 0x0001;

        public const int IS_TEXT_UNICODE_REVERSE_ASCII16 = 0x0010;

        public const int IS_TEXT_UNICODE_STATISTICS = 0x0002;

        public const int IS_TEXT_UNICODE_REVERSE_STATISTICS = 0x0020;

        public const int IS_TEXT_UNICODE_CONTROLS = 0x0004;

        public const int IS_TEXT_UNICODE_REVERSE_CONTROLS = 0x0040;

        public const int IS_TEXT_UNICODE_SIGNATURE = 0x0008;

        public const int IS_TEXT_UNICODE_REVERSE_SIGNATURE = 0x0080;

        public const int IS_TEXT_UNICODE_ILLEGAL_CHARS = 0x0100;

        public const int IS_TEXT_UNICODE_ODD_LENGTH = 0x0200;

        public const int IS_TEXT_UNICODE_DBCS_LEADBYTE = 0x0400;

        public const int IS_TEXT_UNICODE_NULL_BYTES = 0x1000;

        public const int IS_TEXT_UNICODE_UNICODE_MASK = 0x000F;

        public const int IS_TEXT_UNICODE_REVERSE_MASK = 0x00F0;

        public const int IS_TEXT_UNICODE_NOT_UNICODE_MASK = 0x0F00;

        public const int IS_TEXT_UNICODE_NOT_ASCII_MASK = 0xF000;

        public const int SEF_DACL_AUTO_INHERIT = 0x01;

        public const int SEF_SACL_AUTO_INHERIT = 0x02;

        public const int SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT = 0x04;

        public const int SEF_AVOID_PRIVILEGE_CHECK = 0x08;

        public const int SEF_AVOID_OWNER_CHECK = 0x10;

        public const int SEF_DEFAULT_OWNER_FROM_PARENT = 0x20;

        public const int SEF_DEFAULT_GROUP_FROM_PARENT = 0x40;

        public const int SEF_MACL_NO_WRITE_UP = 0x100;

        public const int SEF_MACL_NO_READ_UP = 0x200;

        public const int SEF_MACL_NO_EXECUTE_UP = 0x400;

        public const int SEF_AI_USE_EXTRA_PARAMS = 0x800;

        public const int SEF_AVOID_OWNER_RESTRICTION = 0x1000;

        public const int SEF_FORCE_USER_MODE = 0x2000;

        public const int MESSAGE_RESOURCE_UNICODE = 0x0001;

        public const int VER_EQUAL = 1;

        public const int VER_GREATER = 2;

        public const int VER_GREATER_EQUAL = 3;

        public const int VER_LESS = 4;

        public const int VER_LESS_EQUAL = 5;

        public const int VER_AND = 6;

        public const int VER_OR = 7;

        public const int VER_CONDITION_MASK = 7;

        public const int VER_NUM_BITS_PER_CONDITION_MASK = 3;

        public const int VER_MINORVERSION = 0x0000001;

        public const int VER_MAJORVERSION = 0x0000002;

        public const int VER_BUILDNUMBER = 0x0000004;

        public const int VER_PLATFORMID = 0x0000008;

        public const int VER_SERVICEPACKMINOR = 0x0000010;

        public const int VER_SERVICEPACKMAJOR = 0x0000020;

        public const int VER_SUITENAME = 0x0000040;

        public const int VER_PRODUCT_TYPE = 0x0000080;

        public const int VER_NT_WORKSTATION = 0x0000001;

        public const int VER_NT_DOMAIN_CONTROLLER = 0x0000002;

        public const int VER_NT_SERVER = 0x0000003;

        public const int VER_PLATFORM_WIN32s = 0;

        public const int VER_PLATFORM_WIN32_WINDOWS = 1;

        public const int VER_PLATFORM_WIN32_NT = 2;

        public const uint CTMF_INCLUDE_APPCONTAINER = 0x00000001;

        public const uint CTMF_INCLUDE_LPAC = 0x00000002;

        public const int RTL_CORRELATION_VECTOR_STRING_LENGTH = 129;

        public const int IMAGE_POLICY_METADATA_VERSION = 1;

        // .tPolicy
        public static ReadOnlySpan<sbyte> IMAGE_POLICY_SECTION_NAME => new sbyte[] { 0x2E, 0x74, 0x50, 0x6F, 0x6C, 0x69, 0x63, 0x79, 0x00 };

        public const uint RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO = 0x01000000;

        public const uint RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN = 0x02000000;

        public const uint RTL_CRITICAL_SECTION_FLAG_STATIC_INIT = 0x04000000;

        public const uint RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE = 0x08000000;

        public const uint RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO = 0x10000000;

        public const uint RTL_CRITICAL_SECTION_ALL_FLAG_BITS = 0xFF000000;

        public const uint RTL_CRITICAL_SECTION_DEBUG_FLAG_STATIC_INIT = 0x00000001;

        public const int RTL_CONDITION_VARIABLE_LOCKMODE_SHARED = 0x1;

        public const int HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION = 1;

        public const int WT_EXECUTEDEFAULT = 0x00000000;

        public const int WT_EXECUTEINIOTHREAD = 0x00000001;

        public const int WT_EXECUTEINUITHREAD = 0x00000002;

        public const int WT_EXECUTEINWAITTHREAD = 0x00000004;

        public const int WT_EXECUTEONLYONCE = 0x00000008;

        public const int WT_EXECUTEINTIMERTHREAD = 0x00000020;

        public const int WT_EXECUTELONGFUNCTION = 0x00000010;

        public const int WT_EXECUTEINPERSISTENTIOTHREAD = 0x00000040;

        public const int WT_EXECUTEINPERSISTENTTHREAD = 0x00000080;

        public const int WT_TRANSFER_IMPERSONATION = 0x00000100;

        public const int WT_EXECUTEINLONGTHREAD = 0x00000010;

        public const int WT_EXECUTEDELETEWAIT = 0x00000008;

        public const int CREATE_BOUNDARY_DESCRIPTOR_ADD_APPCONTAINER_SID = 0x1;

        public const int PERFORMANCE_DATA_VERSION = 1;

        public const int READ_THREAD_PROFILING_FLAG_DISPATCHING = 0x00000001;

        public const int READ_THREAD_PROFILING_FLAG_HARDWARE_COUNTERS = 0x00000002;

        public const string UNIFIEDBUILDREVISION_KEY = "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion";

        public const string UNIFIEDBUILDREVISION_VALUE = "UBR";

        public const int UNIFIEDBUILDREVISION_MIN = 0x00000000;

        public const string DEVICEFAMILYDEVICEFORM_KEY = "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion\\OEM";

        public const string DEVICEFAMILYDEVICEFORM_VALUE = "DeviceForm";

        public const int DEVICEFAMILYINFOENUM_UAP = 0x00000000;

        public const int DEVICEFAMILYINFOENUM_WINDOWS_8X = 0x00000001;

        public const int DEVICEFAMILYINFOENUM_WINDOWS_PHONE_8X = 0x00000002;

        public const int DEVICEFAMILYINFOENUM_DESKTOP = 0x00000003;

        public const int DEVICEFAMILYINFOENUM_MOBILE = 0x00000004;

        public const int DEVICEFAMILYINFOENUM_XBOX = 0x00000005;

        public const int DEVICEFAMILYINFOENUM_TEAM = 0x00000006;

        public const int DEVICEFAMILYINFOENUM_IOT = 0x00000007;

        public const int DEVICEFAMILYINFOENUM_IOT_HEADLESS = 0x00000008;

        public const int DEVICEFAMILYINFOENUM_SERVER = 0x00000009;

        public const int DEVICEFAMILYINFOENUM_HOLOGRAPHIC = 0x0000000A;

        public const int DEVICEFAMILYINFOENUM_XBOXSRA = 0x0000000B;

        public const int DEVICEFAMILYINFOENUM_XBOXERA = 0x0000000C;

        public const int DEVICEFAMILYINFOENUM_SERVER_NANO = 0x0000000D;

        public const int DEVICEFAMILYINFOENUM_8828080 = 0x0000000E;

        public const int DEVICEFAMILYINFOENUM_7067329 = 0x0000000F;

        public const int DEVICEFAMILYINFOENUM_WINDOWS_CORE = 0x00000010;

        public const int DEVICEFAMILYINFOENUM_WINDOWS_CORE_HEADLESS = 0x00000011;

        public const int DEVICEFAMILYINFOENUM_MAX = 0x00000011;

        public const int DEVICEFAMILYDEVICEFORM_UNKNOWN = 0x00000000;

        public const int DEVICEFAMILYDEVICEFORM_PHONE = 0x00000001;

        public const int DEVICEFAMILYDEVICEFORM_TABLET = 0x00000002;

        public const int DEVICEFAMILYDEVICEFORM_DESKTOP = 0x00000003;

        public const int DEVICEFAMILYDEVICEFORM_NOTEBOOK = 0x00000004;

        public const int DEVICEFAMILYDEVICEFORM_CONVERTIBLE = 0x00000005;

        public const int DEVICEFAMILYDEVICEFORM_DETACHABLE = 0x00000006;

        public const int DEVICEFAMILYDEVICEFORM_ALLINONE = 0x00000007;

        public const int DEVICEFAMILYDEVICEFORM_STICKPC = 0x00000008;

        public const int DEVICEFAMILYDEVICEFORM_PUCK = 0x00000009;

        public const int DEVICEFAMILYDEVICEFORM_LARGESCREEN = 0x0000000A;

        public const int DEVICEFAMILYDEVICEFORM_HMD = 0x0000000B;

        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_HANDHELD = 0x0000000C;

        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_TABLET = 0x0000000D;

        public const int DEVICEFAMILYDEVICEFORM_BANKING = 0x0000000E;

        public const int DEVICEFAMILYDEVICEFORM_BUILDING_AUTOMATION = 0x0000000F;

        public const int DEVICEFAMILYDEVICEFORM_DIGITAL_SIGNAGE = 0x00000010;

        public const int DEVICEFAMILYDEVICEFORM_GAMING = 0x00000011;

        public const int DEVICEFAMILYDEVICEFORM_HOME_AUTOMATION = 0x00000012;

        public const int DEVICEFAMILYDEVICEFORM_INDUSTRIAL_AUTOMATION = 0x00000013;

        public const int DEVICEFAMILYDEVICEFORM_KIOSK = 0x00000014;

        public const int DEVICEFAMILYDEVICEFORM_MAKER_BOARD = 0x00000015;

        public const int DEVICEFAMILYDEVICEFORM_MEDICAL = 0x00000016;

        public const int DEVICEFAMILYDEVICEFORM_NETWORKING = 0x00000017;

        public const int DEVICEFAMILYDEVICEFORM_POINT_OF_SERVICE = 0x00000018;

        public const int DEVICEFAMILYDEVICEFORM_PRINTING = 0x00000019;

        public const int DEVICEFAMILYDEVICEFORM_THIN_CLIENT = 0x0000001A;

        public const int DEVICEFAMILYDEVICEFORM_TOY = 0x0000001B;

        public const int DEVICEFAMILYDEVICEFORM_VENDING = 0x0000001C;

        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_OTHER = 0x0000001D;

        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE = 0x0000001E;

        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_S = 0x0000001F;

        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_X = 0x00000020;

        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_X_DEVKIT = 0x00000021;

        public const int DEVICEFAMILYDEVICEFORM_MAX = 0x00000021;

        public const int DLL_PROCESS_ATTACH = 1;

        public const int DLL_THREAD_ATTACH = 2;

        public const int DLL_THREAD_DETACH = 3;

        public const int DLL_PROCESS_DETACH = 0;

        public const int EVENTLOG_SEQUENTIAL_READ = 0x0001;

        public const int EVENTLOG_SEEK_READ = 0x0002;

        public const int EVENTLOG_FORWARDS_READ = 0x0004;

        public const int EVENTLOG_BACKWARDS_READ = 0x0008;

        public const int EVENTLOG_SUCCESS = 0x0000;

        public const int EVENTLOG_ERROR_TYPE = 0x0001;

        public const int EVENTLOG_WARNING_TYPE = 0x0002;

        public const int EVENTLOG_INFORMATION_TYPE = 0x0004;

        public const int EVENTLOG_AUDIT_SUCCESS = 0x0008;

        public const int EVENTLOG_AUDIT_FAILURE = 0x0010;

        public const int EVENTLOG_START_PAIRED_EVENT = 0x0001;

        public const int EVENTLOG_END_PAIRED_EVENT = 0x0002;

        public const int EVENTLOG_END_ALL_PAIRED_EVENTS = 0x0004;

        public const int EVENTLOG_PAIRED_EVENT_ACTIVE = 0x0008;

        public const int EVENTLOG_PAIRED_EVENT_INACTIVE = 0x0010;

        public const int MAXLOGICALLOGNAMESIZE = 256;

        public const int REG_STANDARD_FORMAT = 1;

        public const int REG_LATEST_FORMAT = 2;

        public const int REG_NO_COMPRESSION = 4;

        public const int REG_FORCE_UNLOAD = 1;

        public const int SERVICE_KERNEL_DRIVER = 0x00000001;

        public const int SERVICE_FILE_SYSTEM_DRIVER = 0x00000002;

        public const int SERVICE_ADAPTER = 0x00000004;

        public const int SERVICE_RECOGNIZER_DRIVER = 0x00000008;

        public const int SERVICE_WIN32_OWN_PROCESS = 0x00000010;

        public const int SERVICE_WIN32_SHARE_PROCESS = 0x00000020;

        public const int SERVICE_USER_SERVICE = 0x00000040;

        public const int SERVICE_USERSERVICE_INSTANCE = 0x00000080;

        public const int SERVICE_INTERACTIVE_PROCESS = 0x00000100;

        public const int SERVICE_PKG_SERVICE = 0x00000200;

        public const int SERVICE_BOOT_START = 0x00000000;

        public const int SERVICE_SYSTEM_START = 0x00000001;

        public const int SERVICE_AUTO_START = 0x00000002;

        public const int SERVICE_DEMAND_START = 0x00000003;

        public const int SERVICE_DISABLED = 0x00000004;

        public const int SERVICE_ERROR_IGNORE = 0x00000000;

        public const int SERVICE_ERROR_NORMAL = 0x00000001;

        public const int SERVICE_ERROR_SEVERE = 0x00000002;

        public const int SERVICE_ERROR_CRITICAL = 0x00000003;

        public const int CM_SERVICE_NETWORK_BOOT_LOAD = 0x00000001;

        public const int CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD = 0x00000002;

        public const int CM_SERVICE_USB_DISK_BOOT_LOAD = 0x00000004;

        public const int CM_SERVICE_SD_DISK_BOOT_LOAD = 0x00000008;

        public const int CM_SERVICE_USB3_DISK_BOOT_LOAD = 0x00000010;

        public const int CM_SERVICE_MEASURED_BOOT_LOAD = 0x00000020;

        public const int CM_SERVICE_VERIFIER_BOOT_LOAD = 0x00000040;

        public const int CM_SERVICE_WINPE_BOOT_LOAD = 0x00000080;

        public const int CM_SERVICE_RAM_DISK_BOOT_LOAD = 0x00000100;

        public const int TAPE_ERASE_SHORT = 0;

        public const int TAPE_ERASE_LONG = 1;

        public const int TAPE_LOAD = 0;

        public const int TAPE_UNLOAD = 1;

        public const int TAPE_TENSION = 2;

        public const int TAPE_LOCK = 3;

        public const int TAPE_UNLOCK = 4;

        public const int TAPE_FORMAT = 5;

        public const int TAPE_SETMARKS = 0;

        public const int TAPE_FILEMARKS = 1;

        public const int TAPE_SHORT_FILEMARKS = 2;

        public const int TAPE_LONG_FILEMARKS = 3;

        public const int TAPE_ABSOLUTE_POSITION = 0;

        public const int TAPE_LOGICAL_POSITION = 1;

        public const int TAPE_PSEUDO_LOGICAL_POSITION = 2;

        public const int TAPE_REWIND = 0;

        public const int TAPE_ABSOLUTE_BLOCK = 1;

        public const int TAPE_LOGICAL_BLOCK = 2;

        public const int TAPE_PSEUDO_LOGICAL_BLOCK = 3;

        public const int TAPE_SPACE_END_OF_DATA = 4;

        public const int TAPE_SPACE_RELATIVE_BLOCKS = 5;

        public const int TAPE_SPACE_FILEMARKS = 6;

        public const int TAPE_SPACE_SEQUENTIAL_FMKS = 7;

        public const int TAPE_SPACE_SETMARKS = 8;

        public const int TAPE_SPACE_SEQUENTIAL_SMKS = 9;

        public const uint TAPE_DRIVE_FIXED = 0x00000001;

        public const uint TAPE_DRIVE_SELECT = 0x00000002;

        public const uint TAPE_DRIVE_INITIATOR = 0x00000004;

        public const uint TAPE_DRIVE_ERASE_SHORT = 0x00000010;

        public const uint TAPE_DRIVE_ERASE_LONG = 0x00000020;

        public const uint TAPE_DRIVE_ERASE_BOP_ONLY = 0x00000040;

        public const uint TAPE_DRIVE_ERASE_IMMEDIATE = 0x00000080;

        public const uint TAPE_DRIVE_TAPE_CAPACITY = 0x00000100;

        public const uint TAPE_DRIVE_TAPE_REMAINING = 0x00000200;

        public const uint TAPE_DRIVE_FIXED_BLOCK = 0x00000400;

        public const uint TAPE_DRIVE_VARIABLE_BLOCK = 0x00000800;

        public const uint TAPE_DRIVE_WRITE_PROTECT = 0x00001000;

        public const uint TAPE_DRIVE_EOT_WZ_SIZE = 0x00002000;

        public const uint TAPE_DRIVE_ECC = 0x00010000;

        public const uint TAPE_DRIVE_COMPRESSION = 0x00020000;

        public const uint TAPE_DRIVE_PADDING = 0x00040000;

        public const uint TAPE_DRIVE_REPORT_SMKS = 0x00080000;

        public const uint TAPE_DRIVE_GET_ABSOLUTE_BLK = 0x00100000;

        public const uint TAPE_DRIVE_GET_LOGICAL_BLK = 0x00200000;

        public const uint TAPE_DRIVE_SET_EOT_WZ_SIZE = 0x00400000;

        public const uint TAPE_DRIVE_EJECT_MEDIA = 0x01000000;

        public const uint TAPE_DRIVE_CLEAN_REQUESTS = 0x02000000;

        public const uint TAPE_DRIVE_SET_CMP_BOP_ONLY = 0x04000000;

        public const uint TAPE_DRIVE_RESERVED_BIT = 0x80000000;

        public const uint TAPE_DRIVE_LOAD_UNLOAD = 0x80000001;

        public const uint TAPE_DRIVE_TENSION = 0x80000002;

        public const uint TAPE_DRIVE_LOCK_UNLOCK = 0x80000004;

        public const uint TAPE_DRIVE_REWIND_IMMEDIATE = 0x80000008;

        public const uint TAPE_DRIVE_SET_BLOCK_SIZE = 0x80000010;

        public const uint TAPE_DRIVE_LOAD_UNLD_IMMED = 0x80000020;

        public const uint TAPE_DRIVE_TENSION_IMMED = 0x80000040;

        public const uint TAPE_DRIVE_LOCK_UNLK_IMMED = 0x80000080;

        public const uint TAPE_DRIVE_SET_ECC = 0x80000100;

        public const uint TAPE_DRIVE_SET_COMPRESSION = 0x80000200;

        public const uint TAPE_DRIVE_SET_PADDING = 0x80000400;

        public const uint TAPE_DRIVE_SET_REPORT_SMKS = 0x80000800;

        public const uint TAPE_DRIVE_ABSOLUTE_BLK = 0x80001000;

        public const uint TAPE_DRIVE_ABS_BLK_IMMED = 0x80002000;

        public const uint TAPE_DRIVE_LOGICAL_BLK = 0x80004000;

        public const uint TAPE_DRIVE_LOG_BLK_IMMED = 0x80008000;

        public const uint TAPE_DRIVE_END_OF_DATA = 0x80010000;

        public const uint TAPE_DRIVE_RELATIVE_BLKS = 0x80020000;

        public const uint TAPE_DRIVE_FILEMARKS = 0x80040000;

        public const uint TAPE_DRIVE_SEQUENTIAL_FMKS = 0x80080000;

        public const uint TAPE_DRIVE_SETMARKS = 0x80100000;

        public const uint TAPE_DRIVE_SEQUENTIAL_SMKS = 0x80200000;

        public const uint TAPE_DRIVE_REVERSE_POSITION = 0x80400000;

        public const uint TAPE_DRIVE_SPACE_IMMEDIATE = 0x80800000;

        public const uint TAPE_DRIVE_WRITE_SETMARKS = 0x81000000;

        public const uint TAPE_DRIVE_WRITE_FILEMARKS = 0x82000000;

        public const uint TAPE_DRIVE_WRITE_SHORT_FMKS = 0x84000000;

        public const uint TAPE_DRIVE_WRITE_LONG_FMKS = 0x88000000;

        public const uint TAPE_DRIVE_WRITE_MARK_IMMED = 0x90000000;

        public const uint TAPE_DRIVE_FORMAT = 0xA0000000;

        public const uint TAPE_DRIVE_FORMAT_IMMEDIATE = 0xC0000000;

        public const uint TAPE_DRIVE_HIGH_FEATURES = 0x80000000;

        public const int TAPE_FIXED_PARTITIONS = 0;

        public const int TAPE_SELECT_PARTITIONS = 1;

        public const int TAPE_INITIATOR_PARTITIONS = 2;

        public const int TAPE_QUERY_DRIVE_PARAMETERS = 0;

        public const int TAPE_QUERY_MEDIA_CAPACITY = 1;

        public const int TAPE_CHECK_FOR_DRIVE_PROBLEM = 2;

        public const int TAPE_QUERY_IO_ERROR_DATA = 3;

        public const int TAPE_QUERY_DEVICE_ERROR_DATA = 4;

        public const int PcTeb = 0x18;

        public const uint UCSCHAR_INVALID_CHARACTER = 0xffffffff;

        public const uint MIN_UCSCHAR = 0;

        public const uint MAX_UCSCHAR = 0x0010FFFF;

        public const long MAXLONGLONG = 0x7fffffffffffffff;

        public const sbyte ANSI_NULL = 0;

        public const ushort UNICODE_NULL = 0;

        public const ushort UNICODE_STRING_MAX_BYTES = 65534;

        public const ushort UNICODE_STRING_MAX_CHARS = 32767;

        public const uint STATUS_WAIT_0 = 0x00000000;

        public const uint STATUS_ABANDONED_WAIT_0 = 0x00000080;

        public const uint STATUS_USER_APC = 0x000000C0;

        public const uint STATUS_TIMEOUT = 0x00000102;

        public const uint STATUS_PENDING = 0x00000103;

        public const uint DBG_EXCEPTION_HANDLED = 0x00010001;

        public const uint DBG_CONTINUE = 0x00010002;

        public const uint STATUS_SEGMENT_NOTIFICATION = 0x40000005;

        public const uint STATUS_FATAL_APP_EXIT = 0x40000015;

        public const uint DBG_REPLY_LATER = 0x40010001;

        public const uint DBG_TERMINATE_THREAD = 0x40010003;

        public const uint DBG_TERMINATE_PROCESS = 0x40010004;

        public const uint DBG_CONTROL_C = 0x40010005;

        public const uint DBG_PRINTEXCEPTION_C = 0x40010006;

        public const uint DBG_RIPEXCEPTION = 0x40010007;

        public const uint DBG_CONTROL_BREAK = 0x40010008;

        public const uint DBG_COMMAND_EXCEPTION = 0x40010009;

        public const uint DBG_PRINTEXCEPTION_WIDE_C = 0x4001000A;

        public const uint STATUS_GUARD_PAGE_VIOLATION = 0x80000001;

        public const uint STATUS_DATATYPE_MISALIGNMENT = 0x80000002;

        public const uint STATUS_BREAKPOINT = 0x80000003;

        public const uint STATUS_SINGLE_STEP = 0x80000004;

        public const uint STATUS_LONGJUMP = 0x80000026;

        public const uint STATUS_UNWIND_CONSOLIDATE = 0x80000029;

        public const uint DBG_EXCEPTION_NOT_HANDLED = 0x80010001;

        public const uint STATUS_ACCESS_VIOLATION = 0xC0000005;

        public const uint STATUS_IN_PAGE_ERROR = 0xC0000006;

        public const uint STATUS_INVALID_HANDLE = 0xC0000008;

        public const uint STATUS_INVALID_PARAMETER = 0xC000000D;

        public const uint STATUS_NO_MEMORY = 0xC0000017;

        public const uint STATUS_ILLEGAL_INSTRUCTION = 0xC000001D;

        public const uint STATUS_NONCONTINUABLE_EXCEPTION = 0xC0000025;

        public const uint STATUS_INVALID_DISPOSITION = 0xC0000026;

        public const uint STATUS_ARRAY_BOUNDS_EXCEEDED = 0xC000008C;

        public const uint STATUS_FLOAT_DENORMAL_OPERAND = 0xC000008D;

        public const uint STATUS_FLOAT_DIVIDE_BY_ZERO = 0xC000008E;

        public const uint STATUS_FLOAT_INEXACT_RESULT = 0xC000008F;

        public const uint STATUS_FLOAT_INVALID_OPERATION = 0xC0000090;

        public const uint STATUS_FLOAT_OVERFLOW = 0xC0000091;

        public const uint STATUS_FLOAT_STACK_CHECK = 0xC0000092;

        public const uint STATUS_FLOAT_UNDERFLOW = 0xC0000093;

        public const uint STATUS_INTEGER_DIVIDE_BY_ZERO = 0xC0000094;

        public const uint STATUS_INTEGER_OVERFLOW = 0xC0000095;

        public const uint STATUS_PRIVILEGED_INSTRUCTION = 0xC0000096;

        public const uint STATUS_STACK_OVERFLOW = 0xC00000FD;

        public const uint STATUS_DLL_NOT_FOUND = 0xC0000135;

        public const uint STATUS_ORDINAL_NOT_FOUND = 0xC0000138;

        public const uint STATUS_ENTRYPOINT_NOT_FOUND = 0xC0000139;

        public const uint STATUS_CONTROL_C_EXIT = 0xC000013A;

        public const uint STATUS_DLL_INIT_FAILED = 0xC0000142;

        public const uint STATUS_FLOAT_MULTIPLE_FAULTS = 0xC00002B4;

        public const uint STATUS_FLOAT_MULTIPLE_TRAPS = 0xC00002B5;

        public const uint STATUS_REG_NAT_CONSUMPTION = 0xC00002C9;

        public const uint STATUS_HEAP_CORRUPTION = 0xC0000374;

        public const uint STATUS_STACK_BUFFER_OVERRUN = 0xC0000409;

        public const uint STATUS_INVALID_CRUNTIME_PARAMETER = 0xC0000417;

        public const uint STATUS_ASSERTION_FAILURE = 0xC0000420;

        public const uint STATUS_ENCLAVE_VIOLATION = 0xC00004A2;

        public const uint STATUS_INTERRUPTED = 0xC0000515;

        public const uint STATUS_THREAD_NOT_RUNNING = 0xC0000516;

        public const uint STATUS_ALREADY_REGISTERED = 0xC0000718;

        public const uint STATUS_SXS_EARLY_DEACTIVATION = 0xC015000F;

        public const uint STATUS_SXS_INVALID_DEACTIVATION = 0xC0150010;

        public const sbyte MAXIMUM_SUSPEND_COUNT = MAXCHAR;

        public const int EXCEPTION_UNWIND = EXCEPTION_UNWINDING | EXCEPTION_EXIT_UNWIND | EXCEPTION_TARGET_UNWIND | EXCEPTION_COLLIDED_UNWIND;

        public const uint DELETE = 0x00010000;

        public const uint READ_CONTROL = 0x00020000;

        public const uint WRITE_DAC = 0x00040000;

        public const uint WRITE_OWNER = 0x00080000;

        public const uint SYNCHRONIZE = 0x00100000;

        public const uint STANDARD_RIGHTS_REQUIRED = 0x000F0000;

        public const uint STANDARD_RIGHTS_READ = READ_CONTROL;

        public const uint STANDARD_RIGHTS_WRITE = READ_CONTROL;

        public const uint STANDARD_RIGHTS_EXECUTE = READ_CONTROL;

        public const uint STANDARD_RIGHTS_ALL = 0x001F0000;

        public const uint SPECIFIC_RIGHTS_ALL = 0x0000FFFF;

        public const uint ACCESS_SYSTEM_SECURITY = 0x01000000;

        public const uint MAXIMUM_ALLOWED = 0x02000000;

        public const uint GENERIC_READ = 0x80000000;

        public const uint GENERIC_WRITE = 0x40000000;

        public const uint GENERIC_EXECUTE = 0x20000000;

        public const uint GENERIC_ALL = 0x10000000;

        public const uint SID_REVISION = 1;

        public const uint SID_MAX_SUB_AUTHORITIES = 15;

        public const uint SID_RECOMMENDED_SUB_AUTHORITIES = 1;

        public const int SECURITY_NULL_RID = 0x00000000;

        public const int SECURITY_WORLD_RID = 0x00000000;

        public const int SECURITY_LOCAL_RID = 0x00000000;

        public const int SECURITY_LOCAL_LOGON_RID = 0x00000001;

        public const int SECURITY_CREATOR_OWNER_RID = 0x00000000;

        public const int SECURITY_CREATOR_GROUP_RID = 0x00000001;

        public const int SECURITY_CREATOR_OWNER_SERVER_RID = 0x00000002;

        public const int SECURITY_CREATOR_GROUP_SERVER_RID = 0x00000003;

        public const int SECURITY_CREATOR_OWNER_RIGHTS_RID = 0x00000004;

        public const int SECURITY_DIALUP_RID = 0x00000001;

        public const int SECURITY_NETWORK_RID = 0x00000002;

        public const int SECURITY_BATCH_RID = 0x00000003;

        public const int SECURITY_INTERACTIVE_RID = 0x00000004;

        public const int SECURITY_LOGON_IDS_RID = 0x00000005;

        public const int SECURITY_LOGON_IDS_RID_COUNT = 3;

        public const int SECURITY_SERVICE_RID = 0x00000006;

        public const int SECURITY_ANONYMOUS_LOGON_RID = 0x00000007;

        public const int SECURITY_PROXY_RID = 0x00000008;

        public const int SECURITY_ENTERPRISE_CONTROLLERS_RID = 0x00000009;

        public const int SECURITY_SERVER_LOGON_RID = SECURITY_ENTERPRISE_CONTROLLERS_RID;

        public const int SECURITY_PRINCIPAL_SELF_RID = 0x0000000A;

        public const int SECURITY_AUTHENTICATED_USER_RID = 0x0000000B;

        public const int SECURITY_RESTRICTED_CODE_RID = 0x0000000C;

        public const int SECURITY_TERMINAL_SERVER_RID = 0x0000000D;

        public const int SECURITY_REMOTE_LOGON_RID = 0x0000000E;

        public const int SECURITY_THIS_ORGANIZATION_RID = 0x0000000F;

        public const int SECURITY_IUSER_RID = 0x00000011;

        public const int SECURITY_LOCAL_SYSTEM_RID = 0x00000012;

        public const int SECURITY_LOCAL_SERVICE_RID = 0x00000013;

        public const int SECURITY_NETWORK_SERVICE_RID = 0x00000014;

        public const int SECURITY_NT_NON_UNIQUE = 0x00000015;

        public const int SECURITY_NT_NON_UNIQUE_SUB_AUTH_COUNT = 3;

        public const int SECURITY_ENTERPRISE_READONLY_CONTROLLERS_RID = 0x00000016;

        public const int SECURITY_BUILTIN_DOMAIN_RID = 0x00000020;

        public const int SECURITY_WRITE_RESTRICTED_CODE_RID = 0x00000021;

        public const int SECURITY_PACKAGE_BASE_RID = 0x00000040;

        public const int SECURITY_PACKAGE_RID_COUNT = 2;

        public const int SECURITY_PACKAGE_NTLM_RID = 0x0000000A;

        public const int SECURITY_PACKAGE_SCHANNEL_RID = 0x0000000E;

        public const int SECURITY_PACKAGE_DIGEST_RID = 0x00000015;

        public const int SECURITY_CRED_TYPE_BASE_RID = 0x00000041;

        public const int SECURITY_CRED_TYPE_RID_COUNT = 2;

        public const int SECURITY_CRED_TYPE_THIS_ORG_CERT_RID = 0x00000001;

        public const int SECURITY_MIN_BASE_RID = 0x00000050;

        public const int SECURITY_SERVICE_ID_BASE_RID = 0x00000050;

        public const int SECURITY_SERVICE_ID_RID_COUNT = 6;

        public const int SECURITY_RESERVED_ID_BASE_RID = 0x00000051;

        public const int SECURITY_APPPOOL_ID_BASE_RID = 0x00000052;

        public const int SECURITY_APPPOOL_ID_RID_COUNT = 6;

        public const int SECURITY_VIRTUALSERVER_ID_BASE_RID = 0x00000053;

        public const int SECURITY_VIRTUALSERVER_ID_RID_COUNT = 6;

        public const int SECURITY_USERMODEDRIVERHOST_ID_BASE_RID = 0x00000054;

        public const int SECURITY_USERMODEDRIVERHOST_ID_RID_COUNT = 6;

        public const int SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_BASE_RID = 0x00000055;

        public const int SECURITY_CLOUD_INFRASTRUCTURE_SERVICES_ID_RID_COUNT = 6;

        public const int SECURITY_WMIHOST_ID_BASE_RID = 0x00000056;

        public const int SECURITY_WMIHOST_ID_RID_COUNT = 6;

        public const int SECURITY_TASK_ID_BASE_RID = 0x00000057;

        public const int SECURITY_NFS_ID_BASE_RID = 0x00000058;

        public const int SECURITY_COM_ID_BASE_RID = 0x00000059;

        public const int SECURITY_WINDOW_MANAGER_BASE_RID = 0x0000005A;

        public const int SECURITY_RDV_GFX_BASE_RID = 0x0000005B;

        public const int SECURITY_DASHOST_ID_BASE_RID = 0x0000005C;

        public const int SECURITY_DASHOST_ID_RID_COUNT = 6;

        public const int SECURITY_USERMANAGER_ID_BASE_RID = 0x0000005D;

        public const int SECURITY_USERMANAGER_ID_RID_COUNT = 6;

        public const int SECURITY_WINRM_ID_BASE_RID = 0x0000005E;

        public const int SECURITY_WINRM_ID_RID_COUNT = 6;

        public const int SECURITY_CCG_ID_BASE_RID = 0x0000005F;

        public const int SECURITY_UMFD_BASE_RID = 0x00000060;

        public const int SECURITY_VIRTUALACCOUNT_ID_RID_COUNT = 6;

        public const int SECURITY_MAX_BASE_RID = 0x0000006F;

        public const int SECURITY_MAX_ALWAYS_FILTERED = 0x000003E7;

        public const int SECURITY_MIN_NEVER_FILTERED = 0x000003E8;

        public const int SECURITY_OTHER_ORGANIZATION_RID = 0x000003E8;

        public const int SECURITY_WINDOWSMOBILE_ID_BASE_RID = 0x00000070;

        public const int SECURITY_INSTALLER_GROUP_CAPABILITY_BASE = 0x20;

        public const int SECURITY_INSTALLER_GROUP_CAPABILITY_RID_COUNT = 9;

        public const int SECURITY_INSTALLER_CAPABILITY_RID_COUNT = 10;

        public const int SECURITY_LOCAL_ACCOUNT_RID = 0x00000071;

        public const int SECURITY_LOCAL_ACCOUNT_AND_ADMIN_RID = 0x00000072;

        public const int DOMAIN_GROUP_RID_AUTHORIZATION_DATA_IS_COMPOUNDED = 0x000001F0;

        public const int DOMAIN_GROUP_RID_AUTHORIZATION_DATA_CONTAINS_CLAIMS = 0x000001F1;

        public const int DOMAIN_GROUP_RID_ENTERPRISE_READONLY_DOMAIN_CONTROLLERS = 0x000001F2;

        public const int FOREST_USER_RID_MAX = 0x000001F3;

        public const int DOMAIN_USER_RID_ADMIN = 0x000001F4;

        public const int DOMAIN_USER_RID_GUEST = 0x000001F5;

        public const int DOMAIN_USER_RID_KRBTGT = 0x000001F6;

        public const int DOMAIN_USER_RID_DEFAULT_ACCOUNT = 0x000001F7;

        public const int DOMAIN_USER_RID_WDAG_ACCOUNT = 0x000001F8;

        public const int DOMAIN_USER_RID_MAX = 0x000003E7;

        public const int DOMAIN_GROUP_RID_ADMINS = 0x00000200;

        public const int DOMAIN_GROUP_RID_USERS = 0x00000201;

        public const int DOMAIN_GROUP_RID_GUESTS = 0x00000202;

        public const int DOMAIN_GROUP_RID_COMPUTERS = 0x00000203;

        public const int DOMAIN_GROUP_RID_CONTROLLERS = 0x00000204;

        public const int DOMAIN_GROUP_RID_CERT_ADMINS = 0x00000205;

        public const int DOMAIN_GROUP_RID_SCHEMA_ADMINS = 0x00000206;

        public const int DOMAIN_GROUP_RID_ENTERPRISE_ADMINS = 0x00000207;

        public const int DOMAIN_GROUP_RID_POLICY_ADMINS = 0x00000208;

        public const int DOMAIN_GROUP_RID_READONLY_CONTROLLERS = 0x00000209;

        public const int DOMAIN_GROUP_RID_CLONEABLE_CONTROLLERS = 0x0000020A;

        public const int DOMAIN_GROUP_RID_CDC_RESERVED = 0x0000020C;

        public const int DOMAIN_GROUP_RID_PROTECTED_USERS = 0x0000020D;

        public const int DOMAIN_GROUP_RID_KEY_ADMINS = 0x0000020E;

        public const int DOMAIN_GROUP_RID_ENTERPRISE_KEY_ADMINS = 0x0000020F;

        public const int DOMAIN_ALIAS_RID_ADMINS = 0x00000220;

        public const int DOMAIN_ALIAS_RID_USERS = 0x00000221;

        public const int DOMAIN_ALIAS_RID_GUESTS = 0x00000222;

        public const int DOMAIN_ALIAS_RID_POWER_USERS = 0x00000223;

        public const int DOMAIN_ALIAS_RID_ACCOUNT_OPS = 0x00000224;

        public const int DOMAIN_ALIAS_RID_SYSTEM_OPS = 0x00000225;

        public const int DOMAIN_ALIAS_RID_PRINT_OPS = 0x00000226;

        public const int DOMAIN_ALIAS_RID_BACKUP_OPS = 0x00000227;

        public const int DOMAIN_ALIAS_RID_REPLICATOR = 0x00000228;

        public const int DOMAIN_ALIAS_RID_RAS_SERVERS = 0x00000229;

        public const int DOMAIN_ALIAS_RID_PREW2KCOMPACCESS = 0x0000022A;

        public const int DOMAIN_ALIAS_RID_REMOTE_DESKTOP_USERS = 0x0000022B;

        public const int DOMAIN_ALIAS_RID_NETWORK_CONFIGURATION_OPS = 0x0000022C;

        public const int DOMAIN_ALIAS_RID_INCOMING_FOREST_TRUST_BUILDERS = 0x0000022D;

        public const int DOMAIN_ALIAS_RID_MONITORING_USERS = 0x0000022E;

        public const int DOMAIN_ALIAS_RID_LOGGING_USERS = 0x0000022F;

        public const int DOMAIN_ALIAS_RID_AUTHORIZATIONACCESS = 0x00000230;

        public const int DOMAIN_ALIAS_RID_TS_LICENSE_SERVERS = 0x00000231;

        public const int DOMAIN_ALIAS_RID_DCOM_USERS = 0x00000232;

        public const int DOMAIN_ALIAS_RID_IUSERS = 0x00000238;

        public const int DOMAIN_ALIAS_RID_CRYPTO_OPERATORS = 0x00000239;

        public const int DOMAIN_ALIAS_RID_CACHEABLE_PRINCIPALS_GROUP = 0x0000023B;

        public const int DOMAIN_ALIAS_RID_NON_CACHEABLE_PRINCIPALS_GROUP = 0x0000023C;

        public const int DOMAIN_ALIAS_RID_EVENT_LOG_READERS_GROUP = 0x0000023D;

        public const int DOMAIN_ALIAS_RID_CERTSVC_DCOM_ACCESS_GROUP = 0x0000023E;

        public const int DOMAIN_ALIAS_RID_RDS_REMOTE_ACCESS_SERVERS = 0x0000023F;

        public const int DOMAIN_ALIAS_RID_RDS_ENDPOINT_SERVERS = 0x00000240;

        public const int DOMAIN_ALIAS_RID_RDS_MANAGEMENT_SERVERS = 0x00000241;

        public const int DOMAIN_ALIAS_RID_HYPER_V_ADMINS = 0x00000242;

        public const int DOMAIN_ALIAS_RID_ACCESS_CONTROL_ASSISTANCE_OPS = 0x00000243;

        public const int DOMAIN_ALIAS_RID_REMOTE_MANAGEMENT_USERS = 0x00000244;

        public const int DOMAIN_ALIAS_RID_DEFAULT_ACCOUNT = 0x00000245;

        public const int DOMAIN_ALIAS_RID_STORAGE_REPLICA_ADMINS = 0x00000246;

        public const int DOMAIN_ALIAS_RID_DEVICE_OWNERS = 0x00000247;

        public const int SECURITY_APP_PACKAGE_BASE_RID = 0x00000002;

        public const int SECURITY_BUILTIN_APP_PACKAGE_RID_COUNT = 2;

        public const int SECURITY_APP_PACKAGE_RID_COUNT = 8;

        public const int SECURITY_CAPABILITY_BASE_RID = 0x00000003;

        public const int SECURITY_CAPABILITY_APP_RID = 0x000000400;

        public const int SECURITY_BUILTIN_CAPABILITY_RID_COUNT = 2;

        public const int SECURITY_CAPABILITY_RID_COUNT = 5;

        public const int SECURITY_PARENT_PACKAGE_RID_COUNT = SECURITY_APP_PACKAGE_RID_COUNT;

        public const int SECURITY_CHILD_PACKAGE_RID_COUNT = 12;

        public const int SECURITY_BUILTIN_PACKAGE_ANY_PACKAGE = 0x00000001;

        public const int SECURITY_BUILTIN_PACKAGE_ANY_RESTRICTED_PACKAGE = 0x00000002;

        public const int SECURITY_CAPABILITY_INTERNET_CLIENT = 0x00000001;

        public const int SECURITY_CAPABILITY_INTERNET_CLIENT_SERVER = 0x00000002;

        public const int SECURITY_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER = 0x00000003;

        public const int SECURITY_CAPABILITY_PICTURES_LIBRARY = 0x00000004;

        public const int SECURITY_CAPABILITY_VIDEOS_LIBRARY = 0x00000005;

        public const int SECURITY_CAPABILITY_MUSIC_LIBRARY = 0x00000006;

        public const int SECURITY_CAPABILITY_DOCUMENTS_LIBRARY = 0x00000007;

        public const int SECURITY_CAPABILITY_ENTERPRISE_AUTHENTICATION = 0x00000008;

        public const int SECURITY_CAPABILITY_SHARED_USER_CERTIFICATES = 0x00000009;

        public const int SECURITY_CAPABILITY_REMOVABLE_STORAGE = 0x0000000A;

        public const int SECURITY_CAPABILITY_APPOINTMENTS = 0x0000000B;

        public const int SECURITY_CAPABILITY_CONTACTS = 0x0000000C;

        public const int SECURITY_CAPABILITY_INTERNET_EXPLORER = 0x00001000;

        public const int SECURITY_MANDATORY_UNTRUSTED_RID = 0x00000000;

        public const int SECURITY_MANDATORY_LOW_RID = 0x00001000;

        public const int SECURITY_MANDATORY_MEDIUM_RID = 0x00002000;

        public const int SECURITY_MANDATORY_MEDIUM_PLUS_RID = SECURITY_MANDATORY_MEDIUM_RID + 0x100;

        public const int SECURITY_MANDATORY_HIGH_RID = 0x00003000;

        public const int SECURITY_MANDATORY_SYSTEM_RID = 0x00004000;

        public const int SECURITY_MANDATORY_PROTECTED_PROCESS_RID = 0x00005000;

        public const int SECURITY_MANDATORY_MAXIMUM_USER_RID = SECURITY_MANDATORY_SYSTEM_RID;

        public const int SECURITY_AUTHENTICATION_AUTHORITY_RID_COUNT = 1;

        public const int SECURITY_AUTHENTICATION_AUTHORITY_ASSERTED_RID = 0x00000001;

        public const int SECURITY_AUTHENTICATION_SERVICE_ASSERTED_RID = 0x00000002;

        public const int SECURITY_AUTHENTICATION_FRESH_KEY_AUTH_RID = 0x00000003;

        public const int SECURITY_AUTHENTICATION_KEY_TRUST_RID = 0x00000004;

        public const int SECURITY_AUTHENTICATION_KEY_PROPERTY_MFA_RID = 0x00000005;

        public const int SECURITY_AUTHENTICATION_KEY_PROPERTY_ATTESTATION_RID = 0x00000006;

        public const int SECURITY_PROCESS_TRUST_AUTHORITY_RID_COUNT = 2;

        public const int SECURITY_PROCESS_PROTECTION_TYPE_FULL_RID = 0x00000400;

        public const int SECURITY_PROCESS_PROTECTION_TYPE_LITE_RID = 0x00000200;

        public const int SECURITY_PROCESS_PROTECTION_TYPE_NONE_RID = 0x00000000;

        public const int SECURITY_PROCESS_PROTECTION_LEVEL_WINTCB_RID = 0x00002000;

        public const int SECURITY_PROCESS_PROTECTION_LEVEL_WINDOWS_RID = 0x00001000;

        public const int SECURITY_PROCESS_PROTECTION_LEVEL_APP_RID = 0x00000800;

        public const int SECURITY_PROCESS_PROTECTION_LEVEL_ANTIMALWARE_RID = 0x00000600;

        public const int SECURITY_PROCESS_PROTECTION_LEVEL_AUTHENTICODE_RID = 0x00000400;

        public const int SECURITY_PROCESS_PROTECTION_LEVEL_NONE_RID = 0x00000000;

        public const uint SE_GROUP_MANDATORY = 0x00000001;

        public const uint SE_GROUP_ENABLED_BY_DEFAULT = 0x00000002;

        public const uint SE_GROUP_ENABLED = 0x00000004;

        public const uint SE_GROUP_OWNER = 0x00000008;

        public const uint SE_GROUP_USE_FOR_DENY_ONLY = 0x00000010;

        public const uint SE_GROUP_INTEGRITY = 0x00000020;

        public const uint SE_GROUP_INTEGRITY_ENABLED = 0x00000040;

        public const uint SE_GROUP_LOGON_ID = 0xC0000000;

        public const uint SE_GROUP_RESOURCE = 0x20000000;

        public const uint SE_GROUP_VALID_ATTRIBUTES = SE_GROUP_MANDATORY | SE_GROUP_ENABLED_BY_DEFAULT | SE_GROUP_ENABLED | SE_GROUP_OWNER | SE_GROUP_USE_FOR_DENY_ONLY | SE_GROUP_LOGON_ID | SE_GROUP_RESOURCE | SE_GROUP_INTEGRITY | SE_GROUP_INTEGRITY_ENABLED;

        public const uint ACL_REVISION = 2;

        public const uint ACL_REVISION_DS = 4;

        public const uint ACL_REVISION1 = 1;

        public const uint MIN_ACL_REVISION = ACL_REVISION2;

        public const uint ACL_REVISION2 = 2;

        public const uint ACL_REVISION3 = 3;

        public const uint ACL_REVISION4 = 4;

        public const uint MAX_ACL_REVISION = ACL_REVISION4;

        public const byte ACCESS_MIN_MS_ACE_TYPE = 0x0;

        public const byte ACCESS_ALLOWED_ACE_TYPE = 0x0;

        public const byte ACCESS_DENIED_ACE_TYPE = 0x1;

        public const byte SYSTEM_AUDIT_ACE_TYPE = 0x2;

        public const byte SYSTEM_ALARM_ACE_TYPE = 0x3;

        public const byte ACCESS_MAX_MS_V2_ACE_TYPE = 0x3;

        public const byte ACCESS_ALLOWED_COMPOUND_ACE_TYPE = 0x4;

        public const byte ACCESS_MAX_MS_V3_ACE_TYPE = 0x4;

        public const byte ACCESS_MIN_MS_OBJECT_ACE_TYPE = 0x5;

        public const byte ACCESS_ALLOWED_OBJECT_ACE_TYPE = 0x5;

        public const byte ACCESS_DENIED_OBJECT_ACE_TYPE = 0x6;

        public const byte SYSTEM_AUDIT_OBJECT_ACE_TYPE = 0x7;

        public const byte SYSTEM_ALARM_OBJECT_ACE_TYPE = 0x8;

        public const byte ACCESS_MAX_MS_OBJECT_ACE_TYPE = 0x8;

        public const byte ACCESS_MAX_MS_V4_ACE_TYPE = 0x8;

        public const byte ACCESS_MAX_MS_ACE_TYPE = 0x8;

        public const byte ACCESS_ALLOWED_CALLBACK_ACE_TYPE = 0x9;

        public const byte ACCESS_DENIED_CALLBACK_ACE_TYPE = 0xA;

        public const byte ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE = 0xB;

        public const byte ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE = 0xC;

        public const byte SYSTEM_AUDIT_CALLBACK_ACE_TYPE = 0xD;

        public const byte SYSTEM_ALARM_CALLBACK_ACE_TYPE = 0xE;

        public const byte SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE = 0xF;

        public const byte SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE = 0x10;

        public const byte SYSTEM_MANDATORY_LABEL_ACE_TYPE = 0x11;

        public const byte SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE = 0x12;

        public const byte SYSTEM_SCOPED_POLICY_ID_ACE_TYPE = 0x13;

        public const byte SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE = 0x14;

        public const byte SYSTEM_ACCESS_FILTER_ACE_TYPE = 0x15;

        public const byte ACCESS_MAX_MS_V5_ACE_TYPE = 0x15;

        public const byte OBJECT_INHERIT_ACE = 0x1;

        public const byte CONTAINER_INHERIT_ACE = 0x2;

        public const byte NO_PROPAGATE_INHERIT_ACE = 0x4;

        public const byte INHERIT_ONLY_ACE = 0x8;

        public const byte INHERITED_ACE = 0x10;

        public const byte VALID_INHERIT_FLAGS = 0x1F;

        public const byte CRITICAL_ACE_FLAG = 0x20;

        public const byte SUCCESSFUL_ACCESS_ACE_FLAG = 0x40;

        public const byte FAILED_ACCESS_ACE_FLAG = 0x80;

        public const byte TRUST_PROTECTED_FILTER_ACE_FLAG = 0x40;

        public const int SYSTEM_MANDATORY_LABEL_VALID_MASK = SYSTEM_MANDATORY_LABEL_NO_WRITE_UP | SYSTEM_MANDATORY_LABEL_NO_READ_UP | SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP;

        public const int SECURITY_DESCRIPTOR_REVISION = 1;

        public const int SECURITY_DESCRIPTOR_REVISION1 = 1;

        public const ushort SE_OWNER_DEFAULTED = 0x0001;

        public const ushort SE_GROUP_DEFAULTED = 0x0002;

        public const ushort SE_DACL_PRESENT = 0x0004;

        public const ushort SE_DACL_DEFAULTED = 0x0008;

        public const ushort SE_SACL_PRESENT = 0x0010;

        public const ushort SE_SACL_DEFAULTED = 0x0020;

        public const ushort SE_DACL_AUTO_INHERIT_REQ = 0x0100;

        public const ushort SE_SACL_AUTO_INHERIT_REQ = 0x0200;

        public const ushort SE_DACL_AUTO_INHERITED = 0x0400;

        public const ushort SE_SACL_AUTO_INHERITED = 0x0800;

        public const ushort SE_DACL_PROTECTED = 0x1000;

        public const ushort SE_SACL_PROTECTED = 0x2000;

        public const ushort SE_RM_CONTROL_VALID = 0x4000;

        public const ushort SE_SELF_RELATIVE = 0x8000;

        public const uint SE_PRIVILEGE_ENABLED_BY_DEFAULT = 0x00000001;

        public const uint SE_PRIVILEGE_ENABLED = 0x00000002;

        public const uint SE_PRIVILEGE_REMOVED = 0X00000004;

        public const uint SE_PRIVILEGE_USED_FOR_ACCESS = 0x80000000;

        public const uint SE_PRIVILEGE_VALID_ATTRIBUTES = SE_PRIVILEGE_ENABLED_BY_DEFAULT | SE_PRIVILEGE_ENABLED | SE_PRIVILEGE_REMOVED | SE_PRIVILEGE_USED_FOR_ACCESS;

        public const int PRIVILEGE_SET_ALL_NECESSARY = 1;

        public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";

        public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";

        public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";

        public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";

        public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";

        public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";

        public const string SE_TCB_NAME = "SeTcbPrivilege";

        public const string SE_SECURITY_NAME = "SeSecurityPrivilege";

        public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";

        public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";

        public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";

        public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";

        public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";

        public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";

        public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";

        public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";

        public const string SE_BACKUP_NAME = "SeBackupPrivilege";

        public const string SE_RESTORE_NAME = "SeRestorePrivilege";

        public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

        public const string SE_DEBUG_NAME = "SeDebugPrivilege";

        public const string SE_AUDIT_NAME = "SeAuditPrivilege";

        public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";

        public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";

        public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";

        public const string SE_UNDOCK_NAME = "SeUndockPrivilege";

        public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";

        public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";

        public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";

        public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";

        public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";

        public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";

        public const string SE_RELABEL_NAME = "SeRelabelPrivilege";

        public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";

        public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";

        public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";

        public const string SE_DELEGATE_SESSION_USER_IMPERSONATE_NAME = "SeDelegateSessionUserImpersonatePrivilege";

        public const uint TOKEN_ASSIGN_PRIMARY = 0x0001;

        public const uint TOKEN_DUPLICATE = 0x0002;

        public const uint TOKEN_IMPERSONATE = 0x0004;

        public const uint TOKEN_QUERY = 0x0008;

        public const uint TOKEN_QUERY_SOURCE = 0x0010;

        public const uint TOKEN_ADJUST_PRIVILEGES = 0x0020;

        public const uint TOKEN_ADJUST_GROUPS = 0x0040;

        public const uint TOKEN_ADJUST_DEFAULT = 0x0080;

        public const uint TOKEN_ADJUST_SESSIONID = 0x0100;

        public const uint TOKEN_ALL_ACCESS_P = STANDARD_RIGHTS_REQUIRED | TOKEN_ASSIGN_PRIMARY | TOKEN_DUPLICATE | TOKEN_IMPERSONATE | TOKEN_QUERY | TOKEN_QUERY_SOURCE | TOKEN_ADJUST_PRIVILEGES | TOKEN_ADJUST_GROUPS | TOKEN_ADJUST_DEFAULT;

        public const uint TOKEN_ALL_ACCESS = TOKEN_ALL_ACCESS_P | TOKEN_ADJUST_SESSIONID;

        public const uint TOKEN_READ = STANDARD_RIGHTS_READ | TOKEN_QUERY;

        public const uint TOKEN_WRITE = STANDARD_RIGHTS_WRITE | TOKEN_ADJUST_PRIVILEGES | TOKEN_ADJUST_GROUPS | TOKEN_ADJUST_DEFAULT;

        public const uint TOKEN_EXECUTE = STANDARD_RIGHTS_EXECUTE;

        public const uint TOKEN_TRUST_CONSTRAINT_MASK = STANDARD_RIGHTS_READ | TOKEN_QUERY | TOKEN_QUERY_SOURCE;

        public const uint TOKEN_ACCESS_PSEUDO_HANDLE_WIN8 = TOKEN_QUERY | TOKEN_QUERY_SOURCE;

        public const uint TOKEN_ACCESS_PSEUDO_HANDLE = TOKEN_ACCESS_PSEUDO_HANDLE_WIN8;

        public const uint TOKEN_MANDATORY_POLICY_VALID_MASK = TOKEN_MANDATORY_POLICY_NO_WRITE_UP | TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN;

        public const int POLICY_AUDIT_SUBCATEGORY_COUNT = 59;

        public const uint CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS = CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE | CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE | CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY | CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT | CLAIM_SECURITY_ATTRIBUTE_DISABLED | CLAIM_SECURITY_ATTRIBUTE_MANDATORY;

        public const ushort CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION = CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1;

        public const int SECURITY_DYNAMIC_TRACKING = TRUE;

        public const int SECURITY_STATIC_TRACKING = FALSE;

        public const uint OWNER_SECURITY_INFORMATION = 0x00000001;

        public const uint GROUP_SECURITY_INFORMATION = 0x00000002;

        public const uint DACL_SECURITY_INFORMATION = 0x00000004;

        public const uint SACL_SECURITY_INFORMATION = 0x00000008;

        public const uint LABEL_SECURITY_INFORMATION = 0x00000010;

        public const uint ATTRIBUTE_SECURITY_INFORMATION = 0x00000020;

        public const uint SCOPE_SECURITY_INFORMATION = 0x00000040;

        public const uint PROCESS_TRUST_LABEL_SECURITY_INFORMATION = 0x00000080;

        public const uint ACCESS_FILTER_SECURITY_INFORMATION = 0x00000100;

        public const uint BACKUP_SECURITY_INFORMATION = 0x00010000;

        public const uint PROTECTED_DACL_SECURITY_INFORMATION = 0x80000000;

        public const uint PROTECTED_SACL_SECURITY_INFORMATION = 0x40000000;

        public const uint UNPROTECTED_DACL_SECURITY_INFORMATION = 0x20000000;

        public const uint UNPROTECTED_SACL_SECURITY_INFORMATION = 0x10000000;

        public const byte SE_SIGNING_LEVEL_DEVELOPER = SE_SIGNING_LEVEL_CUSTOM_1;

        public const byte SE_SIGNING_LEVEL_ANTIMALWARE = SE_SIGNING_LEVEL_CUSTOM_3;

        public const uint PROCESS_TERMINATE = 0x0001;

        public const uint PROCESS_CREATE_THREAD = 0x0002;

        public const uint PROCESS_SET_SESSIONID = 0x0004;

        public const uint PROCESS_VM_OPERATION = 0x0008;

        public const uint PROCESS_VM_READ = 0x0010;

        public const uint PROCESS_VM_WRITE = 0x0020;

        public const uint PROCESS_DUP_HANDLE = 0x0040;

        public const uint PROCESS_CREATE_PROCESS = 0x0080;

        public const uint PROCESS_SET_QUOTA = 0x0100;

        public const uint PROCESS_SET_INFORMATION = 0x0200;

        public const uint PROCESS_QUERY_INFORMATION = 0x0400;

        public const uint PROCESS_SUSPEND_RESUME = 0x0800;

        public const uint PROCESS_QUERY_LIMITED_INFORMATION = 0x1000;

        public const uint PROCESS_SET_LIMITED_INFORMATION = 0x2000;

        public const uint PROCESS_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFFF;

        public const uint THREAD_TERMINATE = 0x0001;

        public const uint THREAD_SUSPEND_RESUME = 0x0002;

        public const uint THREAD_GET_CONTEXT = 0x0008;

        public const uint THREAD_SET_CONTEXT = 0x0010;

        public const uint THREAD_QUERY_INFORMATION = 0x0040;

        public const uint THREAD_SET_INFORMATION = 0x0020;

        public const uint THREAD_SET_THREAD_TOKEN = 0x0080;

        public const uint THREAD_IMPERSONATE = 0x0100;

        public const uint THREAD_DIRECT_IMPERSONATION = 0x0200;

        public const uint THREAD_SET_LIMITED_INFORMATION = 0x0400;

        public const uint THREAD_QUERY_LIMITED_INFORMATION = 0x0800;

        public const uint THREAD_RESUME = 0x1000;

        public const uint THREAD_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFFF;

        public const uint JOB_OBJECT_ASSIGN_PROCESS = 0x0001;

        public const uint JOB_OBJECT_SET_ATTRIBUTES = 0x0002;

        public const uint JOB_OBJECT_QUERY = 0x0004;

        public const uint JOB_OBJECT_TERMINATE = 0x0008;

        public const uint JOB_OBJECT_SET_SECURITY_ATTRIBUTES = 0x0010;

        public const uint JOB_OBJECT_IMPERSONATE = 0x0020;

        public const uint JOB_OBJECT_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3F;

        public const int THREAD_BASE_PRIORITY_MIN = -2;

        public const int THREAD_BASE_PRIORITY_IDLE = -15;

        public const uint JOB_OBJECT_VALID_COMPLETION_FILTER = (1U << (JOB_OBJECT_MSG_MAXIMUM + 1)) - 1 - ((1U << JOB_OBJECT_MSG_MINIMUM) - 1);

        public const uint JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH = JOB_OBJECT_LIMIT_JOB_MEMORY;

        public const uint JOB_OBJECT_LIMIT_CPU_RATE_CONTROL = JOB_OBJECT_LIMIT_RATE_CONTROL;

        public const uint JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS = JOB_OBJECT_LIMIT_JOB_READ_BYTES | JOB_OBJECT_LIMIT_JOB_WRITE_BYTES | JOB_OBJECT_LIMIT_JOB_TIME | JOB_OBJECT_LIMIT_JOB_MEMORY_LOW | JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH | JOB_OBJECT_LIMIT_CPU_RATE_CONTROL | JOB_OBJECT_LIMIT_IO_RATE_CONTROL | JOB_OBJECT_LIMIT_NET_RATE_CONTROL;

        public const uint EVENT_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3;

        public const uint MUTANT_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | MUTANT_QUERY_STATE;

        public const uint SEMAPHORE_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3;

        public const uint TIMER_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | TIMER_QUERY_STATE | TIMER_MODIFY_STATE;

        public const int XSTATE_LEGACY_FLOATING_POINT = 0;

        public const int XSTATE_LEGACY_SSE = 1;

        public const int XSTATE_GSSE = 2;

        public const int XSTATE_AVX = XSTATE_GSSE;

        public const int XSTATE_MPX_BNDREGS = 3;

        public const int XSTATE_MPX_BNDCSR = 4;

        public const int XSTATE_AVX512_KMASK = 5;

        public const int XSTATE_AVX512_ZMM_H = 6;

        public const int XSTATE_AVX512_ZMM = 7;

        public const int XSTATE_IPT = 8;

        public const int XSTATE_CET_U = 11;

        public const int XSTATE_LWP = 62;

        public const ulong MAXIMUM_XSTATE_FEATURES = 64;

        public const ulong XSTATE_MASK_LEGACY_FLOATING_POINT = 1ul << XSTATE_LEGACY_FLOATING_POINT;

        public const ulong XSTATE_MASK_LEGACY_SSE = 1ul << XSTATE_LEGACY_SSE;

        public const ulong XSTATE_MASK_LEGACY = XSTATE_MASK_LEGACY_FLOATING_POINT | XSTATE_MASK_LEGACY_SSE;

        public const ulong XSTATE_MASK_GSSE = 1ul << XSTATE_GSSE;

        public const ulong XSTATE_MASK_AVX = XSTATE_MASK_GSSE;

        public const ulong XSTATE_MASK_MPX = (1ul << XSTATE_MPX_BNDREGS) | (1u << XSTATE_MPX_BNDCSR);

        public const ulong XSTATE_MASK_AVX512 = (1ul << XSTATE_AVX512_KMASK) | (1ul << XSTATE_AVX512_ZMM_H) | (1ul << XSTATE_AVX512_ZMM);

        public const ulong XSTATE_MASK_IPT = 1ul << XSTATE_IPT;

        public const ulong XSTATE_MASK_CET_U = 1ul << XSTATE_CET_U;

        public const ulong XSTATE_MASK_LWP = 1ul << XSTATE_LWP;

        public const ulong XSTATE_MASK_ALLOWED = XSTATE_MASK_LEGACY | XSTATE_MASK_AVX | XSTATE_MASK_MPX | XSTATE_MASK_AVX512 | XSTATE_MASK_IPT | XSTATE_MASK_CET_U | XSTATE_MASK_LWP;

        public const ulong XSTATE_MASK_PERSISTENT = (1ul << XSTATE_MPX_BNDCSR) | XSTATE_MASK_LWP;

        public const ulong XSTATE_MASK_USER_VISIBLE_SUPERVISOR = XSTATE_MASK_CET_U;

        public const int XSTATE_COMPACTION_ENABLE = 63;

        public const ulong XSTATE_COMPACTION_ENABLE_MASK = 1ul << XSTATE_COMPACTION_ENABLE;

        public const int XSTATE_ALIGN_BIT = 1;

        public const ulong XSTATE_ALIGN_MASK = 1ul << XSTATE_ALIGN_BIT;

        public const ulong XSTATE_CONTROLFLAG_XSAVEOPT_MASK = 1;

        public const ulong XSTATE_CONTROLFLAG_XSAVEC_MASK = 2;

        public const ulong XSTATE_CONTROLFLAG_VALID_MASK = XSTATE_CONTROLFLAG_XSAVEOPT_MASK | XSTATE_CONTROLFLAG_XSAVEC_MASK;

        public const int CFG_CALL_TARGET_VALID = 0x00000001;

        public const int CFG_CALL_TARGET_PROCESSED = 0x00000002;

        public const int CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID = 0x00000004;

        public const uint SECTION_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SECTION_QUERY | SECTION_MAP_WRITE | SECTION_MAP_READ | SECTION_MAP_EXECUTE | SECTION_EXTEND_SIZE;

        public const uint SESSION_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SESSION_QUERY_ACCESS | SESSION_MODIFY_ACCESS;

        public const uint MEM_64K_PAGES = MEM_LARGE_PAGES | MEM_PHYSICAL;

        public const uint SEC_IMAGE_NO_EXECUTE = SEC_IMAGE | SEC_NOCACHE;

        public const uint FILE_READ_DATA = 0x0001;

        public const uint FILE_LIST_DIRECTORY = 0x0001;

        public const uint FILE_WRITE_DATA = 0x0002;

        public const uint FILE_ADD_FILE = 0x0002;

        public const uint FILE_APPEND_DATA = 0x0004;

        public const uint FILE_ADD_SUBDIRECTORY = 0x0004;

        public const uint FILE_CREATE_PIPE_INSTANCE = 0x0004;

        public const uint FILE_READ_EA = 0x0008;

        public const uint FILE_WRITE_EA = 0x0010;

        public const uint FILE_EXECUTE = 0x0020;

        public const uint FILE_TRAVERSE = 0x0020;

        public const uint FILE_DELETE_CHILD = 0x0040;

        public const uint FILE_READ_ATTRIBUTES = 0x0080;

        public const uint FILE_WRITE_ATTRIBUTES = 0x0100;

        public const uint FILE_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF;

        public const uint FILE_GENERIC_READ = STANDARD_RIGHTS_READ | FILE_READ_DATA | FILE_READ_ATTRIBUTES | FILE_READ_EA | SYNCHRONIZE;

        public const uint FILE_GENERIC_WRITE = STANDARD_RIGHTS_WRITE | FILE_WRITE_DATA | FILE_WRITE_ATTRIBUTES | FILE_WRITE_EA | FILE_APPEND_DATA | SYNCHRONIZE;

        public const uint FILE_GENERIC_EXECUTE = STANDARD_RIGHTS_EXECUTE | FILE_READ_ATTRIBUTES | FILE_EXECUTE | SYNCHRONIZE;

        public const uint MAILSLOT_NO_MESSAGE = unchecked((uint)-1);

        public const uint MAILSLOT_WAIT_FOREVER = unchecked((uint)-1);

        public const long FILE_INVALID_FILE_ID = -1;

        public const int MAXIMUM_REPARSE_DATA_BUFFER_SIZE = 16 * 1024;

        public const uint IO_REPARSE_TAG_RESERVED_ZERO = 0;

        public const uint IO_REPARSE_TAG_RESERVED_ONE = 1;

        public const uint IO_REPARSE_TAG_RESERVED_TWO = 2;

        public const uint IO_REPARSE_TAG_RESERVED_RANGE = IO_REPARSE_TAG_RESERVED_TWO;

        public const uint IO_REPARSE_TAG_MOUNT_POINT = 0xA0000003;

        public const uint IO_REPARSE_TAG_HSM = 0xC0000004;

        public const uint IO_REPARSE_TAG_HSM2 = 0x80000006;

        public const uint IO_REPARSE_TAG_SIS = 0x80000007;

        public const uint IO_REPARSE_TAG_WIM = 0x80000008;

        public const uint IO_REPARSE_TAG_CSV = 0x80000009;

        public const uint IO_REPARSE_TAG_DFS = 0x8000000A;

        public const uint IO_REPARSE_TAG_SYMLINK = 0xA000000C;

        public const uint IO_REPARSE_TAG_DFSR = 0x80000012;

        public const uint IO_REPARSE_TAG_DEDUP = 0x80000013;

        public const uint IO_REPARSE_TAG_NFS = 0x80000014;

        public const uint IO_REPARSE_TAG_FILE_PLACEHOLDER = 0x80000015;

        public const uint IO_REPARSE_TAG_WOF = 0x80000017;

        public const uint IO_REPARSE_TAG_WCI = 0x80000018;

        public const uint IO_REPARSE_TAG_WCI_1 = 0x90001018;

        public const uint IO_REPARSE_TAG_GLOBAL_REPARSE = 0xA0000019;

        public const uint IO_REPARSE_TAG_CLOUD = 0x9000001A;

        public const uint IO_REPARSE_TAG_CLOUD_1 = 0x9000101A;

        public const uint IO_REPARSE_TAG_CLOUD_2 = 0x9000201A;

        public const uint IO_REPARSE_TAG_CLOUD_3 = 0x9000301A;

        public const uint IO_REPARSE_TAG_CLOUD_4 = 0x9000401A;

        public const uint IO_REPARSE_TAG_CLOUD_5 = 0x9000501A;

        public const uint IO_REPARSE_TAG_CLOUD_6 = 0x9000601A;

        public const uint IO_REPARSE_TAG_CLOUD_7 = 0x9000701A;

        public const uint IO_REPARSE_TAG_CLOUD_8 = 0x9000801A;

        public const uint IO_REPARSE_TAG_CLOUD_9 = 0x9000901A;

        public const uint IO_REPARSE_TAG_CLOUD_A = 0x9000A01A;

        public const uint IO_REPARSE_TAG_CLOUD_B = 0x9000B01A;

        public const uint IO_REPARSE_TAG_CLOUD_C = 0x9000C01A;

        public const uint IO_REPARSE_TAG_CLOUD_D = 0x9000D01A;

        public const uint IO_REPARSE_TAG_CLOUD_E = 0x9000E01A;

        public const uint IO_REPARSE_TAG_CLOUD_F = 0x9000F01A;

        public const uint IO_REPARSE_TAG_CLOUD_MASK = 0x0000F000;

        public const uint IO_REPARSE_TAG_APPEXECLINK = 0x8000001B;

        public const uint IO_REPARSE_TAG_PROJFS = 0x9000001C;

        public const uint IO_REPARSE_TAG_STORAGE_SYNC = 0x8000001E;

        public const uint IO_REPARSE_TAG_WCI_TOMBSTONE = 0xA000001F;

        public const uint IO_REPARSE_TAG_UNHANDLED = 0x80000020;

        public const uint IO_REPARSE_TAG_ONEDRIVE = 0x80000021;

        public const uint IO_REPARSE_TAG_PROJFS_TOMBSTONE = 0xA0000022;

        public const uint IO_REPARSE_TAG_AF_UNIX = 0x80000023;

        public const int SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS = 0x00000001;

        public const uint IO_COMPLETION_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3;

        public const int PERFSTATE_POLICY_CHANGE_DECREASE_MAX = PERFSTATE_POLICY_CHANGE_ROCKET;

        public const int PERFSTATE_POLICY_CHANGE_INCREASE_MAX = PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE;

        public const int PROCESSOR_PERF_BOOST_MODE_MAX = PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED;

        public const int CORE_PARKING_POLICY_CHANGE_MAX = CORE_PARKING_POLICY_CHANGE_MULTISTEP;

        public const uint ES_SYSTEM_REQUIRED = 0x00000001;

        public const uint ES_DISPLAY_REQUIRED = 0x00000002;

        public const uint ES_USER_PRESENT = 0x00000004;

        public const uint ES_AWAYMODE_REQUIRED = 0x00000040;

        public const uint ES_CONTINUOUS = 0x80000000;

        public const uint DIAGNOSTIC_REASON_INVALID_FLAGS = ~0x80000007;

        public const uint POWER_REQUEST_CONTEXT_VERSION = DIAGNOSTIC_REASON_VERSION;

        public const uint POWER_REQUEST_CONTEXT_SIMPLE_STRING = DIAGNOSTIC_REASON_SIMPLE_STRING;

        public const uint POWER_REQUEST_CONTEXT_DETAILED_STRING = DIAGNOSTIC_REASON_DETAILED_STRING;

        public const uint POWER_SETTING_VALUE_VERSION = 0x1;

        public const uint POWER_PLATFORM_ROLE_V1 = 0x00000001;

        public const uint POWER_PLATFORM_ROLE_V1_MAX = (uint)POWER_PLATFORM_ROLE.PlatformRolePerformanceServer + 1;

        public const uint POWER_PLATFORM_ROLE_V2 = 0x00000002;

        public const uint POWER_PLATFORM_ROLE_V2_MAX = (uint)POWER_PLATFORM_ROLE.PlatformRoleSlate + 1;

        public const uint POWER_PLATFORM_ROLE_VERSION = POWER_PLATFORM_ROLE_V2;

        public const uint POWER_PLATFORM_ROLE_VERSION_MAX = POWER_PLATFORM_ROLE_V2_MAX;

        public const uint IMAGE_FILE_MACHINE_AXP64 = IMAGE_FILE_MACHINE_ALPHA64;

        public const short IMAGE_SYM_UNDEFINED = 0;

        public const short IMAGE_SYM_ABSOLUTE = -1;

        public const short IMAGE_SYM_DEBUG = -2;

        public const int IMAGE_SYM_SECTION_MAX_EX = MAXLONG;

        public const byte IMAGE_SYM_CLASS_END_OF_FUNCTION = unchecked((byte)-1);

        public const int IMAGE_ENCLAVE_LONG_ID_LENGTH = ENCLAVE_LONG_ID_LENGTH;

        public const int IMAGE_ENCLAVE_SHORT_ID_LENGTH = ENCLAVE_SHORT_ID_LENGTH;

        public const int COMPRESSION_FORMAT_NONE = 0x0000;

        public const int COMPRESSION_FORMAT_DEFAULT = 0x0001;

        public const int COMPRESSION_FORMAT_LZNT1 = 0x0002;

        public const int COMPRESSION_FORMAT_XPRESS = 0x0003;

        public const int COMPRESSION_FORMAT_XPRESS_HUFF = 0x0004;

        public const int COMPRESSION_ENGINE_STANDARD = 0x0000;

        public const int COMPRESSION_ENGINE_MAXIMUM = 0x0100;

        public const int COMPRESSION_ENGINE_HIBER = 0x0200;

        public const int SEF_MACL_VALID_FLAGS = SEF_MACL_NO_WRITE_UP | SEF_MACL_NO_READ_UP | SEF_MACL_NO_EXECUTE_UP;

        public const int RTL_UMS_VERSION = 0x0100;

        public const int VRL_PREDEFINED_CLASS_BEGIN = 1 << 0;

        public const int VRL_CUSTOM_CLASS_BEGIN = 1 << 8;

        public const int VRL_CLASS_CONSISTENCY = VRL_PREDEFINED_CLASS_BEGIN << 0;

        public const int VRL_ENABLE_KERNEL_BREAKS = 1 << 31;

        public const uint CTMF_VALID_FLAGS = CTMF_INCLUDE_APPCONTAINER | CTMF_INCLUDE_LPAC;

        public const uint FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN = 0x00000001;

        public const nuint FLUSH_NV_MEMORY_DEFAULT_TOKEN = unchecked((uint)-1);

        public const uint WRITE_NV_MEMORY_FLAG_FLUSH = 0x00000001;

        public const uint WRITE_NV_MEMORY_FLAG_NON_TEMPORAL = 0x00000002;

        public const uint WRITE_NV_MEMORY_FLAG_PERSIST = WRITE_NV_MEMORY_FLAG_FLUSH | WRITE_NV_MEMORY_FLAG_NON_TEMPORAL;

        public const uint WRITE_NV_MEMORY_FLAG_NO_DRAIN = 0x00000100;

        public const uint FILL_NV_MEMORY_FLAG_FLUSH = 0x00000001;

        public const uint FILL_NV_MEMORY_FLAG_NON_TEMPORAL = 0x00000002;

        public const uint FILL_NV_MEMORY_FLAG_PERSIST = FILL_NV_MEMORY_FLAG_FLUSH | FILL_NV_MEMORY_FLAG_NON_TEMPORAL;

        public const uint FILL_NV_MEMORY_FLAG_NO_DRAIN = 0x00000100;

        public const sbyte RTL_CORRELATION_VECTOR_VERSION_1 = 1;

        public const sbyte RTL_CORRELATION_VECTOR_VERSION_2 = 2;

        public const sbyte RTL_CORRELATION_VECTOR_VERSION_CURRENT = RTL_CORRELATION_VECTOR_VERSION_2;

        public const int RTL_CORRELATION_VECTOR_V1_PREFIX_LENGTH = 16;

        public const int RTL_CORRELATION_VECTOR_V1_LENGTH = 64;

        public const int RTL_CORRELATION_VECTOR_V2_PREFIX_LENGTH = 22;

        public const int RTL_CORRELATION_VECTOR_V2_LENGTH = 128;

        public const uint RTL_CRITICAL_SECTION_FLAG_RESERVED = RTL_CRITICAL_SECTION_ALL_FLAG_BITS & (~(RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO | RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN | RTL_CRITICAL_SECTION_FLAG_STATIC_INIT | RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE | RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO));

        public const int ACTIVATION_CONTEXT_PATH_TYPE_NONE = 1;

        public const int ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE = 2;

        public const int ACTIVATION_CONTEXT_PATH_TYPE_URL = 3;

        public const int ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF = 4;

        public const uint KEY_QUERY_VALUE = 0x0001;

        public const uint KEY_SET_VALUE = 0x0002;

        public const uint KEY_CREATE_SUB_KEY = 0x0004;

        public const uint KEY_ENUMERATE_SUB_KEYS = 0x0008;

        public const uint KEY_NOTIFY = 0x0010;

        public const uint KEY_CREATE_LINK = 0x0020;

        public const uint KEY_WOW64_32KEY = 0x0200;

        public const uint KEY_WOW64_64KEY = 0x0100;

        public const uint KEY_WOW64_RES = 0x0300;

        public const uint KEY_READ = (STANDARD_RIGHTS_READ | KEY_QUERY_VALUE | KEY_ENUMERATE_SUB_KEYS | KEY_NOTIFY) & ~SYNCHRONIZE;

        public const uint KEY_WRITE = (STANDARD_RIGHTS_WRITE | KEY_SET_VALUE | KEY_CREATE_SUB_KEY) & ~SYNCHRONIZE;

        public const uint KEY_EXECUTE = KEY_READ & ~SYNCHRONIZE;

        public const uint KEY_ALL_ACCESS = (STANDARD_RIGHTS_ALL | KEY_QUERY_VALUE | KEY_SET_VALUE | KEY_CREATE_SUB_KEY | KEY_ENUMERATE_SUB_KEYS | KEY_NOTIFY | KEY_CREATE_LINK) & ~SYNCHRONIZE;

        public const uint REG_OPTION_RESERVED = 0x00000000;

        public const uint REG_OPTION_NON_VOLATILE = 0x00000000;

        public const uint REG_OPTION_VOLATILE = 0x00000001;

        public const uint REG_OPTION_CREATE_LINK = 0x00000002;

        public const uint REG_OPTION_BACKUP_RESTORE = 0x00000004;

        public const uint REG_OPTION_OPEN_LINK = 0x00000008;

        public const uint REG_OPTION_DONT_VIRTUALIZE = 0x00000010;

        public const uint REG_LEGAL_OPTION = REG_OPTION_RESERVED | REG_OPTION_NON_VOLATILE | REG_OPTION_VOLATILE | REG_OPTION_CREATE_LINK | REG_OPTION_BACKUP_RESTORE | REG_OPTION_OPEN_LINK | REG_OPTION_DONT_VIRTUALIZE;

        public const uint REG_OPEN_LEGAL_OPTION = REG_OPTION_RESERVED | REG_OPTION_BACKUP_RESTORE | REG_OPTION_OPEN_LINK | REG_OPTION_DONT_VIRTUALIZE;

        public const uint REG_CREATED_NEW_KEY = 0x00000001;

        public const uint REG_OPENED_EXISTING_KEY = 0x00000002;

        public const uint REG_WHOLE_HIVE_VOLATILE = 0x00000001;

        public const uint REG_REFRESH_HIVE = 0x00000002;

        public const uint REG_NO_LAZY_FLUSH = 0x00000004;

        public const uint REG_FORCE_RESTORE = 0x00000008;

        public const uint REG_APP_HIVE = 0x00000010;

        public const uint REG_PROCESS_PRIVATE = 0x00000020;

        public const uint REG_START_JOURNAL = 0x00000040;

        public const uint REG_HIVE_EXACT_FILE_GROWTH = 0x00000080;

        public const uint REG_HIVE_NO_RM = 0x00000100;

        public const uint REG_HIVE_SINGLE_LOG = 0x00000200;

        public const uint REG_BOOT_HIVE = 0x00000400;

        public const uint REG_LOAD_HIVE_OPEN_HANDLE = 0x00000800;

        public const uint REG_FLUSH_HIVE_FILE_GROWTH = 0x00001000;

        public const uint REG_OPEN_READ_ONLY = 0x00002000;

        public const uint REG_IMMUTABLE = 0x00004000;

        public const uint REG_APP_HIVE_OPEN_READ_ONLY = REG_OPEN_READ_ONLY;

        public const uint REG_UNLOAD_LEGAL_FLAGS = REG_FORCE_UNLOAD;

        public const uint REG_NOTIFY_CHANGE_NAME = 0x00000001;

        public const uint REG_NOTIFY_CHANGE_ATTRIBUTES = 0x00000002;

        public const uint REG_NOTIFY_CHANGE_LAST_SET = 0x00000004;

        public const uint REG_NOTIFY_CHANGE_SECURITY = 0x00000008;

        public const uint REG_NOTIFY_THREAD_AGNOSTIC = 0x10000000;

        public const uint REG_LEGAL_CHANGE_FILTER = REG_NOTIFY_CHANGE_NAME | REG_NOTIFY_CHANGE_ATTRIBUTES | REG_NOTIFY_CHANGE_LAST_SET | REG_NOTIFY_CHANGE_SECURITY | REG_NOTIFY_THREAD_AGNOSTIC;

        public const uint REG_NONE = 0;

        public const uint REG_SZ = 1;

        public const uint REG_EXPAND_SZ = 2;

        public const uint REG_BINARY = 3;

        public const uint REG_DWORD = 4;

        public const uint REG_DWORD_LITTLE_ENDIAN = 4;

        public const uint REG_DWORD_BIG_ENDIAN = 5;

        public const uint REG_LINK = 6;

        public const uint REG_MTI_SZ = 7;

        public const uint REG_RESOURCE_LIST = 8;

        public const uint REG_FL_RESOURCE_DESCRIPTOR = 9;

        public const uint REG_RESOURCE_REQUIREMENTS_LIST = 10;

        public const uint REG_QWORD = 11;

        public const uint REG_QWORD_LITTLE_ENDIAN = 11;

        public const int SERVICE_DRIVER = SERVICE_KERNEL_DRIVER | SERVICE_FILE_SYSTEM_DRIVER | SERVICE_RECOGNIZER_DRIVER;

        public const int SERVICE_WIN32 = SERVICE_WIN32_OWN_PROCESS | SERVICE_WIN32_SHARE_PROCESS;

        public const int SERVICE_USER_SHARE_PROCESS = SERVICE_USER_SERVICE | SERVICE_WIN32_SHARE_PROCESS;

        public const int SERVICE_USER_OWN_PROCESS = SERVICE_USER_SERVICE | SERVICE_WIN32_OWN_PROCESS;

        public const int SERVICE_TYPE_ALL = SERVICE_WIN32 | SERVICE_ADAPTER | SERVICE_DRIVER | SERVICE_INTERACTIVE_PROCESS | SERVICE_USER_SERVICE | SERVICE_USERSERVICE_INSTANCE | SERVICE_PKG_SERVICE;

        public const int CM_SERVICE_VALID_PROMOTION_MASK = CM_SERVICE_NETWORK_BOOT_LOAD | CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD | CM_SERVICE_USB_DISK_BOOT_LOAD | CM_SERVICE_SD_DISK_BOOT_LOAD | CM_SERVICE_USB3_DISK_BOOT_LOAD | CM_SERVICE_MEASURED_BOOT_LOAD | CM_SERVICE_VERIFIER_BOOT_LOAD | CM_SERVICE_WINPE_BOOT_LOAD | CM_SERVICE_RAM_DISK_BOOT_LOAD;

        public const int TRANSACTIONMANAGER_QUERY_INFORMATION = 0x0001;

        public const int TRANSACTIONMANAGER_SET_INFORMATION = 0x0002;

        public const int TRANSACTIONMANAGER_RECOVER = 0x0004;

        public const int TRANSACTIONMANAGER_RENAME = 0x0008;

        public const int TRANSACTIONMANAGER_CREATE_RM = 0x0010;

        public const int TRANSACTIONMANAGER_BIND_TRANSACTION = 0x0020;

        public const uint TRANSACTIONMANAGER_GENERIC_READ = STANDARD_RIGHTS_READ | TRANSACTIONMANAGER_QUERY_INFORMATION;

        public const uint TRANSACTIONMANAGER_GENERIC_WRITE = STANDARD_RIGHTS_WRITE | TRANSACTIONMANAGER_SET_INFORMATION | TRANSACTIONMANAGER_RECOVER | TRANSACTIONMANAGER_RENAME | TRANSACTIONMANAGER_CREATE_RM;

        public const uint TRANSACTIONMANAGER_GENERIC_EXECUTE = STANDARD_RIGHTS_EXECUTE;

        public const uint TRANSACTIONMANAGER_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | TRANSACTIONMANAGER_GENERIC_READ | TRANSACTIONMANAGER_GENERIC_WRITE | TRANSACTIONMANAGER_GENERIC_EXECUTE | TRANSACTIONMANAGER_BIND_TRANSACTION;

        public const int TRANSACTION_QUERY_INFORMATION = 0x0001;

        public const int TRANSACTION_SET_INFORMATION = 0x0002;

        public const int TRANSACTION_ENLIST = 0x0004;

        public const int TRANSACTION_COMMIT = 0x0008;

        public const int TRANSACTION_ROLLBACK = 0x0010;

        public const int TRANSACTION_PROPAGATE = 0x0020;

        public const int TRANSACTION_RIGHT_RESERVED1 = 0x0040;

        public const uint TRANSACTION_GENERIC_READ = STANDARD_RIGHTS_READ | TRANSACTION_QUERY_INFORMATION | SYNCHRONIZE;

        public const uint TRANSACTION_GENERIC_WRITE = STANDARD_RIGHTS_WRITE | TRANSACTION_SET_INFORMATION | TRANSACTION_COMMIT | TRANSACTION_ENLIST | TRANSACTION_ROLLBACK | TRANSACTION_PROPAGATE | SYNCHRONIZE;

        public const uint TRANSACTION_GENERIC_EXECUTE = STANDARD_RIGHTS_EXECUTE | TRANSACTION_COMMIT | TRANSACTION_ROLLBACK | SYNCHRONIZE;

        public const uint TRANSACTION_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | TRANSACTION_GENERIC_READ | TRANSACTION_GENERIC_WRITE | TRANSACTION_GENERIC_EXECUTE;

        public const uint TRANSACTION_RESOURCE_MANAGER_RIGHTS = TRANSACTION_GENERIC_READ | STANDARD_RIGHTS_WRITE | TRANSACTION_SET_INFORMATION | TRANSACTION_ENLIST | TRANSACTION_ROLLBACK | TRANSACTION_PROPAGATE | SYNCHRONIZE;

        public const int RESOURCEMANAGER_QUERY_INFORMATION = 0x0001;

        public const int RESOURCEMANAGER_SET_INFORMATION = 0x0002;

        public const int RESOURCEMANAGER_RECOVER = 0x0004;

        public const int RESOURCEMANAGER_ENLIST = 0x0008;

        public const int RESOURCEMANAGER_GET_NOTIFICATION = 0x0010;

        public const int RESOURCEMANAGER_REGISTER_PROTOCOL = 0x0020;

        public const int RESOURCEMANAGER_COMPLETE_PROPAGATION = 0x0040;

        public const uint RESOURCEMANAGER_GENERIC_READ = STANDARD_RIGHTS_READ | RESOURCEMANAGER_QUERY_INFORMATION | SYNCHRONIZE;

        public const uint RESOURCEMANAGER_GENERIC_WRITE = STANDARD_RIGHTS_WRITE | RESOURCEMANAGER_SET_INFORMATION | RESOURCEMANAGER_RECOVER | RESOURCEMANAGER_ENLIST | RESOURCEMANAGER_GET_NOTIFICATION | RESOURCEMANAGER_REGISTER_PROTOCOL | RESOURCEMANAGER_COMPLETE_PROPAGATION | SYNCHRONIZE;

        public const uint RESOURCEMANAGER_GENERIC_EXECUTE = STANDARD_RIGHTS_EXECUTE | RESOURCEMANAGER_RECOVER | RESOURCEMANAGER_ENLIST | RESOURCEMANAGER_GET_NOTIFICATION | RESOURCEMANAGER_COMPLETE_PROPAGATION | SYNCHRONIZE;

        public const uint RESOURCEMANAGER_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | RESOURCEMANAGER_GENERIC_READ | RESOURCEMANAGER_GENERIC_WRITE | RESOURCEMANAGER_GENERIC_EXECUTE;

        public const int ENLISTMENT_QUERY_INFORMATION = 0x0001;

        public const int ENLISTMENT_SET_INFORMATION = 0x0002;

        public const int ENLISTMENT_RECOVER = 0x0004;

        public const int ENLISTMENT_SUBORDINATE_RIGHTS = 0x0008;

        public const int ENLISTMENT_SUPERIOR_RIGHTS = 0x0010;

        public const uint ENLISTMENT_GENERIC_READ = STANDARD_RIGHTS_READ | ENLISTMENT_QUERY_INFORMATION;

        public const uint ENLISTMENT_GENERIC_WRITE = STANDARD_RIGHTS_WRITE | ENLISTMENT_SET_INFORMATION | ENLISTMENT_RECOVER | ENLISTMENT_SUBORDINATE_RIGHTS | ENLISTMENT_SUPERIOR_RIGHTS;

        public const uint ENLISTMENT_GENERIC_EXECUTE = STANDARD_RIGHTS_EXECUTE | ENLISTMENT_RECOVER | ENLISTMENT_SUBORDINATE_RIGHTS | ENLISTMENT_SUPERIOR_RIGHTS;

        public const uint ENLISTMENT_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | ENLISTMENT_GENERIC_READ | ENLISTMENT_GENERIC_WRITE | ENLISTMENT_GENERIC_EXECUTE;

        public const int ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION = 1;

        public const int ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION = 2;

        public const int ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION = 3;

        public const int ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION = 4;

        public const int ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION = 5;

        public const int ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION = 6;

        public const int ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION = 7;

        public const int ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE = 8;

        public const int ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES = 9;

        public const int ACTIVATION_CONTEXT_SECTION_APPLICATION_SETTINGS = 10;

        public const int ACTIVATION_CONTEXT_SECTION_COMPATIBILITY_INFO = 11;

        public const int ACTIVATION_CONTEXT_SECTION_WINRT_ACTIVATABLE_CLASSES = 12;

        public static readonly Guid GUID_MAX_POWER_SAVINGS = new Guid(0xA1841308, 0x3541, 0x4FAB, 0xBC, 0x81, 0xF7, 0x15, 0x56, 0xF2, 0x0B, 0x4A);

        public static readonly Guid GUID_MIN_POWER_SAVINGS = new Guid(0x8C5E7FDA, 0xE8BF, 0x4A96, 0x9A, 0x85, 0xA6, 0xE2, 0x3A, 0x8C, 0x63, 0x5C);

        public static readonly Guid GUID_TYPICAL_POWER_SAVINGS = new Guid(0x381B4222, 0xF694, 0x41F0, 0x96, 0x85, 0xFF, 0x5B, 0xB2, 0x60, 0xDF, 0x2E);

        public static readonly Guid NO_SUBGROUP_GUID = new Guid(0xFEA3413E, 0x7E05, 0x4911, 0x9A, 0x71, 0x70, 0x03, 0x31, 0xF1, 0xC2, 0x94);

        public static readonly Guid ALL_POWERSCHEMES_GUID = new Guid(0x68A1E95E, 0x13EA, 0x41E1, 0x80, 0x11, 0x0C, 0x49, 0x6C, 0xA4, 0x90, 0xB0);

        public static readonly Guid GUID_POWERSCHEME_PERSONALITY = new Guid(0x245D8541, 0x3943, 0x4422, 0xB0, 0x25, 0x13, 0xA7, 0x84, 0xF6, 0x79, 0xB7);

        public static readonly Guid GUID_ACTIVE_POWERSCHEME = new Guid(0x31F9F286, 0x5084, 0x42FE, 0xB7, 0x20, 0x2B, 0x02, 0x64, 0x99, 0x37, 0x63);

        public static readonly Guid GUID_IDLE_RESILIENCY_SUBGROUP = new Guid(0x2E601130, 0x5351, 0x4D9D, 0x8E, 0x04, 0x25, 0x29, 0x66, 0xBA, 0xD0, 0x54);

        public static readonly Guid GUID_IDLE_RESILIENCY_PERIOD = new Guid(0xC42B79AA, 0xAA3A, 0x484B, 0xA9, 0x8F, 0x2C, 0xF3, 0x2A, 0xA9, 0x0A, 0x28);

        public static readonly Guid GUID_DEEP_SLEEP_ENABLED = new Guid(0xD502F7EE, 0x1DC7, 0x4EFD, 0xA5, 0x5D, 0xF0, 0x4B, 0x6F, 0x5C, 0x05, 0x45);

        public static readonly Guid GUID_DEEP_SLEEP_PLATFORM_STATE = new Guid(0xD23F2FB8, 0x9536, 0x4038, 0x9C, 0x94, 0x1C, 0xE0, 0x2E, 0x5C, 0x21, 0x52);

        public static readonly Guid GUID_DISK_COALESCING_POWERDOWN_TIMEOUT = new Guid(0xC36F0EB4, 0x2988, 0x4A70, 0x8E, 0xEE, 0x08, 0x84, 0xFC, 0x2C, 0x24, 0x33);

        public static readonly Guid GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT = new Guid(0x3166BC41, 0x7E98, 0x4E03, 0xB3, 0x4E, 0xEC, 0x0F, 0x5F, 0x2B, 0x21, 0x8E);

        public static readonly Guid GUID_VIDEO_SUBGROUP = new Guid(0x7516B95F, 0xF776, 0x4464, 0x8C, 0x53, 0x06, 0x16, 0x7F, 0x40, 0xCC, 0x99);

        public static readonly Guid GUID_VIDEO_POWERDOWN_TIMEOUT = new Guid(0x3C0BC021, 0xC8A8, 0x4E07, 0xA9, 0x73, 0x6B, 0x14, 0xCB, 0xCB, 0x2B, 0x7E);

        public static readonly Guid GUID_VIDEO_ANNOYANCE_TIMEOUT = new Guid(0x82DBCF2D, 0xCD67, 0x40C5, 0xBF, 0xDC, 0x9F, 0x1A, 0x5C, 0xCD, 0x46, 0x63);

        public static readonly Guid GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE = new Guid(0xEED904DF, 0xB142, 0x4183, 0xB1, 0x0B, 0x5A, 0x11, 0x97, 0xA3, 0x78, 0x64);

        public static readonly Guid GUID_VIDEO_DIM_TIMEOUT = new Guid(0x17AAA29B, 0x8B43, 0x4B94, 0xAA, 0xFE, 0x35, 0xF6, 0x4D, 0xAA, 0xF1, 0xEE);

        public static readonly Guid GUID_VIDEO_ADAPTIVE_POWERDOWN = new Guid(0x90959D22, 0xD6A1, 0x49B9, 0xAF, 0x93, 0xBC, 0xE8, 0x85, 0xAD, 0x33, 0x5B);

        public static readonly Guid GUID_MONITOR_POWER_ON = new Guid(0x02731015, 0x4510, 0x4526, 0x99, 0xE6, 0xE5, 0xA1, 0x7E, 0xBD, 0x1A, 0xEA);

        public static readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS = new Guid(0xADED5E82, 0xB909, 0x4619, 0x99, 0x49, 0xF5, 0xD7, 0x1D, 0xAC, 0x0B, 0xCB);

        public static readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS = new Guid(0xF1FBFDE2, 0xA960, 0x4165, 0x9F, 0x88, 0x50, 0x66, 0x79, 0x11, 0xCE, 0x96);

        public static readonly Guid GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS = new Guid(0x8FFEE2C6, 0x2D01, 0x46BE, 0xAD, 0xB9, 0x39, 0x8A, 0xDD, 0xC5, 0xB4, 0xFF);

        public static readonly Guid GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS = new Guid(0xFBD9AA66, 0x9553, 0x4097, 0xBA, 0x44, 0xED, 0x6E, 0x9D, 0x65, 0xEA, 0xB8);

        public static readonly Guid GUID_CONSOLE_DISPLAY_STATE = new Guid(0x6FE69556, 0x704A, 0x47A0, 0x8F, 0x24, 0xC2, 0x8D, 0x93, 0x6F, 0xDA, 0x47);

        public static readonly Guid GUID_ALLOW_DISPLAY_REQUIRED = new Guid(0xA9CEB8DA, 0xCD46, 0x44FB, 0xA9, 0x8B, 0x02, 0xAF, 0x69, 0xDE, 0x46, 0x23);

        public static readonly Guid GUID_VIDEO_CONSOLE_LOCK_TIMEOUT = new Guid(0x8EC4B3A5, 0x6868, 0x48C2, 0xBE, 0x75, 0x4F, 0x30, 0x44, 0xBE, 0x88, 0xA7);

        public static readonly Guid GUID_ADVANCED_COLOR_QUALITY_BIAS = new Guid(0x684C3E69, 0xA4F7, 0x4014, 0x87, 0x54, 0xD4, 0x51, 0x79, 0xA5, 0x61, 0x67);

        public static readonly Guid GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP = new Guid(0x8619B916, 0xE004, 0x4DD8, 0x9B, 0x66, 0xDA, 0xE8, 0x6F, 0x80, 0x66, 0x98);

        public static readonly Guid GUID_NON_ADAPTIVE_INPUT_TIMEOUT = new Guid(0x5ADBBFBC, 0x074E, 0x4DA1, 0xBA, 0x38, 0xDB, 0x8B, 0x36, 0xB2, 0xC8, 0xF3);

        public static readonly Guid GUID_ADAPTIVE_INPUT_CONTROLLER_STATE = new Guid(0x0E98FAE9, 0xF45A, 0x4DE1, 0xA7, 0x57, 0x60, 0x31, 0xF1, 0x97, 0xF6, 0xEA);

        public static readonly Guid GUID_DISK_SUBGROUP = new Guid(0x0012EE47, 0x9041, 0x4B5D, 0x9B, 0x77, 0x53, 0x5F, 0xBA, 0x8B, 0x14, 0x42);

        public static readonly Guid GUID_DISK_MAX_POWER = new Guid(0x51DEA550, 0xBB38, 0x4BC4, 0x99, 0x1B, 0xEA, 0xCF, 0x37, 0xBE, 0x5E, 0xC8);

        public static readonly Guid GUID_DISK_POWERDOWN_TIMEOUT = new Guid(0x6738E2C4, 0xE8A5, 0x4A42, 0xB1, 0x6A, 0xE0, 0x40, 0xE7, 0x69, 0x75, 0x6E);

        public static readonly Guid GUID_DISK_IDLE_TIMEOUT = new Guid(0x58E39BA8, 0xB8E6, 0x4EF6, 0x90, 0xD0, 0x89, 0xAE, 0x32, 0xB2, 0x58, 0xD6);

        public static readonly Guid GUID_DISK_BURST_IGNORE_THRESHOLD = new Guid(0x80E3C60E, 0xBB94, 0x4AD8, 0xBB, 0xE0, 0x0D, 0x31, 0x95, 0xEF, 0xC6, 0x63);

        public static readonly Guid GUID_DISK_ADAPTIVE_POWERDOWN = new Guid(0x396A32E1, 0x499A, 0x40B2, 0x91, 0x24, 0xA9, 0x6A, 0xFE, 0x70, 0x76, 0x67);

        public static readonly Guid GUID_SLEEP_SUBGROUP = new Guid(0x238C9FA8, 0x0AAD, 0x41ED, 0x83, 0xF4, 0x97, 0xBE, 0x24, 0x2C, 0x8F, 0x20);

        public static readonly Guid GUID_SLEEP_IDLE_THRESHOLD = new Guid(0x81CD32E0, 0x7833, 0x44F3, 0x87, 0x37, 0x70, 0x81, 0xF3, 0x8D, 0x1F, 0x70);

        public static readonly Guid GUID_STANDBY_TIMEOUT = new Guid(0x29F6C1DB, 0x86DA, 0x48C5, 0x9F, 0xDB, 0xF2, 0xB6, 0x7B, 0x1F, 0x44, 0xDA);

        public static readonly Guid GUID_UNATTEND_SLEEP_TIMEOUT = new Guid(0x7BC4A2F9, 0xD8FC, 0x4469, 0xB0, 0x7B, 0x33, 0xEB, 0x78, 0x5A, 0xAC, 0xA0);

        public static readonly Guid GUID_HIBERNATE_TIMEOUT = new Guid(0x9D7815A6, 0x7EE4, 0x497E, 0x88, 0x88, 0x51, 0x5A, 0x05, 0xF0, 0x23, 0x64);

        public static readonly Guid GUID_HIBERNATE_FASTS4_POLICY = new Guid(0x94AC6D29, 0x73CE, 0x41A6, 0x80, 0x9F, 0x63, 0x63, 0xBA, 0x21, 0xB4, 0x7E);

        public static readonly Guid GUID_CRITICAL_POWER_TRANSITION = new Guid(0xB7A27025, 0xE569, 0x46C2, 0xA5, 0x04, 0x2B, 0x96, 0xCA, 0xD2, 0x25, 0xA1);

        public static readonly Guid GUID_SYSTEM_AWAYMODE = new Guid(0x98A7F580, 0x01F7, 0x48AA, 0x9C, 0x0F, 0x44, 0x35, 0x2C, 0x29, 0xE5, 0xC0);

        public static readonly Guid GUID_ALLOW_AWAYMODE = new Guid(0x25DFA149, 0x5DD1, 0x4736, 0xB5, 0xAB, 0xE8, 0xA3, 0x7B, 0x5B, 0x81, 0x87);

        public static readonly Guid GUID_USER_PRESENCE_PREDICTION = new Guid(0x82011705, 0xFB95, 0x4D46, 0x8D, 0x35, 0x40, 0x42, 0xB1, 0xD2, 0x0D, 0xEF);

        public static readonly Guid GUID_STANDBY_BUDGET_GRACE_PERIOD = new Guid(0x60C07FE1, 0x0556, 0x45CF, 0x99, 0x03, 0xD5, 0x6E, 0x32, 0x21, 0x02, 0x42);

        public static readonly Guid GUID_STANDBY_BUDGET_PERCENT = new Guid(0x9FE527BE, 0x1B70, 0x48DA, 0x93, 0x0D, 0x7B, 0xCF, 0x17, 0xB4, 0x49, 0x90);

        public static readonly Guid GUID_STANDBY_RESERVE_GRACE_PERIOD = new Guid(0xC763EE92, 0x71E8, 0x4127, 0x84, 0xEB, 0xF6, 0xED, 0x04, 0x3A, 0x3E, 0x3D);

        public static readonly Guid GUID_STANDBY_RESERVE_TIME = new Guid(0x468FE7E5, 0x1158, 0x46EC, 0x88, 0xBC, 0x5B, 0x96, 0xC9, 0xE4, 0x4F, 0xD0);

        public static readonly Guid GUID_STANDBY_RESET_PERCENT = new Guid(0x49CB11A5, 0x56E2, 0x4AFB, 0x9D, 0x38, 0x3D, 0xF4, 0x78, 0x72, 0xE2, 0x1B);

        public static readonly Guid GUID_ALLOW_STANDBY_STATES = new Guid(0xABFC2519, 0x3608, 0x4C2A, 0x94, 0xEA, 0x17, 0x1B, 0x0E, 0xD5, 0x46, 0xAB);

        public static readonly Guid GUID_ALLOW_RTC_WAKE = new Guid(0xBD3B718A, 0x0680, 0x4D9D, 0x8A, 0xB2, 0xE1, 0xD2, 0xB4, 0xAC, 0x80, 0x6D);

        public static readonly Guid GUID_LEGACY_RTC_MITIGATION = new Guid(0x1A34BDC3, 0x7E6B, 0x442E, 0xA9, 0xD0, 0x64, 0xB6, 0xEF, 0x37, 0x8E, 0x84);

        public static readonly Guid GUID_ALLOW_SYSTEM_REQUIRED = new Guid(0xA4B195F5, 0x8225, 0x47D8, 0x80, 0x12, 0x9D, 0x41, 0x36, 0x97, 0x86, 0xE2);

        public static readonly Guid GUID_POWER_SAVING_STATUS = new Guid(0xE00958C0, 0xC213, 0x4ACE, 0xAC, 0x77, 0xFE, 0xCC, 0xED, 0x2E, 0xEE, 0xA5);

        public static readonly Guid GUID_ENERGY_SAVER_SUBGROUP = new Guid(0xDE830923, 0xA562, 0x41AF, 0xA0, 0x86, 0xE3, 0xA2, 0xC6, 0xBA, 0xD2, 0xDA);

        public static readonly Guid GUID_ENERGY_SAVER_BATTERY_THRESHOLD = new Guid(0xE69653CA, 0xCF7F, 0x4F05, 0xAA, 0x73, 0xCB, 0x83, 0x3F, 0xA9, 0x0A, 0xD4);

        public static readonly Guid GUID_ENERGY_SAVER_BRIGHTNESS = new Guid(0x13D09884, 0xF74E, 0x474A, 0xA8, 0x52, 0xB6, 0xBD, 0xE8, 0xAD, 0x03, 0xA8);

        public static readonly Guid GUID_ENERGY_SAVER_POLICY = new Guid(0x5C5BB349, 0xAD29, 0x4EE2, 0x9D, 0x0B, 0x2B, 0x25, 0x27, 0x0F, 0x7A, 0x81);

        public static readonly Guid GUID_SYSTEM_BUTTON_SUBGROUP = new Guid(0x4F971E89, 0xEEBD, 0x4455, 0xA8, 0xDE, 0x9E, 0x59, 0x04, 0x0E, 0x73, 0x47);

        public static readonly Guid GUID_POWERBUTTON_ACTION = new Guid(0x7648EFA3, 0xDD9C, 0x4E3E, 0xB5, 0x66, 0x50, 0xF9, 0x29, 0x38, 0x62, 0x80);

        public static readonly Guid GUID_SLEEPBUTTON_ACTION = new Guid(0x96996BC0, 0xAD50, 0x47EC, 0x92, 0x3B, 0x6F, 0x41, 0x87, 0x4D, 0xD9, 0xEB);

        public static readonly Guid GUID_USERINTERFACEBUTTON_ACTION = new Guid(0xA7066653, 0x8D6C, 0x40A8, 0x91, 0x0E, 0xA1, 0xF5, 0x4B, 0x84, 0xC7, 0xE5);

        public static readonly Guid GUID_LIDCLOSE_ACTION = new Guid(0x5CA83367, 0x6E45, 0x459F, 0xA2, 0x7B, 0x47, 0x6B, 0x1D, 0x01, 0xC9, 0x36);

        public static readonly Guid GUID_LIDOPEN_POWERSTATE = new Guid(0x99FF10E7, 0x23B1, 0x4C07, 0xA9, 0xD1, 0x5C, 0x32, 0x06, 0xD7, 0x41, 0xB4);

        public static readonly Guid GUID_BATTERY_SUBGROUP = new Guid(0xE73A048D, 0xBF27, 0x4F12, 0x97, 0x31, 0x8B, 0x20, 0x76, 0xE8, 0x89, 0x1F);

        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_0 = new Guid(0x637EA02F, 0xBBCB, 0x4015, 0x8E, 0x2C, 0xA1, 0xC7, 0xB9, 0xC0, 0xB5, 0x46);

        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_0 = new Guid(0x9A66D8D7, 0x4FF7, 0x4EF9, 0xB5, 0xA2, 0x5A, 0x32, 0x6C, 0xA2, 0xA4, 0x69);

        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_0 = new Guid(0x5DBB7C9F, 0x38E9, 0x40D2, 0x97, 0x49, 0x4F, 0x8A, 0x0E, 0x9F, 0x64, 0x0F);

        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_1 = new Guid(0xD8742DCB, 0x3E6A, 0x4B3C, 0xB3, 0xFE, 0x37, 0x46, 0x23, 0xCD, 0xCF, 0x06);

        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_1 = new Guid(0x8183BA9A, 0xE910, 0x48DA, 0x87, 0x69, 0x14, 0xAE, 0x6D, 0xC1, 0x17, 0x0A);

        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_1 = new Guid(0xBCDED951, 0x187B, 0x4D05, 0xBC, 0xCC, 0xF7, 0xE5, 0x19, 0x60, 0xC2, 0x58);

        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_2 = new Guid(0x421CBA38, 0x1A8E, 0x4881, 0xAC, 0x89, 0xE3, 0x3A, 0x8B, 0x04, 0xEC, 0xE4);

        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_2 = new Guid(0x07A07CA2, 0xADAF, 0x40D7, 0xB0, 0x77, 0x53, 0x3A, 0xAD, 0xED, 0x1B, 0xFA);

        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_2 = new Guid(0x7FD2F0C4, 0xFEB7, 0x4DA3, 0x81, 0x17, 0xE3, 0xFB, 0xED, 0xC4, 0x65, 0x82);

        public static readonly Guid GUID_BATTERY_DISCHARGE_ACTION_3 = new Guid(0x80472613, 0x9780, 0x455E, 0xB3, 0x08, 0x72, 0xD3, 0x00, 0x3C, 0xF2, 0xF8);

        public static readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_3 = new Guid(0x58AFD5A6, 0xC2DD, 0x47D2, 0x9F, 0xBF, 0xEF, 0x70, 0xCC, 0x5C, 0x59, 0x65);

        public static readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_3 = new Guid(0x73613CCF, 0xDBFA, 0x4279, 0x83, 0x56, 0x49, 0x35, 0xF6, 0xBF, 0x62, 0xF3);

        public static readonly Guid GUID_PROCESSOR_SETTINGS_SUBGROUP = new Guid(0x54533251, 0x82BE, 0x4824, 0x96, 0xC1, 0x47, 0xB6, 0x0B, 0x74, 0x0D, 0x00);

        public static readonly Guid GUID_PROCESSOR_THROTTLE_POLICY = new Guid(0x57027304, 0x4AF6, 0x4104, 0x92, 0x60, 0xE3, 0xD9, 0x52, 0x48, 0xFC, 0x36);

        public static readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM = new Guid(0xBC5038F7, 0x23E0, 0x4960, 0x96, 0xDA, 0x33, 0xAB, 0xAF, 0x59, 0x35, 0xEC);

        public static readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM_1 = new Guid(0xBC5038F7, 0x23E0, 0x4960, 0x96, 0xDA, 0x33, 0xAB, 0xAF, 0x59, 0x35, 0xED);

        public static readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM = new Guid(0x893DEE8E, 0x2BEF, 0x41E0, 0x89, 0xC6, 0xB5, 0x5D, 0x09, 0x29, 0x96, 0x4C);

        public static readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM_1 = new Guid(0x893DEE8E, 0x2BEF, 0x41E0, 0x89, 0xC6, 0xB5, 0x5D, 0x09, 0x29, 0x96, 0x4D);

        public static readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT = new Guid(0x75B0AE3F, 0xBCE0, 0x45A7, 0x8C, 0x89, 0xC9, 0x61, 0x1C, 0x25, 0xE1, 0x00);

        public static readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT_1 = new Guid(0x75B0AE3F, 0xBCE0, 0x45A7, 0x8C, 0x89, 0xC9, 0x61, 0x1C, 0x25, 0xE1, 0x01);

        public static readonly Guid GUID_PROCESSOR_ALLOW_THROTTLING = new Guid(0x3B04D4FD, 0x1CC7, 0x4F23, 0xAB, 0x1C, 0xD1, 0x33, 0x78, 0x19, 0xC4, 0xBB);

        public static readonly Guid GUID_PROCESSOR_IDLESTATE_POLICY = new Guid(0x68F262A7, 0xF621, 0x4069, 0xB9, 0xA5, 0x48, 0x74, 0x16, 0x9B, 0xE2, 0x3C);

        public static readonly Guid GUID_PROCESSOR_PERFSTATE_POLICY = new Guid(0xBBDC3814, 0x18E9, 0x4463, 0x8A, 0x55, 0xD1, 0x97, 0x32, 0x7C, 0x45, 0xC0);

        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD = new Guid(0x06CADF0E, 0x64ED, 0x448A, 0x89, 0x27, 0xCE, 0x7B, 0xF9, 0x0E, 0xB3, 0x5D);

        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1 = new Guid(0x06CADF0E, 0x64ED, 0x448A, 0x89, 0x27, 0xCE, 0x7B, 0xF9, 0x0E, 0xB3, 0x5E);

        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD = new Guid(0x12A0AB44, 0xFE28, 0x4FA9, 0xB3, 0xBD, 0x4B, 0x64, 0xF4, 0x49, 0x60, 0xA6);

        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1 = new Guid(0x12A0AB44, 0xFE28, 0x4FA9, 0xB3, 0xBD, 0x4B, 0x64, 0xF4, 0x49, 0x60, 0xA7);

        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY = new Guid(0x465E1F50, 0xB610, 0x473A, 0xAB, 0x58, 0x00, 0xD1, 0x07, 0x7D, 0xC4, 0x18);

        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY_1 = new Guid(0x465E1F50, 0xB610, 0x473A, 0xAB, 0x58, 0x00, 0xD1, 0x07, 0x7D, 0xC4, 0x19);

        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY = new Guid(0x40FBEFC7, 0x2E9D, 0x4D25, 0xA1, 0x85, 0x0C, 0xFD, 0x85, 0x74, 0xBA, 0xC6);

        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY_1 = new Guid(0x40FBEFC7, 0x2E9D, 0x4D25, 0xA1, 0x85, 0x0C, 0xFD, 0x85, 0x74, 0xBA, 0xC7);

        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME = new Guid(0x984CF492, 0x3BED, 0x4488, 0xA8, 0xF9, 0x42, 0x86, 0xC9, 0x7B, 0xF5, 0xAA);

        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME_1 = new Guid(0x984CF492, 0x3BED, 0x4488, 0xA8, 0xF9, 0x42, 0x86, 0xC9, 0x7B, 0xF5, 0xAB);

        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME = new Guid(0xD8EDEB9B, 0x95CF, 0x4F95, 0xA7, 0x3C, 0xB0, 0x61, 0x97, 0x36, 0x93, 0xC8);

        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME_1 = new Guid(0xD8EDEB9B, 0x95CF, 0x4F95, 0xA7, 0x3C, 0xB0, 0x61, 0x97, 0x36, 0x93, 0xC9);

        public static readonly Guid GUID_PROCESSOR_PERF_TIME_CHECK = new Guid(0x4D2B0152, 0x7D5C, 0x498B, 0x88, 0xE2, 0x34, 0x34, 0x53, 0x92, 0xA2, 0xC5);

        public static readonly Guid GUID_PROCESSOR_PERF_BOOST_POLICY = new Guid(0x45BCC044, 0xD885, 0x43E2, 0x86, 0x05, 0xEE, 0x0E, 0xC6, 0xE9, 0x6B, 0x59);

        public static readonly Guid GUID_PROCESSOR_PERF_BOOST_MODE = new Guid(0xBE337238, 0x0D82, 0x4146, 0xA9, 0x60, 0x4F, 0x37, 0x49, 0xD4, 0x70, 0xC7);

        public static readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_MODE = new Guid(0x8BAA4A8A, 0x14C6, 0x4451, 0x8E, 0x8B, 0x14, 0xBD, 0xBD, 0x19, 0x75, 0x37);

        public static readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE = new Guid(0x36687F9E, 0xE3A5, 0x4DBF, 0xB1, 0xDC, 0x15, 0xEB, 0x38, 0x1C, 0x68, 0x63);

        public static readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE_1 = new Guid(0x36687F9E, 0xE3A5, 0x4DBF, 0xB1, 0xDC, 0x15, 0xEB, 0x38, 0x1C, 0x68, 0x64);

        public static readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW = new Guid(0xCFEDA3D0, 0x7697, 0x4566, 0xA9, 0x22, 0xA9, 0x08, 0x6C, 0xD4, 0x9D, 0xFA);

        public static readonly Guid GUID_PROCESSOR_DUTY_CYCLING = new Guid(0x4E4450B3, 0x6179, 0x4E91, 0xB8, 0xF1, 0x5B, 0xB9, 0x93, 0x8F, 0x81, 0xA1);

        public static readonly Guid GUID_PROCESSOR_IDLE_ALLOW_SCALING = new Guid(0x6C2993B0, 0x8F48, 0x481F, 0xBC, 0xC6, 0x00, 0xDD, 0x27, 0x42, 0xAA, 0x06);

        public static readonly Guid GUID_PROCESSOR_IDLE_DISABLE = new Guid(0x5D76A2CA, 0xE8C0, 0x402F, 0xA1, 0x33, 0x21, 0x58, 0x49, 0x2D, 0x58, 0xAD);

        public static readonly Guid GUID_PROCESSOR_IDLE_STATE_MAXIMUM = new Guid(0x9943E905, 0x9A30, 0x4EC1, 0x9B, 0x99, 0x44, 0xDD, 0x3B, 0x76, 0xF7, 0xA2);

        public static readonly Guid GUID_PROCESSOR_IDLE_TIME_CHECK = new Guid(0xC4581C31, 0x89AB, 0x4597, 0x8E, 0x2B, 0x9C, 0x9C, 0xAB, 0x44, 0x0E, 0x6B);

        public static readonly Guid GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD = new Guid(0x4B92D758, 0x5A24, 0x4851, 0xA4, 0x70, 0x81, 0x5D, 0x78, 0xAE, 0xE1, 0x19);

        public static readonly Guid GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD = new Guid(0x7B224883, 0xB3CC, 0x4D79, 0x81, 0x9F, 0x83, 0x74, 0x15, 0x2C, 0xBE, 0x7C);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD = new Guid(0xDF142941, 0x20F3, 0x4EDF, 0x9A, 0x4A, 0x9C, 0x83, 0xD3, 0xD7, 0x17, 0xD1);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD = new Guid(0x68DD2F27, 0xA4CE, 0x4E11, 0x84, 0x87, 0x37, 0x94, 0xE4, 0x13, 0x5D, 0xFA);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY = new Guid(0xC7BE0679, 0x2817, 0x4D69, 0x9D, 0x02, 0x51, 0x9A, 0x53, 0x7E, 0xD0, 0xC6);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY = new Guid(0x71021B41, 0xC749, 0x4D21, 0xBE, 0x74, 0xA0, 0x0F, 0x33, 0x5D, 0x58, 0x2B);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES = new Guid(0xEA062031, 0x0E34, 0x4FF1, 0x9B, 0x6D, 0xEB, 0x10, 0x59, 0x33, 0x40, 0x28);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1 = new Guid(0xEA062031, 0x0E34, 0x4FF1, 0x9B, 0x6D, 0xEB, 0x10, 0x59, 0x33, 0x40, 0x29);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES = new Guid(0x0CC5B647, 0xC1DF, 0x4637, 0x89, 0x1A, 0xDE, 0xC3, 0x5C, 0x31, 0x85, 0x83);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1 = new Guid(0x0CC5B647, 0xC1DF, 0x4637, 0x89, 0x1A, 0xDE, 0xC3, 0x5C, 0x31, 0x85, 0x84);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME = new Guid(0x2DDD5A84, 0x5A71, 0x437E, 0x91, 0x2A, 0xDB, 0x0B, 0x8C, 0x78, 0x87, 0x32);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME = new Guid(0xDFD10D17, 0xD5EB, 0x45DD, 0x87, 0x7A, 0x9A, 0x34, 0xDD, 0xD1, 0x5C, 0x82);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR = new Guid(0x8F7B45E3, 0xC393, 0x480A, 0x87, 0x8C, 0xF6, 0x7A, 0xC3, 0xD0, 0x70, 0x82);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD = new Guid(0x5B33697B, 0xE89D, 0x4D38, 0xAA, 0x46, 0x9E, 0x7D, 0xFB, 0x7C, 0xD2, 0xF9);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING = new Guid(0xE70867F1, 0xFA2F, 0x4F4E, 0xAE, 0xA1, 0x4D, 0x8A, 0x0B, 0xA2, 0x3B, 0x20);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR = new Guid(0x1299023C, 0xBC28, 0x4F0A, 0x81, 0xEC, 0xD3, 0x29, 0x5A, 0x8D, 0x81, 0x5D);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD = new Guid(0x9AC18E92, 0xAA3C, 0x4E27, 0xB3, 0x07, 0x01, 0xAE, 0x37, 0x30, 0x71, 0x29);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING = new Guid(0x8809C2D8, 0xB155, 0x42D4, 0xBC, 0xDA, 0x0D, 0x34, 0x56, 0x51, 0xB1, 0xDB);

        public static readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD = new Guid(0x943C8CB6, 0x6F93, 0x4227, 0xAD, 0x87, 0xE9, 0xA3, 0xFE, 0xEC, 0x08, 0xD1);

        public static readonly Guid GUID_PROCESSOR_PARKING_CORE_OVERRIDE = new Guid(0xA55612AA, 0xF624, 0x42C6, 0xA4, 0x43, 0x73, 0x97, 0xD0, 0x64, 0xC0, 0x4F);

        public static readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE = new Guid(0x447235C7, 0x6A8D, 0x4CC0, 0x8E, 0x24, 0x9E, 0xAF, 0x70, 0xB9, 0x6E, 0x2B);

        public static readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE_1 = new Guid(0x447235C7, 0x6A8D, 0x4CC0, 0x8E, 0x24, 0x9E, 0xAF, 0x70, 0xB9, 0x6E, 0x2C);

        public static readonly Guid GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD = new Guid(0x2430AB6F, 0xA520, 0x44A2, 0x96, 0x01, 0xF7, 0xF2, 0x3B, 0x51, 0x34, 0xB1);

        public static readonly Guid GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD = new Guid(0xF735A673, 0x2066, 0x4F80, 0xA0, 0xC5, 0xDD, 0xEE, 0x0C, 0xF1, 0xBF, 0x5D);

        public static readonly Guid GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD = new Guid(0x4BDAF4E9, 0xD103, 0x46D7, 0xA5, 0xF0, 0x62, 0x80, 0x12, 0x16, 0x16, 0xEF);

        public static readonly Guid GUID_PROCESSOR_PERF_HISTORY = new Guid(0x7D24BAA7, 0x0B84, 0x480F, 0x84, 0x0C, 0x1B, 0x07, 0x43, 0xC0, 0x0F, 0x5F);

        public static readonly Guid GUID_PROCESSOR_PERF_HISTORY_1 = new Guid(0x7D24BAA7, 0x0B84, 0x480F, 0x84, 0x0C, 0x1B, 0x07, 0x43, 0xC0, 0x0F, 0x60);

        public static readonly Guid GUID_PROCESSOR_PERF_INCREASE_HISTORY = new Guid(0x99B3EF01, 0x752F, 0x46A1, 0x80, 0xFB, 0x77, 0x30, 0x01, 0x1F, 0x23, 0x54);

        public static readonly Guid GUID_PROCESSOR_PERF_DECREASE_HISTORY = new Guid(0x0300F6F8, 0xABD6, 0x45A9, 0xB7, 0x4F, 0x49, 0x08, 0x69, 0x1A, 0x40, 0xB5);

        public static readonly Guid GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY = new Guid(0x77D7F282, 0x8F1A, 0x42CD, 0x85, 0x37, 0x45, 0x45, 0x0A, 0x83, 0x9B, 0xE8);

        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT = new Guid(0x0822DF31, 0x9C83, 0x441C, 0xA0, 0x79, 0x0D, 0xE4, 0xCF, 0x00, 0x9C, 0x7B);

        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF = new Guid(0x619B7505, 0x003B, 0x4E82, 0xB7, 0xA6, 0x4D, 0xD2, 0x9C, 0x30, 0x09, 0x71);

        public static readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1 = new Guid(0x619B7505, 0x003B, 0x4E82, 0xB7, 0xA6, 0x4D, 0xD2, 0x9C, 0x30, 0x09, 0x72);

        public static readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK = new Guid(0x616CDAA5, 0x695E, 0x4545, 0x97, 0xAD, 0x97, 0xDC, 0x2D, 0x1B, 0xDD, 0x88);

        public static readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1 = new Guid(0x616CDAA5, 0x695E, 0x4545, 0x97, 0xAD, 0x97, 0xDC, 0x2D, 0x1B, 0xDD, 0x89);

        public static readonly Guid GUID_PROCESSOR_DISTRIBUTE_UTILITY = new Guid(0xE0007330, 0xF589, 0x42ED, 0xA4, 0x01, 0x5D, 0xDB, 0x10, 0xE7, 0x85, 0xD3);

        public static readonly Guid GUID_PROCESSOR_HETEROGENEOUS_POLICY = new Guid(0x7F2F5CFA, 0xF10C, 0x4823, 0xB5, 0xE1, 0xE9, 0x3A, 0xE8, 0x5F, 0x46, 0xB5);

        public static readonly Guid GUID_PROCESSOR_HETERO_DECREASE_TIME = new Guid(0x7F2492B6, 0x60B1, 0x45E5, 0xAE, 0x55, 0x77, 0x3F, 0x8C, 0xD5, 0xCA, 0xEC);

        public static readonly Guid GUID_PROCESSOR_HETERO_INCREASE_TIME = new Guid(0x4009EFA7, 0xE72D, 0x4CBA, 0x9E, 0xDF, 0x91, 0x08, 0x4E, 0xA8, 0xCB, 0xC3);

        public static readonly Guid GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD = new Guid(0xF8861C27, 0x95E7, 0x475C, 0x86, 0x5B, 0x13, 0xC0, 0xCB, 0x3F, 0x9D, 0x6B);

        public static readonly Guid GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD = new Guid(0xB000397D, 0x9B0B, 0x483D, 0x98, 0xC9, 0x69, 0x2A, 0x60, 0x60, 0xCF, 0xBF);

        public static readonly Guid GUID_PROCESSOR_CLASS0_FLOOR_PERF = new Guid(0xFDDC842B, 0x8364, 0x4EDC, 0x94, 0xCF, 0xC1, 0x7F, 0x60, 0xDE, 0x1C, 0x80);

        public static readonly Guid GUID_PROCESSOR_CLASS1_INITIAL_PERF = new Guid(0x1FACFC65, 0xA930, 0x4BC5, 0x9F, 0x38, 0x50, 0x4E, 0xC0, 0x97, 0xBB, 0xC0);

        public static readonly Guid GUID_PROCESSOR_THREAD_SCHEDULING_POLICY = new Guid(0x93B8B6DC, 0x0698, 0x4D1C, 0x9E, 0xE4, 0x06, 0x44, 0xE9, 0x00, 0xC8, 0x5D);

        public static readonly Guid GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY = new Guid(0xBAE08B81, 0x2D5E, 0x4688, 0xAD, 0x6A, 0x13, 0x24, 0x33, 0x56, 0x65, 0x4B);

        public static readonly Guid GUID_SYSTEM_COOLING_POLICY = new Guid(0x94D3A615, 0xA899, 0x4AC5, 0xAE, 0x2B, 0xE4, 0xD8, 0xF6, 0x34, 0x36, 0x7F);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD = new Guid(0x38B8383D, 0xCCE0, 0x4C79, 0x9E, 0x3E, 0x56, 0xA4, 0xF1, 0x7C, 0xC4, 0x80);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD_1 = new Guid(0x38B8383D, 0xCCE0, 0x4C79, 0x9E, 0x3E, 0x56, 0xA4, 0xF1, 0x7C, 0xC4, 0x81);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD = new Guid(0x3D44E256, 0x7222, 0x4415, 0xA9, 0xED, 0x9C, 0x45, 0xFA, 0x3D, 0xD8, 0x30);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD_1 = new Guid(0x3D44E256, 0x7222, 0x4415, 0xA9, 0xED, 0x9C, 0x45, 0xFA, 0x3D, 0xD8, 0x31);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME = new Guid(0xF565999F, 0x3FB0, 0x411A, 0xA2, 0x26, 0x3F, 0x01, 0x98, 0xDE, 0xC1, 0x30);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME_1 = new Guid(0xF565999F, 0x3FB0, 0x411A, 0xA2, 0x26, 0x3F, 0x01, 0x98, 0xDE, 0xC1, 0x31);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME = new Guid(0x3D915188, 0x7830, 0x49AE, 0xA7, 0x9A, 0x0F, 0xB0, 0xA1, 0xE5, 0xA2, 0x00);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME_1 = new Guid(0x3D915188, 0x7830, 0x49AE, 0xA7, 0x9A, 0x0F, 0xB0, 0xA1, 0xE5, 0xA2, 0x01);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING = new Guid(0x4427C73B, 0x9756, 0x4A5C, 0xB8, 0x4B, 0xC7, 0xBD, 0xA7, 0x9C, 0x73, 0x20);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING_1 = new Guid(0x4427C73B, 0x9756, 0x4A5C, 0xB8, 0x4B, 0xC7, 0xBD, 0xA7, 0x9C, 0x73, 0x21);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR = new Guid(0xCE8E92EE, 0x6A86, 0x4572, 0xBF, 0xE0, 0x20, 0xC2, 0x1D, 0x03, 0xCD, 0x40);

        public static readonly Guid GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR_1 = new Guid(0xCE8E92EE, 0x6A86, 0x4572, 0xBF, 0xE0, 0x20, 0xC2, 0x1D, 0x03, 0xCD, 0x41);

        public static readonly Guid GUID_LOCK_CONSOLE_ON_WAKE = new Guid(0x0E796BDB, 0x100D, 0x47D6, 0xA2, 0xD5, 0xF7, 0xD2, 0xDA, 0xA5, 0x1F, 0x51);

        public static readonly Guid GUID_DEVICE_IDLE_POLICY = new Guid(0x4FAAB71A, 0x92E5, 0x4726, 0xB5, 0x31, 0x22, 0x45, 0x59, 0x67, 0x2D, 0x19);

        public static readonly Guid GUID_CONNECTIVITY_IN_STANDBY = new Guid(0xF15576E8, 0x98B7, 0x4186, 0xB9, 0x44, 0xEA, 0xFA, 0x66, 0x44, 0x02, 0xD9);

        public static readonly Guid GUID_DISCONNECTED_STANDBY_MODE = new Guid(0x68AFB2D9, 0xEE95, 0x47A8, 0x8F, 0x50, 0x41, 0x15, 0x08, 0x80, 0x73, 0xB1);

        public static readonly Guid GUID_ACDC_POWER_SOURCE = new Guid(0x5D3E9A59, 0xE9D5, 0x4B00, 0xA6, 0xBD, 0xFF, 0x34, 0xFF, 0x51, 0x65, 0x48);

        public static readonly Guid GUID_LIDSWITCH_STATE_CHANGE = new Guid(0xBA3E0F4D, 0xB817, 0x4094, 0xA2, 0xD1, 0xD5, 0x63, 0x79, 0xE6, 0xA0, 0xF3);

        public static readonly Guid GUID_BATTERY_PERCENTAGE_REMAINING = new Guid(0xA7AD8041, 0xB45A, 0x4CAE, 0x87, 0xA3, 0xEE, 0xCB, 0xB4, 0x68, 0xA9, 0xE1);

        public static readonly Guid GUID_BATTERY_COUNT = new Guid(0x7D263F15, 0xFCA4, 0x49E5, 0x85, 0x4B, 0xA9, 0xF2, 0xBF, 0xBD, 0x5C, 0x24);

        public static readonly Guid GUID_GLOBAL_USER_PRESENCE = new Guid(0x786E8A1D, 0xB427, 0x4344, 0x92, 0x07, 0x09, 0xE7, 0x0B, 0xDC, 0xBE, 0xA9);

        public static readonly Guid GUID_SESSION_DISPLAY_STATUS = new Guid(0x2B84C20E, 0xAD23, 0x4DDF, 0x93, 0xDB, 0x05, 0xFF, 0xBD, 0x7E, 0xFC, 0xA5);

        public static readonly Guid GUID_SESSION_USER_PRESENCE = new Guid(0x3C0F4548, 0xC03F, 0x4C4D, 0xB9, 0xF2, 0x23, 0x7E, 0xDE, 0x68, 0x63, 0x76);

        public static readonly Guid GUID_IDLE_BACKGROUND_TASK = new Guid(0x515C31D8, 0xF734, 0x163D, 0xA0, 0xFD, 0x11, 0xA0, 0x8C, 0x91, 0xE8, 0xF1);

        public static readonly Guid GUID_BACKGROUND_TASK_NOTIFICATION = new Guid(0xCF23F240, 0x2A54, 0x48D8, 0xB1, 0x14, 0xDE, 0x15, 0x18, 0xFF, 0x05, 0x2E);

        public static readonly Guid GUID_APPLAUNCH_BUTTON = new Guid(0x1A689231, 0x7399, 0x4E9A, 0x8F, 0x99, 0xB7, 0x1F, 0x99, 0x9D, 0xB3, 0xFA);

        public static readonly Guid GUID_PCIEXPRESS_SETTINGS_SUBGROUP = new Guid(0x501A4D13, 0x42AF, 0x4429, 0x9F, 0xD1, 0xA8, 0x21, 0x8C, 0x26, 0x8E, 0x20);

        public static readonly Guid GUID_PCIEXPRESS_ASPM_POLICY = new Guid(0xEE12F906, 0xD277, 0x404B, 0xB6, 0xDA, 0xE5, 0xFA, 0x1A, 0x57, 0x6D, 0xF5);

        public static readonly Guid GUID_ENABLE_SWITCH_FORCED_SHUTDOWN = new Guid(0x833A6B62, 0xDFA4, 0x46D1, 0x82, 0xF8, 0xE0, 0x9E, 0x34, 0xD0, 0x29, 0xD6);

        public static readonly Guid GUID_INTSTEER_SUBGROUP = new Guid(0x48672F38, 0x7A9A, 0x4BB2, 0x8B, 0xF8, 0x3D, 0x85, 0xBE, 0x19, 0xDE, 0x4E);

        public static readonly Guid GUID_INTSTEER_MODE = new Guid(0x2BFC24F9, 0x5EA2, 0x4801, 0x82, 0x13, 0x3D, 0xBA, 0xE0, 0x1A, 0xA3, 0x9D);

        public static readonly Guid GUID_INTSTEER_LOAD_PER_PROC_TRIGGER = new Guid(0x73CDE64D, 0xD720, 0x4BB2, 0xA8, 0x60, 0xC7, 0x55, 0xAF, 0xE7, 0x7E, 0xF2);

        public static readonly Guid GUID_INTSTEER_TIME_UNPARK_TRIGGER = new Guid(0xD6BA4903, 0x386F, 0x4C2C, 0x8A, 0xDB, 0x5C, 0x21, 0xB3, 0x32, 0x8D, 0x25);

        public static readonly Guid GUID_GRAPHICS_SUBGROUP = new Guid(0x5FB4938D, 0x1EE8, 0x4B0F, 0x9A, 0x3C, 0x50, 0x36, 0xB0, 0xAB, 0x99, 0x5C);

        public static readonly Guid GUID_GPU_PREFERENCE_POLICY = new Guid(0xDD848B2A, 0x8A5D, 0x4451, 0x9A, 0xE2, 0x39, 0xCD, 0x41, 0x65, 0x8F, 0x6C);

        public static readonly Guid GUID_MIXED_REALITY_MODE = new Guid(0x1E626B4E, 0xCF04, 0x4F8D, 0x9C, 0xC7, 0xC9, 0x7C, 0x5B, 0x0F, 0x23, 0x91);

        public static readonly Guid GUID_SPR_ACTIVE_SESSION_CHANGE = new Guid(0x0E24CE38, 0xC393, 0x4742, 0xBD, 0xB1, 0x74, 0x4F, 0x4B, 0x9E, 0xE0, 0x8E);

        public static readonly Guid PPM_PERFSTATE_CHANGE_GUID = new Guid(0xA5B32DDD, 0x7F39, 0x4ABC, 0xB8, 0x92, 0x90, 0x0E, 0x43, 0xB5, 0x9E, 0xBB);

        public static readonly Guid PPM_PERFSTATE_DOMAIN_CHANGE_GUID = new Guid(0x995E6B7F, 0xD653, 0x497A, 0xB9, 0x78, 0x36, 0xA3, 0x0C, 0x29, 0xBF, 0x01);

        public static readonly Guid PPM_IDLESTATE_CHANGE_GUID = new Guid(0x4838FE4F, 0xF71C, 0x4E51, 0x9E, 0xCC, 0x84, 0x30, 0xA7, 0xAC, 0x4C, 0x6C);

        public static readonly Guid PPM_PERFSTATES_DATA_GUID = new Guid(0x5708CC20, 0x7D40, 0x4BF4, 0xB4, 0xAA, 0x2B, 0x01, 0x33, 0x8D, 0x01, 0x26);

        public static readonly Guid PPM_IDLESTATES_DATA_GUID = new Guid(0xBA138E10, 0xE250, 0x4AD7, 0x86, 0x16, 0xCF, 0x1A, 0x7A, 0xD4, 0x10, 0xE7);

        public static readonly Guid PPM_IDLE_ACCOUNTING_GUID = new Guid(0xE2A26F78, 0xAE07, 0x4EE0, 0xA3, 0x0F, 0xCE, 0x54, 0xF5, 0x5A, 0x94, 0xCD);

        public static readonly Guid PPM_IDLE_ACCOUNTING_EX_GUID = new Guid(0xD67ABD39, 0x81F8, 0x4A5E, 0x81, 0x52, 0x72, 0xE3, 0x1E, 0xC9, 0x12, 0xEE);

        public static readonly Guid PPM_THERMALCONSTRAINT_GUID = new Guid(0xA852C2C8, 0x1A4C, 0x423B, 0x8C, 0x2C, 0xF3, 0x0D, 0x82, 0x93, 0x1A, 0x88);

        public static readonly Guid PPM_PERFMON_PERFSTATE_GUID = new Guid(0x7FD18652, 0x0CFE, 0x40D2, 0xB0, 0xA1, 0x0B, 0x06, 0x6A, 0x87, 0x75, 0x9E);

        public static readonly Guid PPM_THERMAL_POLICY_CHANGE_GUID = new Guid(0x48F377B8, 0x6880, 0x4C7B, 0x8B, 0xDC, 0x38, 0x01, 0x76, 0xC6, 0x65, 0x4D);


        // Line 137:   #define MAX_NATURAL_ALIGNMENT sizeof(ULONGLONG)
        // Line 140:   #define MAX_NATURAL_ALIGNMENT sizeof(DWORD)
        // Line 151:   #define TYPE_ALIGNMENT( t ) __alignof(t)
        // Line 154:   #define TYPE_ALIGNMENT( t ) \
        // Line 164:   #define PROBE_ALIGNMENT( _s ) TYPE_ALIGNMENT( DWORD )
        // Line 171:   #define PROBE_ALIGNMENT( _s ) TYPE_ALIGNMENT( DWORD )
        // Line 181:   #define PROBE_ALIGNMENT32( _s ) TYPE_ALIGNMENT( DWORD )
        // Line 193:   #define C_ASSERT(e) typedef char __C_ASSERT__[(e)?1:-1]
        // Line 195:   #define C_ASSERT(e) /* nothing */
        // Line 581:   #define __TEXT(quote) L##quote      // r_winnt
        // Line 600:   #define __TEXT(quote) quote         // r_winnt
        // Line 603:   #define TEXT(quote) __TEXT(quote)   // r_winnt
        // Line 643:   #define MAXIMUM_PROCESSORS          MAXIMUM_PROC_PER_GROUP
        // Line 924:   #define Int32x32To64(a, b)  (((__int64)((long)(a))) * ((__int64)((long)(b))))
        // Line 925:   #define UInt32x32To64(a, b) (((unsigned __int64)((unsigned int)(a))) * ((unsigned __int64)((unsigned int)(b))))
        // Line 927:   #define Int64ShllMod32(a, b) (((unsigned __int64)(a)) << (b))
        // Line 928:   #define Int64ShraMod32(a, b) (((__int64)(a)) >> (b))
        // Line 929:   #define Int64ShrlMod32(a, b) (((unsigned __int64)(a)) >> (b))
        // Line 941:   #define Int32x32To64(a, b)  ((__int64)(((__int64)((long)(a))) * ((long)(b))))
        // Line 942:   #define UInt32x32To64(a, b) ((unsigned __int64)(((unsigned __int64)((unsigned int)(a))) * ((unsigned int)(b))))
        // Line 1197:  #define FIELD_OFFSET(type, field)    ((LONG)(LONG_PTR)&(((type *)0)->field))
        // Line 1198:  #define UFIELD_OFFSET(type, field)    ((DWORD)(LONG_PTR)&(((type *)0)->field))
        // Line 1204:  #define RTL_FIELD_SIZE(type, field) (sizeof(((type *)0)->field))
        // Line 1210:  #define RTL_SIZEOF_THROUGH_FIELD(type, field) \
        // Line 1221:  #define RTL_CONTAINS_FIELD(Struct, Size, Field) \
        // Line 1230:  #define RTL_NUMBER_OF_V1(A) (sizeof(A)/sizeof((A)[0]))
        // Line 1280:  #define RTL_NUMBER_OF_V2(A) (sizeof(*RtlpNumberOf(A)))
        // Line 1319:  #define RTL_NUMBER_OF_V2(A) RTL_NUMBER_OF_V1(A)
        // Line 1323:  #define RTL_NUMBER_OF(A) RTL_NUMBER_OF_V2(A)
        // Line 1325:  #define RTL_NUMBER_OF(A) RTL_NUMBER_OF_V1(A)
        // Line 1334:  #define ARRAYSIZE(A)    RTL_NUMBER_OF_V2(A)
        // Line 1335:  #define _ARRAYSIZE(A)   RTL_NUMBER_OF_V1(A)
        // Line 1340:  #define RTL_FIELD_TYPE(type, field) (((type*)0)->field)
        // Line 1347:  #define RTL_NUMBER_OF_FIELD(type, field) (RTL_NUMBER_OF(RTL_FIELD_TYPE(type, field)))
        // Line 1358:  #define RTL_PADDING_BETWEEN_FIELDS(T, F1, F2) \
        // Line 1365:  #define RTL_CONST_CAST(type) const_cast<type>
        // Line 1367:  #define RTL_CONST_CAST(type) (type)
        // Line 1373:  #define RTL_BITS_OF(sizeOfArg) (sizeof(sizeOfArg) * 8)
        // Line 1375:  #define RTL_BITS_OF_FIELD(type, field) (RTL_BITS_OF(RTL_FIELD_TYPE(type, field)))
        // Line 1384:  #define CONTAINING_RECORD(address, type, field) ((type *)( \
        // Line 2182:  #define MAKELANGID(p, s)       ((((WORD  )(s)) << 10) | (WORD  )(p))
        // Line 2183:  #define PRIMARYLANGID(lgid)    ((WORD  )(lgid) & 0x3ff)
        // Line 2184:  #define SUBLANGID(lgid)        ((WORD  )(lgid) >> 10)
        // Line 2227:  #define MAKELCID(lgid, srtid)  ((DWORD)((((DWORD)((WORD  )(srtid))) << 16) |  \
        // Line 2229:  #define MAKESORTLCID(lgid, srtid, ver)                                            \
        // Line 2232:  #define LANGIDFROMLCID(lcid)   ((WORD  )(lcid))
        // Line 2233:  #define SORTIDFROMLCID(lcid)   ((WORD  )((((DWORD)(lcid)) >> 16) & 0xf))
        // Line 2234:  #define SORTVERSIONFROMLCID(lcid)  ((WORD  )((((DWORD)(lcid)) >> 20) & 0xf))
        // Line 2253:  #define LANG_SYSTEM_DEFAULT    (MAKELANGID(LANG_NEUTRAL, SUBLANG_SYS_DEFAULT))
        // Line 2254:  #define LANG_USER_DEFAULT      (MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT))
        // Line 2256:  #define LOCALE_SYSTEM_DEFAULT  (MAKELCID(LANG_SYSTEM_DEFAULT, SORT_DEFAULT))
        // Line 2257:  #define LOCALE_USER_DEFAULT    (MAKELCID(LANG_USER_DEFAULT, SORT_DEFAULT))
        // Line 2266:  #define LOCALE_CUSTOM_DEFAULT                                                 \
        // Line 2269:  #define LOCALE_CUSTOM_UNSPECIFIED                                             \
        // Line 2272:  #define LOCALE_CUSTOM_UI_DEFAULT                                              \
        // Line 2275:  #define LOCALE_NEUTRAL                                                        \
        // Line 2278:  #define LOCALE_INVARIANT                                                      \
        // Line 2302:  #define LOCALE_UNASSIGNED_LCID LOCALE_CUSTOM_UNSPECIFIED
        // Line 2450:  #define DEFINE_ENUM_FLAG_OPERATORS(ENUMTYPE) \
        // Line 2461:  #define DEFINE_ENUM_FLAG_OPERATORS(ENUMTYPE) // NOP, C allows these operators.
        // Line 2472:  #define COMPILETIME_OR_2FLAGS(a,b)          ((UINT)(a)|(UINT)(b))
        // Line 2473:  #define COMPILETIME_OR_3FLAGS(a,b,c)        ((UINT)(a)|(UINT)(b)|(UINT)(c))
        // Line 2474:  #define COMPILETIME_OR_4FLAGS(a,b,c,d)      ((UINT)(a)|(UINT)(b)|(UINT)(c)|(UINT)(d))
        // Line 2475:  #define COMPILETIME_OR_5FLAGS(a,b,c,d,e)    ((UINT)(a)|(UINT)(b)|(UINT)(c)|(UINT)(d)|(UINT)(e))
        // Line 2476:  #define COMPILETIME_OR_6FLAGS(a,b,c,d,e,f)  ((UINT)(a)|(UINT)(b)|(UINT)(c)|(UINT)(d)|(UINT)(e)|(UINT)(f))
        // Line 8814:  #define IS_UNWINDING(Flag) ((Flag & EXCEPTION_UNWIND) != 0)
        // Line 8815:  #define IS_DISPATCHING(Flag) ((Flag & EXCEPTION_UNWIND) == 0)
        // Line 8816:  #define IS_TARGET_UNWIND(Flag) (Flag & EXCEPTION_TARGET_UNWIND)
        // Line 9074:  #define SECURITY_MAX_SID_SIZE  \
        // Line 9077:  #define SECURITY_SID_SIZE(SubAuthorityCount_) (sizeof(SID) - sizeof(DWORD) + \
        // Line 9089:  #define SECURITY_MAX_SID_STRING_CHARACTERS \
        // Line 9156:  #define SECURITY_NULL_SID_AUTHORITY         {0,0,0,0,0,0}
        // Line 9157:  #define SECURITY_WORLD_SID_AUTHORITY        {0,0,0,0,0,1}
        // Line 9158:  #define SECURITY_LOCAL_SID_AUTHORITY        {0,0,0,0,0,2}
        // Line 9159:  #define SECURITY_CREATOR_SID_AUTHORITY      {0,0,0,0,0,3}
        // Line 9160:  #define SECURITY_NON_UNIQUE_AUTHORITY       {0,0,0,0,0,4}
        // Line 9161:  #define SECURITY_RESOURCE_MANAGER_AUTHORITY {0,0,0,0,0,9}
        // Line 9224:  #define SECURITY_NT_AUTHORITY           {0,0,0,0,0,5}   // ntifs
        // Line 9431:  #define SECURITY_APP_PACKAGE_AUTHORITY              {0,0,0,0,0,15}
        // Line 9473:  #define SECURITY_MANDATORY_LABEL_AUTHORITY          {0,0,0,0,0,16}
        // Line 9489:  #define MANDATORY_LEVEL_TO_MANDATORY_RID(IL) (IL * 0x1000)
        // Line 9491:  #define SECURITY_SCOPED_POLICY_ID_AUTHORITY             {0,0,0,0,0,17}
        // Line 9497:  #define SECURITY_AUTHENTICATION_AUTHORITY                        {0,0,0,0,0,18}
        // Line 9510:  #define SECURITY_PROCESS_TRUST_AUTHORITY    {0,0,0,0,0,19}
        // Line 9671:  #define SYSTEM_LUID                     { 0x3e7, 0x0 }
        // Line 9672:  #define ANONYMOUS_LOGON_LUID            { 0x3e6, 0x0 }
        // Line 9673:  #define LOCALSERVICE_LUID               { 0x3e5, 0x0 }
        // Line 9674:  #define NETWORKSERVICE_LUID             { 0x3e4, 0x0 }
        // Line 9675:  #define IUSER_LUID                      { 0x3e3, 0x0 }
        // Line 9676:  #define PROTECTED_TO_SYSTEM_LUID        { 0x3e2, 0x0 }
        // Line 10180: #define SECURITY_DESCRIPTOR_MIN_LENGTH   (sizeof(SECURITY_DESCRIPTOR))
        // Line 10647: #define VALID_IMPERSONATION_LEVEL(L) (((L) >= SECURITY_MIN_IMPERSONATION_LEVEL) && ((L) <= SECURITY_MAX_IMPERSONATION_LEVEL))
        // Line 10817: #define TOKEN_USER_MAX_SIZE (sizeof(TOKEN_USER) + SECURITY_MAX_SID_SIZE)
        // Line 10842: #define TOKEN_OWNER_MAX_SIZE (sizeof(TOKEN_OWNER) + SECURITY_MAX_SID_SIZE)
        // Line 10895: #define TOKEN_INTEGRITY_LEVEL_MAX_SIZE ((((DWORD)(sizeof(TOKEN_MANDATORY_LABEL)) + sizeof(PVOID) - 1) & ~(sizeof(PVOID)-1)) + SECURITY_MAX_SID_SIZE)
        // Line 10980: #define TOKEN_APPCONTAINER_SID_MAX_SIZE (sizeof(TOKEN_APPCONTAINER_INFORMATION) + SECURITY_MAX_SID_SIZE)
        // Line 12908: #define MEM_EXTENDED_PARAMETER_NUMA_NODE_MANDATORY      MINLONG64
        // Line 13299: #define REPARSE_GUID_DATA_BUFFER_HEADER_SIZE   UFIELD_OFFSET(REPARSE_GUID_DATA_BUFFER, GenericReparseBuffer)
        // Line 13356: #define IsReparseTagMicrosoft(_tag) (              \
        // Line 13364: #define IsReparseTagNameSurrogate(_tag) (          \
        // Line 13373: #define IsReparseTagDirectory(_tag) (    \
        // Line 13746: #define IsVirtualDiskFileShared(HandleState) (((HandleState) & SharedVirtualDiskHandleStateFileShared) != 0)
        // Line 17009: #define IMAGE_FIRST_SECTION( ntheader ) ((PIMAGE_SECTION_HEADER)        \
        // Line 17335: #define BTYPE(x) ((x) & N_BTMASK)
        // Line 17339: #define ISPTR(x) (((x) & N_TMASK) == (IMAGE_SYM_DTYPE_POINTER << N_BTSHFT))
        // Line 17344: #define ISFCN(x) (((x) & N_TMASK) == (IMAGE_SYM_DTYPE_FUNCTION << N_BTSHFT))
        // Line 17350: #define ISARY(x) (((x) & N_TMASK) == (IMAGE_SYM_DTYPE_ARRAY << N_BTSHFT))
        // Line 17355: #define ISTAG(x) ((x)==IMAGE_SYM_CLASS_STRUCT_TAG || (x)==IMAGE_SYM_CLASS_UNION_TAG || (x)==IMAGE_SYM_CLASS_ENUM_TAG)
        // Line 17359: #define INCREF(x) ((((x)&~N_BTMASK)<<N_TSHIFT)|(IMAGE_SYM_DTYPE_POINTER<<N_BTSHFT)|((x)&N_BTMASK))
        // Line 17362: #define DECREF(x) ((((x)>>N_TSHIFT)&~N_BTMASK)|((x)&N_BTMASK))
        // Line 17793: #define EXT_IMM64(Value, Address, Size, InstPos, ValPos)  /* Intel-IA64-Filler */           \
        // Line 17796: #define INS_IMM64(Value, Address, Size, InstPos, ValPos)  /* Intel-IA64-Filler */\
        // Line 18032: #define IMAGE_ORDINAL64(Ordinal) (Ordinal & 0xffff)
        // Line 18033: #define IMAGE_ORDINAL32(Ordinal) (Ordinal & 0xffff)
        // Line 18034: #define IMAGE_SNAP_BY_ORDINAL64(Ordinal) ((Ordinal & IMAGE_ORDINAL_FLAG64) != 0)
        // Line 18035: #define IMAGE_SNAP_BY_ORDINAL32(Ordinal) ((Ordinal & IMAGE_ORDINAL_FLAG32) != 0)
        // Line 18087: #define IMAGE_ORDINAL(Ordinal)          IMAGE_ORDINAL64(Ordinal)
        // Line 18090: #define IMAGE_SNAP_BY_ORDINAL(Ordinal)  IMAGE_SNAP_BY_ORDINAL64(Ordinal)
        // Line 18095: #define IMAGE_ORDINAL(Ordinal)          IMAGE_ORDINAL32(Ordinal)
        // Line 18098: #define IMAGE_SNAP_BY_ORDINAL(Ordinal)  IMAGE_SNAP_BY_ORDINAL32(Ordinal)
        // Line 18721: #define IMAGE_ENCLAVE_MINIMUM_CONFIG_SIZE   FIELD_OFFSET(IMAGE_ENCLAVE_CONFIG, EnclaveFlags)
        // Line 19803: #define RTL_RUN_ONCE_INIT {0}   // Static initializer
        // Line 20218: #define VER_SET_CONDITION(_m_,_t_,_c_)  \
        // Line 20310: #define IS_VALIDATION_ENABLED(C,L) ((L) & (C))
        // Line 20602: #define RtlGetNonVolatileToken(B,S,T) \
        // Line 20605: #define RtlFreeNonVolatileToken(T) \
        // Line 20608: #define RtlFlushNonVolatileMemory(T,B,S,F) \
        // Line 20611: #define RtlDrainNonVolatileFlush(T) \
        // Line 20614: #define RtlWriteNonVolatileMemory(T,D,S,L,F) \
        // Line 20619: #define RtlFillNonVolatileMemory(T,B,S,V,F) \
        // Line 20624: #define RtlFlushNonVolatileMemoryRanges(T,R,N,F) \
        // Line 20657: #define TraceLoggingCORRELATION_VECTOR(cv) TraceLoggingString((cv).Vector, "__TlgCV__")
        // Line 20740: #define IMAGE_POLICY_METADATA_NAME __ImagePolicyMetadata
        // Line 20806: #define IMAGE_POLICY_START(_ApplicationId_)                                   \
        // Line 20815: #define IMAGE_POLICY_END()                                                    \
        // Line 20821: #define IMAGE_POLICY_BOOL(_PolicyId_, _Value_)             \
        // Line 20824: #define IMAGE_POLICY_INT8(_PolicyId_, _Value_)             \
        // Line 20827: #define IMAGE_POLICY_UINT8(_PolicyId_, _Value_)            \
        // Line 20830: #define IMAGE_POLICY_INT16(_PolicyId_, _Value_)            \
        // Line 20833: #define IMAGE_POLICY_UINT16(_PolicyId_, _Value_)           \
        // Line 20836: #define IMAGE_POLICY_INT32(_PolicyId_, _Value_)            \
        // Line 20839: #define IMAGE_POLICY_UINT32(_PolicyId_, _Value_)           \
        // Line 20842: #define IMAGE_POLICY_INT64(_PolicyId_, _Value_)            \
        // Line 20845: #define IMAGE_POLICY_UINT64(_PolicyId_, _Value_)           \
        // Line 20848: #define IMAGE_POLICY_ANSI_STRING(_PolicyId_, _Value_)      \
        // Line 20851: #define IMAGE_POLICY_UNICODE_STRING(_PolicyId_, _Value_)   \
        // Line 20854: #define IMAGE_POLICY_OVERRIDE(_PolicyId_)   \
        // Line 20908: #define RTL_SRWLOCK_INIT {0}                            
        // Line 20912: #define RTL_CONDITION_VARIABLE_INIT {0}                 
        // Line 20963: #define WT_SET_MAX_THREADPOOL_THREADS(Flags, Limit)  ((Flags) |= (Limit)<<16) 
    }
}
