// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class UCEERR
{
    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_INVALIDPACKETHEADER"]/*' />
    [NativeTypeName("#define UCEERR_INVALIDPACKETHEADER _HRESULT_TYPEDEF_(0x88980400L)")]
    public const int UCEERR_INVALIDPACKETHEADER = unchecked((int)(0x88980400));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_UNKNOWNPACKET"]/*' />
    [NativeTypeName("#define UCEERR_UNKNOWNPACKET _HRESULT_TYPEDEF_(0x88980401L)")]
    public const int UCEERR_UNKNOWNPACKET = unchecked((int)(0x88980401));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_ILLEGALPACKET"]/*' />
    [NativeTypeName("#define UCEERR_ILLEGALPACKET _HRESULT_TYPEDEF_(0x88980402L)")]
    public const int UCEERR_ILLEGALPACKET = unchecked((int)(0x88980402));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_MALFORMEDPACKET"]/*' />
    [NativeTypeName("#define UCEERR_MALFORMEDPACKET _HRESULT_TYPEDEF_(0x88980403L)")]
    public const int UCEERR_MALFORMEDPACKET = unchecked((int)(0x88980403));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_ILLEGALHANDLE"]/*' />
    [NativeTypeName("#define UCEERR_ILLEGALHANDLE _HRESULT_TYPEDEF_(0x88980404L)")]
    public const int UCEERR_ILLEGALHANDLE = unchecked((int)(0x88980404));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_HANDLELOOKUPFAILED"]/*' />
    [NativeTypeName("#define UCEERR_HANDLELOOKUPFAILED _HRESULT_TYPEDEF_(0x88980405L)")]
    public const int UCEERR_HANDLELOOKUPFAILED = unchecked((int)(0x88980405));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_RENDERTHREADFAILURE"]/*' />
    [NativeTypeName("#define UCEERR_RENDERTHREADFAILURE _HRESULT_TYPEDEF_(0x88980406L)")]
    public const int UCEERR_RENDERTHREADFAILURE = unchecked((int)(0x88980406));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_CTXSTACKFRSTTARGETNULL"]/*' />
    [NativeTypeName("#define UCEERR_CTXSTACKFRSTTARGETNULL _HRESULT_TYPEDEF_(0x88980407L)")]
    public const int UCEERR_CTXSTACKFRSTTARGETNULL = unchecked((int)(0x88980407));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_CONNECTIONIDLOOKUPFAILED"]/*' />
    [NativeTypeName("#define UCEERR_CONNECTIONIDLOOKUPFAILED _HRESULT_TYPEDEF_(0x88980408L)")]
    public const int UCEERR_CONNECTIONIDLOOKUPFAILED = unchecked((int)(0x88980408));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_BLOCKSFULL"]/*' />
    [NativeTypeName("#define UCEERR_BLOCKSFULL _HRESULT_TYPEDEF_(0x88980409L)")]
    public const int UCEERR_BLOCKSFULL = unchecked((int)(0x88980409));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_MEMORYFAILURE"]/*' />
    [NativeTypeName("#define UCEERR_MEMORYFAILURE _HRESULT_TYPEDEF_(0x8898040AL)")]
    public const int UCEERR_MEMORYFAILURE = unchecked((int)(0x8898040A));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_PACKETRECORDOUTOFRANGE"]/*' />
    [NativeTypeName("#define UCEERR_PACKETRECORDOUTOFRANGE _HRESULT_TYPEDEF_(0x8898040BL)")]
    public const int UCEERR_PACKETRECORDOUTOFRANGE = unchecked((int)(0x8898040B));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_ILLEGALRECORDTYPE"]/*' />
    [NativeTypeName("#define UCEERR_ILLEGALRECORDTYPE _HRESULT_TYPEDEF_(0x8898040CL)")]
    public const int UCEERR_ILLEGALRECORDTYPE = unchecked((int)(0x8898040C));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_OUTOFHANDLES"]/*' />
    [NativeTypeName("#define UCEERR_OUTOFHANDLES _HRESULT_TYPEDEF_(0x8898040DL)")]
    public const int UCEERR_OUTOFHANDLES = unchecked((int)(0x8898040D));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED"]/*' />
    [NativeTypeName("#define UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED _HRESULT_TYPEDEF_(0x8898040EL)")]
    public const int UCEERR_UNCHANGABLE_UPDATE_ATTEMPTED = unchecked((int)(0x8898040E));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_NO_MULTIPLE_WORKER_THREADS"]/*' />
    [NativeTypeName("#define UCEERR_NO_MULTIPLE_WORKER_THREADS _HRESULT_TYPEDEF_(0x8898040FL)")]
    public const int UCEERR_NO_MULTIPLE_WORKER_THREADS = unchecked((int)(0x8898040F));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_REMOTINGNOTSUPPORTED"]/*' />
    [NativeTypeName("#define UCEERR_REMOTINGNOTSUPPORTED _HRESULT_TYPEDEF_(0x88980410L)")]
    public const int UCEERR_REMOTINGNOTSUPPORTED = unchecked((int)(0x88980410));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_MISSINGENDCOMMAND"]/*' />
    [NativeTypeName("#define UCEERR_MISSINGENDCOMMAND _HRESULT_TYPEDEF_(0x88980411L)")]
    public const int UCEERR_MISSINGENDCOMMAND = unchecked((int)(0x88980411));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_MISSINGBEGINCOMMAND"]/*' />
    [NativeTypeName("#define UCEERR_MISSINGBEGINCOMMAND _HRESULT_TYPEDEF_(0x88980412L)")]
    public const int UCEERR_MISSINGBEGINCOMMAND = unchecked((int)(0x88980412));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_CHANNELSYNCTIMEDOUT"]/*' />
    [NativeTypeName("#define UCEERR_CHANNELSYNCTIMEDOUT _HRESULT_TYPEDEF_(0x88980413L)")]
    public const int UCEERR_CHANNELSYNCTIMEDOUT = unchecked((int)(0x88980413));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_CHANNELSYNCABANDONED"]/*' />
    [NativeTypeName("#define UCEERR_CHANNELSYNCABANDONED _HRESULT_TYPEDEF_(0x88980414L)")]
    public const int UCEERR_CHANNELSYNCABANDONED = unchecked((int)(0x88980414));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_UNSUPPORTEDTRANSPORTVERSION"]/*' />
    [NativeTypeName("#define UCEERR_UNSUPPORTEDTRANSPORTVERSION _HRESULT_TYPEDEF_(0x88980415L)")]
    public const int UCEERR_UNSUPPORTEDTRANSPORTVERSION = unchecked((int)(0x88980415));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_TRANSPORTUNAVAILABLE"]/*' />
    [NativeTypeName("#define UCEERR_TRANSPORTUNAVAILABLE _HRESULT_TYPEDEF_(0x88980416L)")]
    public const int UCEERR_TRANSPORTUNAVAILABLE = unchecked((int)(0x88980416));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_FEEDBACK_UNSUPPORTED"]/*' />
    [NativeTypeName("#define UCEERR_FEEDBACK_UNSUPPORTED _HRESULT_TYPEDEF_(0x88980417L)")]
    public const int UCEERR_FEEDBACK_UNSUPPORTED = unchecked((int)(0x88980417));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_COMMANDTRANSPORTDENIED"]/*' />
    [NativeTypeName("#define UCEERR_COMMANDTRANSPORTDENIED _HRESULT_TYPEDEF_(0x88980418L)")]
    public const int UCEERR_COMMANDTRANSPORTDENIED = unchecked((int)(0x88980418));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_GRAPHICSSTREAMUNAVAILABLE"]/*' />
    [NativeTypeName("#define UCEERR_GRAPHICSSTREAMUNAVAILABLE _HRESULT_TYPEDEF_(0x88980419L)")]
    public const int UCEERR_GRAPHICSSTREAMUNAVAILABLE = unchecked((int)(0x88980419));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_GRAPHICSSTREAMALREADYOPEN"]/*' />
    [NativeTypeName("#define UCEERR_GRAPHICSSTREAMALREADYOPEN _HRESULT_TYPEDEF_(0x88980420L)")]
    public const int UCEERR_GRAPHICSSTREAMALREADYOPEN = unchecked((int)(0x88980420));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_TRANSPORTDISCONNECTED"]/*' />
    [NativeTypeName("#define UCEERR_TRANSPORTDISCONNECTED _HRESULT_TYPEDEF_(0x88980421L)")]
    public const int UCEERR_TRANSPORTDISCONNECTED = unchecked((int)(0x88980421));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_TRANSPORTOVERLOADED"]/*' />
    [NativeTypeName("#define UCEERR_TRANSPORTOVERLOADED _HRESULT_TYPEDEF_(0x88980422L)")]
    public const int UCEERR_TRANSPORTOVERLOADED = unchecked((int)(0x88980422));

    /// <include file='UCEERR.xml' path='doc/member[@name="UCEERR.UCEERR_PARTITION_ZOMBIED"]/*' />
    [NativeTypeName("#define UCEERR_PARTITION_ZOMBIED _HRESULT_TYPEDEF_(0x88980423L)")]
    public const int UCEERR_PARTITION_ZOMBIED = unchecked((int)(0x88980423));
}
