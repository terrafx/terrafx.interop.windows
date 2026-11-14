// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WSA
{
    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_E_NO_MORE"]/*' />
    [NativeTypeName("#define WSA_E_NO_MORE 10110L")]
    public const int WSA_E_NO_MORE = 10110;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_E_CANCELLED"]/*' />
    [NativeTypeName("#define WSA_E_CANCELLED 10111L")]
    public const int WSA_E_CANCELLED = 10111;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_RECEIVERS"]/*' />
    [NativeTypeName("#define WSA_QOS_RECEIVERS 11005L")]
    public const int WSA_QOS_RECEIVERS = 11005;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_SENDERS"]/*' />
    [NativeTypeName("#define WSA_QOS_SENDERS 11006L")]
    public const int WSA_QOS_SENDERS = 11006;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_NO_SENDERS"]/*' />
    [NativeTypeName("#define WSA_QOS_NO_SENDERS 11007L")]
    public const int WSA_QOS_NO_SENDERS = 11007;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_NO_RECEIVERS"]/*' />
    [NativeTypeName("#define WSA_QOS_NO_RECEIVERS 11008L")]
    public const int WSA_QOS_NO_RECEIVERS = 11008;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_REQUEST_CONFIRMED"]/*' />
    [NativeTypeName("#define WSA_QOS_REQUEST_CONFIRMED 11009L")]
    public const int WSA_QOS_REQUEST_CONFIRMED = 11009;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_ADMISSION_FAILURE"]/*' />
    [NativeTypeName("#define WSA_QOS_ADMISSION_FAILURE 11010L")]
    public const int WSA_QOS_ADMISSION_FAILURE = 11010;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_POLICY_FAILURE"]/*' />
    [NativeTypeName("#define WSA_QOS_POLICY_FAILURE 11011L")]
    public const int WSA_QOS_POLICY_FAILURE = 11011;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_BAD_STYLE"]/*' />
    [NativeTypeName("#define WSA_QOS_BAD_STYLE 11012L")]
    public const int WSA_QOS_BAD_STYLE = 11012;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_BAD_OBJECT"]/*' />
    [NativeTypeName("#define WSA_QOS_BAD_OBJECT 11013L")]
    public const int WSA_QOS_BAD_OBJECT = 11013;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_TRAFFIC_CTRL_ERROR"]/*' />
    [NativeTypeName("#define WSA_QOS_TRAFFIC_CTRL_ERROR 11014L")]
    public const int WSA_QOS_TRAFFIC_CTRL_ERROR = 11014;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_GENERIC_ERROR"]/*' />
    [NativeTypeName("#define WSA_QOS_GENERIC_ERROR 11015L")]
    public const int WSA_QOS_GENERIC_ERROR = 11015;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_ESERVICETYPE"]/*' />
    [NativeTypeName("#define WSA_QOS_ESERVICETYPE 11016L")]
    public const int WSA_QOS_ESERVICETYPE = 11016;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EFLOWSPEC"]/*' />
    [NativeTypeName("#define WSA_QOS_EFLOWSPEC 11017L")]
    public const int WSA_QOS_EFLOWSPEC = 11017;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EPROVSPECBUF"]/*' />
    [NativeTypeName("#define WSA_QOS_EPROVSPECBUF 11018L")]
    public const int WSA_QOS_EPROVSPECBUF = 11018;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EFILTERSTYLE"]/*' />
    [NativeTypeName("#define WSA_QOS_EFILTERSTYLE 11019L")]
    public const int WSA_QOS_EFILTERSTYLE = 11019;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EFILTERTYPE"]/*' />
    [NativeTypeName("#define WSA_QOS_EFILTERTYPE 11020L")]
    public const int WSA_QOS_EFILTERTYPE = 11020;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EFILTERCOUNT"]/*' />
    [NativeTypeName("#define WSA_QOS_EFILTERCOUNT 11021L")]
    public const int WSA_QOS_EFILTERCOUNT = 11021;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EOBJLENGTH"]/*' />
    [NativeTypeName("#define WSA_QOS_EOBJLENGTH 11022L")]
    public const int WSA_QOS_EOBJLENGTH = 11022;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EFLOWCOUNT"]/*' />
    [NativeTypeName("#define WSA_QOS_EFLOWCOUNT 11023L")]
    public const int WSA_QOS_EFLOWCOUNT = 11023;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EUNKOWNPSOBJ"]/*' />
    [NativeTypeName("#define WSA_QOS_EUNKOWNPSOBJ 11024L")]
    public const int WSA_QOS_EUNKOWNPSOBJ = 11024;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EPOLICYOBJ"]/*' />
    [NativeTypeName("#define WSA_QOS_EPOLICYOBJ 11025L")]
    public const int WSA_QOS_EPOLICYOBJ = 11025;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EFLOWDESC"]/*' />
    [NativeTypeName("#define WSA_QOS_EFLOWDESC 11026L")]
    public const int WSA_QOS_EFLOWDESC = 11026;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EPSFLOWSPEC"]/*' />
    [NativeTypeName("#define WSA_QOS_EPSFLOWSPEC 11027L")]
    public const int WSA_QOS_EPSFLOWSPEC = 11027;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_EPSFILTERSPEC"]/*' />
    [NativeTypeName("#define WSA_QOS_EPSFILTERSPEC 11028L")]
    public const int WSA_QOS_EPSFILTERSPEC = 11028;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_ESDMODEOBJ"]/*' />
    [NativeTypeName("#define WSA_QOS_ESDMODEOBJ 11029L")]
    public const int WSA_QOS_ESDMODEOBJ = 11029;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_ESHAPERATEOBJ"]/*' />
    [NativeTypeName("#define WSA_QOS_ESHAPERATEOBJ 11030L")]
    public const int WSA_QOS_ESHAPERATEOBJ = 11030;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_QOS_RESERVED_PETYPE"]/*' />
    [NativeTypeName("#define WSA_QOS_RESERVED_PETYPE 11031L")]
    public const int WSA_QOS_RESERVED_PETYPE = 11031;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_SECURE_HOST_NOT_FOUND"]/*' />
    [NativeTypeName("#define WSA_SECURE_HOST_NOT_FOUND 11032L")]
    public const int WSA_SECURE_HOST_NOT_FOUND = 11032;

    /// <include file='WSA.xml' path='doc/member[@name="WSA.WSA_IPSEC_NAME_POLICY_ERROR"]/*' />
    [NativeTypeName("#define WSA_IPSEC_NAME_POLICY_ERROR 11033L")]
    public const int WSA_IPSEC_NAME_POLICY_ERROR = 11033;
}
