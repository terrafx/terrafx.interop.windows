// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipifcons.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IF
{
    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_OTHER"]/*' />
    [NativeTypeName("#define IF_TYPE_OTHER 1")]
    public const int IF_TYPE_OTHER = 1;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_REGULAR_1822"]/*' />
    [NativeTypeName("#define IF_TYPE_REGULAR_1822 2")]
    public const int IF_TYPE_REGULAR_1822 = 2;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HDH_1822"]/*' />
    [NativeTypeName("#define IF_TYPE_HDH_1822 3")]
    public const int IF_TYPE_HDH_1822 = 3;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DDN_X25"]/*' />
    [NativeTypeName("#define IF_TYPE_DDN_X25 4")]
    public const int IF_TYPE_DDN_X25 = 4;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_RFC877_X25"]/*' />
    [NativeTypeName("#define IF_TYPE_RFC877_X25 5")]
    public const int IF_TYPE_RFC877_X25 = 5;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ETHERNET_CSMACD"]/*' />
    [NativeTypeName("#define IF_TYPE_ETHERNET_CSMACD 6")]
    public const int IF_TYPE_ETHERNET_CSMACD = 6;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IS088023_CSMACD"]/*' />
    [NativeTypeName("#define IF_TYPE_IS088023_CSMACD 7")]
    public const int IF_TYPE_IS088023_CSMACD = 7;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISO88024_TOKENBUS"]/*' />
    [NativeTypeName("#define IF_TYPE_ISO88024_TOKENBUS 8")]
    public const int IF_TYPE_ISO88024_TOKENBUS = 8;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISO88025_TOKENRING"]/*' />
    [NativeTypeName("#define IF_TYPE_ISO88025_TOKENRING 9")]
    public const int IF_TYPE_ISO88025_TOKENRING = 9;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISO88026_MAN"]/*' />
    [NativeTypeName("#define IF_TYPE_ISO88026_MAN 10")]
    public const int IF_TYPE_ISO88026_MAN = 10;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_STARLAN"]/*' />
    [NativeTypeName("#define IF_TYPE_STARLAN 11")]
    public const int IF_TYPE_STARLAN = 11;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROTEON_10MBIT"]/*' />
    [NativeTypeName("#define IF_TYPE_PROTEON_10MBIT 12")]
    public const int IF_TYPE_PROTEON_10MBIT = 12;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROTEON_80MBIT"]/*' />
    [NativeTypeName("#define IF_TYPE_PROTEON_80MBIT 13")]
    public const int IF_TYPE_PROTEON_80MBIT = 13;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HYPERCHANNEL"]/*' />
    [NativeTypeName("#define IF_TYPE_HYPERCHANNEL 14")]
    public const int IF_TYPE_HYPERCHANNEL = 14;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FDDI"]/*' />
    [NativeTypeName("#define IF_TYPE_FDDI 15")]
    public const int IF_TYPE_FDDI = 15;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_LAP_B"]/*' />
    [NativeTypeName("#define IF_TYPE_LAP_B 16")]
    public const int IF_TYPE_LAP_B = 16;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SDLC"]/*' />
    [NativeTypeName("#define IF_TYPE_SDLC 17")]
    public const int IF_TYPE_SDLC = 17;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DS1"]/*' />
    [NativeTypeName("#define IF_TYPE_DS1 18")]
    public const int IF_TYPE_DS1 = 18;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_E1"]/*' />
    [NativeTypeName("#define IF_TYPE_E1 19")]
    public const int IF_TYPE_E1 = 19;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_BASIC_ISDN"]/*' />
    [NativeTypeName("#define IF_TYPE_BASIC_ISDN 20")]
    public const int IF_TYPE_BASIC_ISDN = 20;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PRIMARY_ISDN"]/*' />
    [NativeTypeName("#define IF_TYPE_PRIMARY_ISDN 21")]
    public const int IF_TYPE_PRIMARY_ISDN = 21;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_POINT2POINT_SERIAL"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_POINT2POINT_SERIAL 22")]
    public const int IF_TYPE_PROP_POINT2POINT_SERIAL = 22;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PPP"]/*' />
    [NativeTypeName("#define IF_TYPE_PPP 23")]
    public const int IF_TYPE_PPP = 23;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SOFTWARE_LOOPBACK"]/*' />
    [NativeTypeName("#define IF_TYPE_SOFTWARE_LOOPBACK 24")]
    public const int IF_TYPE_SOFTWARE_LOOPBACK = 24;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_EON"]/*' />
    [NativeTypeName("#define IF_TYPE_EON 25")]
    public const int IF_TYPE_EON = 25;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ETHERNET_3MBIT"]/*' />
    [NativeTypeName("#define IF_TYPE_ETHERNET_3MBIT 26")]
    public const int IF_TYPE_ETHERNET_3MBIT = 26;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_NSIP"]/*' />
    [NativeTypeName("#define IF_TYPE_NSIP 27")]
    public const int IF_TYPE_NSIP = 27;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SLIP"]/*' />
    [NativeTypeName("#define IF_TYPE_SLIP 28")]
    public const int IF_TYPE_SLIP = 28;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ULTRA"]/*' />
    [NativeTypeName("#define IF_TYPE_ULTRA 29")]
    public const int IF_TYPE_ULTRA = 29;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DS3"]/*' />
    [NativeTypeName("#define IF_TYPE_DS3 30")]
    public const int IF_TYPE_DS3 = 30;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SIP"]/*' />
    [NativeTypeName("#define IF_TYPE_SIP 31")]
    public const int IF_TYPE_SIP = 31;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FRAMERELAY"]/*' />
    [NativeTypeName("#define IF_TYPE_FRAMERELAY 32")]
    public const int IF_TYPE_FRAMERELAY = 32;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_RS232"]/*' />
    [NativeTypeName("#define IF_TYPE_RS232 33")]
    public const int IF_TYPE_RS232 = 33;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PARA"]/*' />
    [NativeTypeName("#define IF_TYPE_PARA 34")]
    public const int IF_TYPE_PARA = 34;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ARCNET"]/*' />
    [NativeTypeName("#define IF_TYPE_ARCNET 35")]
    public const int IF_TYPE_ARCNET = 35;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ARCNET_PLUS"]/*' />
    [NativeTypeName("#define IF_TYPE_ARCNET_PLUS 36")]
    public const int IF_TYPE_ARCNET_PLUS = 36;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM 37")]
    public const int IF_TYPE_ATM = 37;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MIO_X25"]/*' />
    [NativeTypeName("#define IF_TYPE_MIO_X25 38")]
    public const int IF_TYPE_MIO_X25 = 38;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SONET"]/*' />
    [NativeTypeName("#define IF_TYPE_SONET 39")]
    public const int IF_TYPE_SONET = 39;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_X25_PLE"]/*' />
    [NativeTypeName("#define IF_TYPE_X25_PLE 40")]
    public const int IF_TYPE_X25_PLE = 40;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISO88022_LLC"]/*' />
    [NativeTypeName("#define IF_TYPE_ISO88022_LLC 41")]
    public const int IF_TYPE_ISO88022_LLC = 41;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_LOCALTALK"]/*' />
    [NativeTypeName("#define IF_TYPE_LOCALTALK 42")]
    public const int IF_TYPE_LOCALTALK = 42;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SMDS_DXI"]/*' />
    [NativeTypeName("#define IF_TYPE_SMDS_DXI 43")]
    public const int IF_TYPE_SMDS_DXI = 43;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FRAMERELAY_SERVICE"]/*' />
    [NativeTypeName("#define IF_TYPE_FRAMERELAY_SERVICE 44")]
    public const int IF_TYPE_FRAMERELAY_SERVICE = 44;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_V35"]/*' />
    [NativeTypeName("#define IF_TYPE_V35 45")]
    public const int IF_TYPE_V35 = 45;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HSSI"]/*' />
    [NativeTypeName("#define IF_TYPE_HSSI 46")]
    public const int IF_TYPE_HSSI = 46;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HIPPI"]/*' />
    [NativeTypeName("#define IF_TYPE_HIPPI 47")]
    public const int IF_TYPE_HIPPI = 47;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MODEM"]/*' />
    [NativeTypeName("#define IF_TYPE_MODEM 48")]
    public const int IF_TYPE_MODEM = 48;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_AAL5"]/*' />
    [NativeTypeName("#define IF_TYPE_AAL5 49")]
    public const int IF_TYPE_AAL5 = 49;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SONET_PATH"]/*' />
    [NativeTypeName("#define IF_TYPE_SONET_PATH 50")]
    public const int IF_TYPE_SONET_PATH = 50;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SONET_VT"]/*' />
    [NativeTypeName("#define IF_TYPE_SONET_VT 51")]
    public const int IF_TYPE_SONET_VT = 51;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SMDS_ICIP"]/*' />
    [NativeTypeName("#define IF_TYPE_SMDS_ICIP 52")]
    public const int IF_TYPE_SMDS_ICIP = 52;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_VIRTUAL"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_VIRTUAL 53")]
    public const int IF_TYPE_PROP_VIRTUAL = 53;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_MULTIPLEXOR"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_MULTIPLEXOR 54")]
    public const int IF_TYPE_PROP_MULTIPLEXOR = 54;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IEEE80212"]/*' />
    [NativeTypeName("#define IF_TYPE_IEEE80212 55")]
    public const int IF_TYPE_IEEE80212 = 55;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FIBRECHANNEL"]/*' />
    [NativeTypeName("#define IF_TYPE_FIBRECHANNEL 56")]
    public const int IF_TYPE_FIBRECHANNEL = 56;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HIPPIINTERFACE"]/*' />
    [NativeTypeName("#define IF_TYPE_HIPPIINTERFACE 57")]
    public const int IF_TYPE_HIPPIINTERFACE = 57;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FRAMERELAY_INTERCONNECT"]/*' />
    [NativeTypeName("#define IF_TYPE_FRAMERELAY_INTERCONNECT 58")]
    public const int IF_TYPE_FRAMERELAY_INTERCONNECT = 58;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_AFLANE_8023"]/*' />
    [NativeTypeName("#define IF_TYPE_AFLANE_8023 59")]
    public const int IF_TYPE_AFLANE_8023 = 59;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_AFLANE_8025"]/*' />
    [NativeTypeName("#define IF_TYPE_AFLANE_8025 60")]
    public const int IF_TYPE_AFLANE_8025 = 60;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_CCTEMUL"]/*' />
    [NativeTypeName("#define IF_TYPE_CCTEMUL 61")]
    public const int IF_TYPE_CCTEMUL = 61;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FASTETHER"]/*' />
    [NativeTypeName("#define IF_TYPE_FASTETHER 62")]
    public const int IF_TYPE_FASTETHER = 62;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISDN"]/*' />
    [NativeTypeName("#define IF_TYPE_ISDN 63")]
    public const int IF_TYPE_ISDN = 63;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_V11"]/*' />
    [NativeTypeName("#define IF_TYPE_V11 64")]
    public const int IF_TYPE_V11 = 64;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_V36"]/*' />
    [NativeTypeName("#define IF_TYPE_V36 65")]
    public const int IF_TYPE_V36 = 65;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_G703_64K"]/*' />
    [NativeTypeName("#define IF_TYPE_G703_64K 66")]
    public const int IF_TYPE_G703_64K = 66;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_G703_2MB"]/*' />
    [NativeTypeName("#define IF_TYPE_G703_2MB 67")]
    public const int IF_TYPE_G703_2MB = 67;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_QLLC"]/*' />
    [NativeTypeName("#define IF_TYPE_QLLC 68")]
    public const int IF_TYPE_QLLC = 68;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FASTETHER_FX"]/*' />
    [NativeTypeName("#define IF_TYPE_FASTETHER_FX 69")]
    public const int IF_TYPE_FASTETHER_FX = 69;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_CHANNEL"]/*' />
    [NativeTypeName("#define IF_TYPE_CHANNEL 70")]
    public const int IF_TYPE_CHANNEL = 70;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IEEE80211"]/*' />
    [NativeTypeName("#define IF_TYPE_IEEE80211 71")]
    public const int IF_TYPE_IEEE80211 = 71;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IBM370PARCHAN"]/*' />
    [NativeTypeName("#define IF_TYPE_IBM370PARCHAN 72")]
    public const int IF_TYPE_IBM370PARCHAN = 72;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ESCON"]/*' />
    [NativeTypeName("#define IF_TYPE_ESCON 73")]
    public const int IF_TYPE_ESCON = 73;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DLSW"]/*' />
    [NativeTypeName("#define IF_TYPE_DLSW 74")]
    public const int IF_TYPE_DLSW = 74;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISDN_S"]/*' />
    [NativeTypeName("#define IF_TYPE_ISDN_S 75")]
    public const int IF_TYPE_ISDN_S = 75;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISDN_U"]/*' />
    [NativeTypeName("#define IF_TYPE_ISDN_U 76")]
    public const int IF_TYPE_ISDN_U = 76;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_LAP_D"]/*' />
    [NativeTypeName("#define IF_TYPE_LAP_D 77")]
    public const int IF_TYPE_LAP_D = 77;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IPSWITCH"]/*' />
    [NativeTypeName("#define IF_TYPE_IPSWITCH 78")]
    public const int IF_TYPE_IPSWITCH = 78;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_RSRB"]/*' />
    [NativeTypeName("#define IF_TYPE_RSRB 79")]
    public const int IF_TYPE_RSRB = 79;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM_LOGICAL"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM_LOGICAL 80")]
    public const int IF_TYPE_ATM_LOGICAL = 80;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DS0"]/*' />
    [NativeTypeName("#define IF_TYPE_DS0 81")]
    public const int IF_TYPE_DS0 = 81;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DS0_BUNDLE"]/*' />
    [NativeTypeName("#define IF_TYPE_DS0_BUNDLE 82")]
    public const int IF_TYPE_DS0_BUNDLE = 82;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_BSC"]/*' />
    [NativeTypeName("#define IF_TYPE_BSC 83")]
    public const int IF_TYPE_BSC = 83;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ASYNC"]/*' />
    [NativeTypeName("#define IF_TYPE_ASYNC 84")]
    public const int IF_TYPE_ASYNC = 84;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_CNR"]/*' />
    [NativeTypeName("#define IF_TYPE_CNR 85")]
    public const int IF_TYPE_CNR = 85;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISO88025R_DTR"]/*' />
    [NativeTypeName("#define IF_TYPE_ISO88025R_DTR 86")]
    public const int IF_TYPE_ISO88025R_DTR = 86;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_EPLRS"]/*' />
    [NativeTypeName("#define IF_TYPE_EPLRS 87")]
    public const int IF_TYPE_EPLRS = 87;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ARAP"]/*' />
    [NativeTypeName("#define IF_TYPE_ARAP 88")]
    public const int IF_TYPE_ARAP = 88;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_CNLS"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_CNLS 89")]
    public const int IF_TYPE_PROP_CNLS = 89;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HOSTPAD"]/*' />
    [NativeTypeName("#define IF_TYPE_HOSTPAD 90")]
    public const int IF_TYPE_HOSTPAD = 90;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_TERMPAD"]/*' />
    [NativeTypeName("#define IF_TYPE_TERMPAD 91")]
    public const int IF_TYPE_TERMPAD = 91;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FRAMERELAY_MPI"]/*' />
    [NativeTypeName("#define IF_TYPE_FRAMERELAY_MPI 92")]
    public const int IF_TYPE_FRAMERELAY_MPI = 92;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_X213"]/*' />
    [NativeTypeName("#define IF_TYPE_X213 93")]
    public const int IF_TYPE_X213 = 93;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ADSL"]/*' />
    [NativeTypeName("#define IF_TYPE_ADSL 94")]
    public const int IF_TYPE_ADSL = 94;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_RADSL"]/*' />
    [NativeTypeName("#define IF_TYPE_RADSL 95")]
    public const int IF_TYPE_RADSL = 95;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SDSL"]/*' />
    [NativeTypeName("#define IF_TYPE_SDSL 96")]
    public const int IF_TYPE_SDSL = 96;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VDSL"]/*' />
    [NativeTypeName("#define IF_TYPE_VDSL 97")]
    public const int IF_TYPE_VDSL = 97;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISO88025_CRFPRINT"]/*' />
    [NativeTypeName("#define IF_TYPE_ISO88025_CRFPRINT 98")]
    public const int IF_TYPE_ISO88025_CRFPRINT = 98;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MYRINET"]/*' />
    [NativeTypeName("#define IF_TYPE_MYRINET 99")]
    public const int IF_TYPE_MYRINET = 99;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VOICE_EM"]/*' />
    [NativeTypeName("#define IF_TYPE_VOICE_EM 100")]
    public const int IF_TYPE_VOICE_EM = 100;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VOICE_FXO"]/*' />
    [NativeTypeName("#define IF_TYPE_VOICE_FXO 101")]
    public const int IF_TYPE_VOICE_FXO = 101;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VOICE_FXS"]/*' />
    [NativeTypeName("#define IF_TYPE_VOICE_FXS 102")]
    public const int IF_TYPE_VOICE_FXS = 102;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VOICE_ENCAP"]/*' />
    [NativeTypeName("#define IF_TYPE_VOICE_ENCAP 103")]
    public const int IF_TYPE_VOICE_ENCAP = 103;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VOICE_OVERIP"]/*' />
    [NativeTypeName("#define IF_TYPE_VOICE_OVERIP 104")]
    public const int IF_TYPE_VOICE_OVERIP = 104;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM_DXI"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM_DXI 105")]
    public const int IF_TYPE_ATM_DXI = 105;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM_FUNI"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM_FUNI 106")]
    public const int IF_TYPE_ATM_FUNI = 106;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM_IMA"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM_IMA 107")]
    public const int IF_TYPE_ATM_IMA = 107;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PPPMULTILINKBUNDLE"]/*' />
    [NativeTypeName("#define IF_TYPE_PPPMULTILINKBUNDLE 108")]
    public const int IF_TYPE_PPPMULTILINKBUNDLE = 108;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IPOVER_CDLC"]/*' />
    [NativeTypeName("#define IF_TYPE_IPOVER_CDLC 109")]
    public const int IF_TYPE_IPOVER_CDLC = 109;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IPOVER_CLAW"]/*' />
    [NativeTypeName("#define IF_TYPE_IPOVER_CLAW 110")]
    public const int IF_TYPE_IPOVER_CLAW = 110;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_STACKTOSTACK"]/*' />
    [NativeTypeName("#define IF_TYPE_STACKTOSTACK 111")]
    public const int IF_TYPE_STACKTOSTACK = 111;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VIRTUALIPADDRESS"]/*' />
    [NativeTypeName("#define IF_TYPE_VIRTUALIPADDRESS 112")]
    public const int IF_TYPE_VIRTUALIPADDRESS = 112;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MPC"]/*' />
    [NativeTypeName("#define IF_TYPE_MPC 113")]
    public const int IF_TYPE_MPC = 113;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IPOVER_ATM"]/*' />
    [NativeTypeName("#define IF_TYPE_IPOVER_ATM 114")]
    public const int IF_TYPE_IPOVER_ATM = 114;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISO88025_FIBER"]/*' />
    [NativeTypeName("#define IF_TYPE_ISO88025_FIBER 115")]
    public const int IF_TYPE_ISO88025_FIBER = 115;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_TDLC"]/*' />
    [NativeTypeName("#define IF_TYPE_TDLC 116")]
    public const int IF_TYPE_TDLC = 116;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_GIGABITETHERNET"]/*' />
    [NativeTypeName("#define IF_TYPE_GIGABITETHERNET 117")]
    public const int IF_TYPE_GIGABITETHERNET = 117;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HDLC"]/*' />
    [NativeTypeName("#define IF_TYPE_HDLC 118")]
    public const int IF_TYPE_HDLC = 118;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_LAP_F"]/*' />
    [NativeTypeName("#define IF_TYPE_LAP_F 119")]
    public const int IF_TYPE_LAP_F = 119;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_V37"]/*' />
    [NativeTypeName("#define IF_TYPE_V37 120")]
    public const int IF_TYPE_V37 = 120;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_X25_MLP"]/*' />
    [NativeTypeName("#define IF_TYPE_X25_MLP 121")]
    public const int IF_TYPE_X25_MLP = 121;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_X25_HUNTGROUP"]/*' />
    [NativeTypeName("#define IF_TYPE_X25_HUNTGROUP 122")]
    public const int IF_TYPE_X25_HUNTGROUP = 122;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_TRANSPHDLC"]/*' />
    [NativeTypeName("#define IF_TYPE_TRANSPHDLC 123")]
    public const int IF_TYPE_TRANSPHDLC = 123;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_INTERLEAVE"]/*' />
    [NativeTypeName("#define IF_TYPE_INTERLEAVE 124")]
    public const int IF_TYPE_INTERLEAVE = 124;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FAST"]/*' />
    [NativeTypeName("#define IF_TYPE_FAST 125")]
    public const int IF_TYPE_FAST = 125;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IP"]/*' />
    [NativeTypeName("#define IF_TYPE_IP 126")]
    public const int IF_TYPE_IP = 126;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DOCSCABLE_MACLAYER"]/*' />
    [NativeTypeName("#define IF_TYPE_DOCSCABLE_MACLAYER 127")]
    public const int IF_TYPE_DOCSCABLE_MACLAYER = 127;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DOCSCABLE_DOWNSTREAM"]/*' />
    [NativeTypeName("#define IF_TYPE_DOCSCABLE_DOWNSTREAM 128")]
    public const int IF_TYPE_DOCSCABLE_DOWNSTREAM = 128;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DOCSCABLE_UPSTREAM"]/*' />
    [NativeTypeName("#define IF_TYPE_DOCSCABLE_UPSTREAM 129")]
    public const int IF_TYPE_DOCSCABLE_UPSTREAM = 129;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_A12MPPSWITCH"]/*' />
    [NativeTypeName("#define IF_TYPE_A12MPPSWITCH 130")]
    public const int IF_TYPE_A12MPPSWITCH = 130;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_TUNNEL"]/*' />
    [NativeTypeName("#define IF_TYPE_TUNNEL 131")]
    public const int IF_TYPE_TUNNEL = 131;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_COFFEE"]/*' />
    [NativeTypeName("#define IF_TYPE_COFFEE 132")]
    public const int IF_TYPE_COFFEE = 132;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_CES"]/*' />
    [NativeTypeName("#define IF_TYPE_CES 133")]
    public const int IF_TYPE_CES = 133;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM_SUBINTERFACE"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM_SUBINTERFACE 134")]
    public const int IF_TYPE_ATM_SUBINTERFACE = 134;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_L2_VLAN"]/*' />
    [NativeTypeName("#define IF_TYPE_L2_VLAN 135")]
    public const int IF_TYPE_L2_VLAN = 135;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_L3_IPVLAN"]/*' />
    [NativeTypeName("#define IF_TYPE_L3_IPVLAN 136")]
    public const int IF_TYPE_L3_IPVLAN = 136;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_L3_IPXVLAN"]/*' />
    [NativeTypeName("#define IF_TYPE_L3_IPXVLAN 137")]
    public const int IF_TYPE_L3_IPXVLAN = 137;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DIGITALPOWERLINE"]/*' />
    [NativeTypeName("#define IF_TYPE_DIGITALPOWERLINE 138")]
    public const int IF_TYPE_DIGITALPOWERLINE = 138;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MEDIAMAILOVERIP"]/*' />
    [NativeTypeName("#define IF_TYPE_MEDIAMAILOVERIP 139")]
    public const int IF_TYPE_MEDIAMAILOVERIP = 139;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DTM"]/*' />
    [NativeTypeName("#define IF_TYPE_DTM 140")]
    public const int IF_TYPE_DTM = 140;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DCN"]/*' />
    [NativeTypeName("#define IF_TYPE_DCN 141")]
    public const int IF_TYPE_DCN = 141;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IPFORWARD"]/*' />
    [NativeTypeName("#define IF_TYPE_IPFORWARD 142")]
    public const int IF_TYPE_IPFORWARD = 142;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MSDSL"]/*' />
    [NativeTypeName("#define IF_TYPE_MSDSL 143")]
    public const int IF_TYPE_MSDSL = 143;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IEEE1394"]/*' />
    [NativeTypeName("#define IF_TYPE_IEEE1394 144")]
    public const int IF_TYPE_IEEE1394 = 144;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IF_GSN"]/*' />
    [NativeTypeName("#define IF_TYPE_IF_GSN 145")]
    public const int IF_TYPE_IF_GSN = 145;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DVBRCC_MACLAYER"]/*' />
    [NativeTypeName("#define IF_TYPE_DVBRCC_MACLAYER 146")]
    public const int IF_TYPE_DVBRCC_MACLAYER = 146;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DVBRCC_DOWNSTREAM"]/*' />
    [NativeTypeName("#define IF_TYPE_DVBRCC_DOWNSTREAM 147")]
    public const int IF_TYPE_DVBRCC_DOWNSTREAM = 147;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DVBRCC_UPSTREAM"]/*' />
    [NativeTypeName("#define IF_TYPE_DVBRCC_UPSTREAM 148")]
    public const int IF_TYPE_DVBRCC_UPSTREAM = 148;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM_VIRTUAL"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM_VIRTUAL 149")]
    public const int IF_TYPE_ATM_VIRTUAL = 149;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MPLS_TUNNEL"]/*' />
    [NativeTypeName("#define IF_TYPE_MPLS_TUNNEL 150")]
    public const int IF_TYPE_MPLS_TUNNEL = 150;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SRP"]/*' />
    [NativeTypeName("#define IF_TYPE_SRP 151")]
    public const int IF_TYPE_SRP = 151;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VOICEOVERATM"]/*' />
    [NativeTypeName("#define IF_TYPE_VOICEOVERATM 152")]
    public const int IF_TYPE_VOICEOVERATM = 152;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_VOICEOVERFRAMERELAY"]/*' />
    [NativeTypeName("#define IF_TYPE_VOICEOVERFRAMERELAY 153")]
    public const int IF_TYPE_VOICEOVERFRAMERELAY = 153;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IDSL"]/*' />
    [NativeTypeName("#define IF_TYPE_IDSL 154")]
    public const int IF_TYPE_IDSL = 154;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_COMPOSITELINK"]/*' />
    [NativeTypeName("#define IF_TYPE_COMPOSITELINK 155")]
    public const int IF_TYPE_COMPOSITELINK = 155;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SS7_SIGLINK"]/*' />
    [NativeTypeName("#define IF_TYPE_SS7_SIGLINK 156")]
    public const int IF_TYPE_SS7_SIGLINK = 156;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_WIRELESS_P2P"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_WIRELESS_P2P 157")]
    public const int IF_TYPE_PROP_WIRELESS_P2P = 157;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FR_FORWARD"]/*' />
    [NativeTypeName("#define IF_TYPE_FR_FORWARD 158")]
    public const int IF_TYPE_FR_FORWARD = 158;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_RFC1483"]/*' />
    [NativeTypeName("#define IF_TYPE_RFC1483 159")]
    public const int IF_TYPE_RFC1483 = 159;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_USB"]/*' />
    [NativeTypeName("#define IF_TYPE_USB 160")]
    public const int IF_TYPE_USB = 160;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IEEE8023AD_LAG"]/*' />
    [NativeTypeName("#define IF_TYPE_IEEE8023AD_LAG 161")]
    public const int IF_TYPE_IEEE8023AD_LAG = 161;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_BGP_POLICY_ACCOUNTING"]/*' />
    [NativeTypeName("#define IF_TYPE_BGP_POLICY_ACCOUNTING 162")]
    public const int IF_TYPE_BGP_POLICY_ACCOUNTING = 162;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FRF16_MFR_BUNDLE"]/*' />
    [NativeTypeName("#define IF_TYPE_FRF16_MFR_BUNDLE 163")]
    public const int IF_TYPE_FRF16_MFR_BUNDLE = 163;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_H323_GATEKEEPER"]/*' />
    [NativeTypeName("#define IF_TYPE_H323_GATEKEEPER 164")]
    public const int IF_TYPE_H323_GATEKEEPER = 164;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_H323_PROXY"]/*' />
    [NativeTypeName("#define IF_TYPE_H323_PROXY 165")]
    public const int IF_TYPE_H323_PROXY = 165;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MPLS"]/*' />
    [NativeTypeName("#define IF_TYPE_MPLS 166")]
    public const int IF_TYPE_MPLS = 166;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MF_SIGLINK"]/*' />
    [NativeTypeName("#define IF_TYPE_MF_SIGLINK 167")]
    public const int IF_TYPE_MF_SIGLINK = 167;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HDSL2"]/*' />
    [NativeTypeName("#define IF_TYPE_HDSL2 168")]
    public const int IF_TYPE_HDSL2 = 168;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SHDSL"]/*' />
    [NativeTypeName("#define IF_TYPE_SHDSL 169")]
    public const int IF_TYPE_SHDSL = 169;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DS1_FDL"]/*' />
    [NativeTypeName("#define IF_TYPE_DS1_FDL 170")]
    public const int IF_TYPE_DS1_FDL = 170;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_POS"]/*' />
    [NativeTypeName("#define IF_TYPE_POS 171")]
    public const int IF_TYPE_POS = 171;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DVB_ASI_IN"]/*' />
    [NativeTypeName("#define IF_TYPE_DVB_ASI_IN 172")]
    public const int IF_TYPE_DVB_ASI_IN = 172;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DVB_ASI_OUT"]/*' />
    [NativeTypeName("#define IF_TYPE_DVB_ASI_OUT 173")]
    public const int IF_TYPE_DVB_ASI_OUT = 173;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PLC"]/*' />
    [NativeTypeName("#define IF_TYPE_PLC 174")]
    public const int IF_TYPE_PLC = 174;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_NFAS"]/*' />
    [NativeTypeName("#define IF_TYPE_NFAS 175")]
    public const int IF_TYPE_NFAS = 175;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_TR008"]/*' />
    [NativeTypeName("#define IF_TYPE_TR008 176")]
    public const int IF_TYPE_TR008 = 176;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_GR303_RDT"]/*' />
    [NativeTypeName("#define IF_TYPE_GR303_RDT 177")]
    public const int IF_TYPE_GR303_RDT = 177;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_GR303_IDT"]/*' />
    [NativeTypeName("#define IF_TYPE_GR303_IDT 178")]
    public const int IF_TYPE_GR303_IDT = 178;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ISUP"]/*' />
    [NativeTypeName("#define IF_TYPE_ISUP 179")]
    public const int IF_TYPE_ISUP = 179;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_DOCS_WIRELESS_MACLAYER"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_MACLAYER 180")]
    public const int IF_TYPE_PROP_DOCS_WIRELESS_MACLAYER = 180;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_DOCS_WIRELESS_DOWNSTREAM"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_DOWNSTREAM 181")]
    public const int IF_TYPE_PROP_DOCS_WIRELESS_DOWNSTREAM = 181;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_DOCS_WIRELESS_UPSTREAM"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_UPSTREAM 182")]
    public const int IF_TYPE_PROP_DOCS_WIRELESS_UPSTREAM = 182;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_HIPERLAN2"]/*' />
    [NativeTypeName("#define IF_TYPE_HIPERLAN2 183")]
    public const int IF_TYPE_HIPERLAN2 = 183;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_PROP_BWA_P2MP"]/*' />
    [NativeTypeName("#define IF_TYPE_PROP_BWA_P2MP 184")]
    public const int IF_TYPE_PROP_BWA_P2MP = 184;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_SONET_OVERHEAD_CHANNEL"]/*' />
    [NativeTypeName("#define IF_TYPE_SONET_OVERHEAD_CHANNEL 185")]
    public const int IF_TYPE_SONET_OVERHEAD_CHANNEL = 185;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_DIGITAL_WRAPPER_OVERHEAD_CHANNEL"]/*' />
    [NativeTypeName("#define IF_TYPE_DIGITAL_WRAPPER_OVERHEAD_CHANNEL 186")]
    public const int IF_TYPE_DIGITAL_WRAPPER_OVERHEAD_CHANNEL = 186;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_AAL2"]/*' />
    [NativeTypeName("#define IF_TYPE_AAL2 187")]
    public const int IF_TYPE_AAL2 = 187;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_RADIO_MAC"]/*' />
    [NativeTypeName("#define IF_TYPE_RADIO_MAC 188")]
    public const int IF_TYPE_RADIO_MAC = 188;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM_RADIO"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM_RADIO 189")]
    public const int IF_TYPE_ATM_RADIO = 189;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IMT"]/*' />
    [NativeTypeName("#define IF_TYPE_IMT 190")]
    public const int IF_TYPE_IMT = 190;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_MVL"]/*' />
    [NativeTypeName("#define IF_TYPE_MVL 191")]
    public const int IF_TYPE_MVL = 191;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_REACH_DSL"]/*' />
    [NativeTypeName("#define IF_TYPE_REACH_DSL 192")]
    public const int IF_TYPE_REACH_DSL = 192;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_FR_DLCI_ENDPT"]/*' />
    [NativeTypeName("#define IF_TYPE_FR_DLCI_ENDPT 193")]
    public const int IF_TYPE_FR_DLCI_ENDPT = 193;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_ATM_VCI_ENDPT"]/*' />
    [NativeTypeName("#define IF_TYPE_ATM_VCI_ENDPT 194")]
    public const int IF_TYPE_ATM_VCI_ENDPT = 194;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_OPTICAL_CHANNEL"]/*' />
    [NativeTypeName("#define IF_TYPE_OPTICAL_CHANNEL 195")]
    public const int IF_TYPE_OPTICAL_CHANNEL = 195;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_OPTICAL_TRANSPORT"]/*' />
    [NativeTypeName("#define IF_TYPE_OPTICAL_TRANSPORT 196")]
    public const int IF_TYPE_OPTICAL_TRANSPORT = 196;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IEEE80216_WMAN"]/*' />
    [NativeTypeName("#define IF_TYPE_IEEE80216_WMAN 237")]
    public const int IF_TYPE_IEEE80216_WMAN = 237;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_WWANPP"]/*' />
    [NativeTypeName("#define IF_TYPE_WWANPP 243")]
    public const int IF_TYPE_WWANPP = 243;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_WWANPP2"]/*' />
    [NativeTypeName("#define IF_TYPE_WWANPP2 244")]
    public const int IF_TYPE_WWANPP2 = 244;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_IEEE802154"]/*' />
    [NativeTypeName("#define IF_TYPE_IEEE802154 259")]
    public const int IF_TYPE_IEEE802154 = 259;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_TYPE_XBOX_WIRELESS"]/*' />
    [NativeTypeName("#define IF_TYPE_XBOX_WIRELESS 281")]
    public const int IF_TYPE_XBOX_WIRELESS = 281;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_CHECK_NONE"]/*' />
    [NativeTypeName("#define IF_CHECK_NONE 0x00")]
    public const int IF_CHECK_NONE = 0x00;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_CHECK_MCAST"]/*' />
    [NativeTypeName("#define IF_CHECK_MCAST 0x01")]
    public const int IF_CHECK_MCAST = 0x01;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_CHECK_SEND"]/*' />
    [NativeTypeName("#define IF_CHECK_SEND 0x02")]
    public const int IF_CHECK_SEND = 0x02;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_CONNECTION_DEDICATED"]/*' />
    [NativeTypeName("#define IF_CONNECTION_DEDICATED 1")]
    public const int IF_CONNECTION_DEDICATED = 1;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_CONNECTION_PASSIVE"]/*' />
    [NativeTypeName("#define IF_CONNECTION_PASSIVE 2")]
    public const int IF_CONNECTION_PASSIVE = 2;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_CONNECTION_DEMAND"]/*' />
    [NativeTypeName("#define IF_CONNECTION_DEMAND 3")]
    public const int IF_CONNECTION_DEMAND = 3;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_ADMIN_STATUS_UP"]/*' />
    [NativeTypeName("#define IF_ADMIN_STATUS_UP 1")]
    public const int IF_ADMIN_STATUS_UP = 1;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_ADMIN_STATUS_DOWN"]/*' />
    [NativeTypeName("#define IF_ADMIN_STATUS_DOWN 2")]
    public const int IF_ADMIN_STATUS_DOWN = 2;

    /// <include file='IF.xml' path='doc/member[@name="IF.IF_ADMIN_STATUS_TESTING"]/*' />
    [NativeTypeName("#define IF_ADMIN_STATUS_TESTING 3")]
    public const int IF_ADMIN_STATUS_TESTING = 3;
}
