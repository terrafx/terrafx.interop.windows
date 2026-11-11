// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IPPORT
{
    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_TCPMUX"]/*' />
    [NativeTypeName("#define IPPORT_TCPMUX 1")]
    public const int IPPORT_TCPMUX = 1;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_ECHO"]/*' />
    [NativeTypeName("#define IPPORT_ECHO 7")]
    public const int IPPORT_ECHO = 7;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_DISCARD"]/*' />
    [NativeTypeName("#define IPPORT_DISCARD 9")]
    public const int IPPORT_DISCARD = 9;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_SYSTAT"]/*' />
    [NativeTypeName("#define IPPORT_SYSTAT 11")]
    public const int IPPORT_SYSTAT = 11;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_DAYTIME"]/*' />
    [NativeTypeName("#define IPPORT_DAYTIME 13")]
    public const int IPPORT_DAYTIME = 13;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_NETSTAT"]/*' />
    [NativeTypeName("#define IPPORT_NETSTAT 15")]
    public const int IPPORT_NETSTAT = 15;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_QOTD"]/*' />
    [NativeTypeName("#define IPPORT_QOTD 17")]
    public const int IPPORT_QOTD = 17;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_MSP"]/*' />
    [NativeTypeName("#define IPPORT_MSP 18")]
    public const int IPPORT_MSP = 18;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_CHARGEN"]/*' />
    [NativeTypeName("#define IPPORT_CHARGEN 19")]
    public const int IPPORT_CHARGEN = 19;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_FTP_DATA"]/*' />
    [NativeTypeName("#define IPPORT_FTP_DATA 20")]
    public const int IPPORT_FTP_DATA = 20;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_FTP"]/*' />
    [NativeTypeName("#define IPPORT_FTP 21")]
    public const int IPPORT_FTP = 21;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_TELNET"]/*' />
    [NativeTypeName("#define IPPORT_TELNET 23")]
    public const int IPPORT_TELNET = 23;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_SMTP"]/*' />
    [NativeTypeName("#define IPPORT_SMTP 25")]
    public const int IPPORT_SMTP = 25;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_TIMESERVER"]/*' />
    [NativeTypeName("#define IPPORT_TIMESERVER 37")]
    public const int IPPORT_TIMESERVER = 37;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_NAMESERVER"]/*' />
    [NativeTypeName("#define IPPORT_NAMESERVER 42")]
    public const int IPPORT_NAMESERVER = 42;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_WHOIS"]/*' />
    [NativeTypeName("#define IPPORT_WHOIS 43")]
    public const int IPPORT_WHOIS = 43;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_MTP"]/*' />
    [NativeTypeName("#define IPPORT_MTP 57")]
    public const int IPPORT_MTP = 57;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_TFTP"]/*' />
    [NativeTypeName("#define IPPORT_TFTP 69")]
    public const int IPPORT_TFTP = 69;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_RJE"]/*' />
    [NativeTypeName("#define IPPORT_RJE 77")]
    public const int IPPORT_RJE = 77;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_FINGER"]/*' />
    [NativeTypeName("#define IPPORT_FINGER 79")]
    public const int IPPORT_FINGER = 79;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_TTYLINK"]/*' />
    [NativeTypeName("#define IPPORT_TTYLINK 87")]
    public const int IPPORT_TTYLINK = 87;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_SUPDUP"]/*' />
    [NativeTypeName("#define IPPORT_SUPDUP 95")]
    public const int IPPORT_SUPDUP = 95;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_POP3"]/*' />
    [NativeTypeName("#define IPPORT_POP3 110")]
    public const int IPPORT_POP3 = 110;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_NTP"]/*' />
    [NativeTypeName("#define IPPORT_NTP 123")]
    public const int IPPORT_NTP = 123;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_EPMAP"]/*' />
    [NativeTypeName("#define IPPORT_EPMAP 135")]
    public const int IPPORT_EPMAP = 135;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_NETBIOS_NS"]/*' />
    [NativeTypeName("#define IPPORT_NETBIOS_NS 137")]
    public const int IPPORT_NETBIOS_NS = 137;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_NETBIOS_DGM"]/*' />
    [NativeTypeName("#define IPPORT_NETBIOS_DGM 138")]
    public const int IPPORT_NETBIOS_DGM = 138;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_NETBIOS_SSN"]/*' />
    [NativeTypeName("#define IPPORT_NETBIOS_SSN 139")]
    public const int IPPORT_NETBIOS_SSN = 139;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_IMAP"]/*' />
    [NativeTypeName("#define IPPORT_IMAP 143")]
    public const int IPPORT_IMAP = 143;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_SNMP"]/*' />
    [NativeTypeName("#define IPPORT_SNMP 161")]
    public const int IPPORT_SNMP = 161;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_SNMP_TRAP"]/*' />
    [NativeTypeName("#define IPPORT_SNMP_TRAP 162")]
    public const int IPPORT_SNMP_TRAP = 162;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_IMAP3"]/*' />
    [NativeTypeName("#define IPPORT_IMAP3 220")]
    public const int IPPORT_IMAP3 = 220;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_LDAP"]/*' />
    [NativeTypeName("#define IPPORT_LDAP 389")]
    public const int IPPORT_LDAP = 389;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_HTTPS"]/*' />
    [NativeTypeName("#define IPPORT_HTTPS 443")]
    public const int IPPORT_HTTPS = 443;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_MICROSOFT_DS"]/*' />
    [NativeTypeName("#define IPPORT_MICROSOFT_DS 445")]
    public const int IPPORT_MICROSOFT_DS = 445;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_EXECSERVER"]/*' />
    [NativeTypeName("#define IPPORT_EXECSERVER 512")]
    public const int IPPORT_EXECSERVER = 512;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_LOGINSERVER"]/*' />
    [NativeTypeName("#define IPPORT_LOGINSERVER 513")]
    public const int IPPORT_LOGINSERVER = 513;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_CMDSERVER"]/*' />
    [NativeTypeName("#define IPPORT_CMDSERVER 514")]
    public const int IPPORT_CMDSERVER = 514;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_EFSSERVER"]/*' />
    [NativeTypeName("#define IPPORT_EFSSERVER 520")]
    public const int IPPORT_EFSSERVER = 520;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_BIFFUDP"]/*' />
    [NativeTypeName("#define IPPORT_BIFFUDP 512")]
    public const int IPPORT_BIFFUDP = 512;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_WHOSERVER"]/*' />
    [NativeTypeName("#define IPPORT_WHOSERVER 513")]
    public const int IPPORT_WHOSERVER = 513;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_ROUTESERVER"]/*' />
    [NativeTypeName("#define IPPORT_ROUTESERVER 520")]
    public const int IPPORT_ROUTESERVER = 520;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_RESERVED"]/*' />
    [NativeTypeName("#define IPPORT_RESERVED 1024")]
    public const int IPPORT_RESERVED = 1024;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_REGISTERED_MIN"]/*' />
    [NativeTypeName("#define IPPORT_REGISTERED_MIN IPPORT_RESERVED")]
    public const int IPPORT_REGISTERED_MIN = 1024;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_REGISTERED_MAX"]/*' />
    [NativeTypeName("#define IPPORT_REGISTERED_MAX 0xbfff")]
    public const int IPPORT_REGISTERED_MAX = 0xbfff;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_DYNAMIC_MIN"]/*' />
    [NativeTypeName("#define IPPORT_DYNAMIC_MIN 0xc000")]
    public const int IPPORT_DYNAMIC_MIN = 0xc000;

    /// <include file='IPPORT.xml' path='doc/member[@name="IPPORT.IPPORT_DYNAMIC_MAX"]/*' />
    [NativeTypeName("#define IPPORT_DYNAMIC_MAX 0xffff")]
    public const int IPPORT_DYNAMIC_MAX = 0xffff;
}
