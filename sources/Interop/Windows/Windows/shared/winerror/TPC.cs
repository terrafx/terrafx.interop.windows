// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TPC
{
    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_INVALID_PROPERTY"]/*' />
    [NativeTypeName("#define TPC_E_INVALID_PROPERTY _HRESULT_TYPEDEF_(0x80040241L)")]
    public const int TPC_E_INVALID_PROPERTY = unchecked((int)(0x80040241));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_NO_DEFAULT_TABLET"]/*' />
    [NativeTypeName("#define TPC_E_NO_DEFAULT_TABLET _HRESULT_TYPEDEF_(0x80040212L)")]
    public const int TPC_E_NO_DEFAULT_TABLET = unchecked((int)(0x80040212));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_UNKNOWN_PROPERTY"]/*' />
    [NativeTypeName("#define TPC_E_UNKNOWN_PROPERTY _HRESULT_TYPEDEF_(0x8004021BL)")]
    public const int TPC_E_UNKNOWN_PROPERTY = unchecked((int)(0x8004021B));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_INVALID_INPUT_RECT"]/*' />
    [NativeTypeName("#define TPC_E_INVALID_INPUT_RECT _HRESULT_TYPEDEF_(0x80040219L)")]
    public const int TPC_E_INVALID_INPUT_RECT = unchecked((int)(0x80040219));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_INVALID_STROKE"]/*' />
    [NativeTypeName("#define TPC_E_INVALID_STROKE _HRESULT_TYPEDEF_(0x80040222L)")]
    public const int TPC_E_INVALID_STROKE = unchecked((int)(0x80040222));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_INITIALIZE_FAIL"]/*' />
    [NativeTypeName("#define TPC_E_INITIALIZE_FAIL _HRESULT_TYPEDEF_(0x80040223L)")]
    public const int TPC_E_INITIALIZE_FAIL = unchecked((int)(0x80040223));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_NOT_RELEVANT"]/*' />
    [NativeTypeName("#define TPC_E_NOT_RELEVANT _HRESULT_TYPEDEF_(0x80040232L)")]
    public const int TPC_E_NOT_RELEVANT = unchecked((int)(0x80040232));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_INVALID_PACKET_DESCRIPTION"]/*' />
    [NativeTypeName("#define TPC_E_INVALID_PACKET_DESCRIPTION _HRESULT_TYPEDEF_(0x80040233L)")]
    public const int TPC_E_INVALID_PACKET_DESCRIPTION = unchecked((int)(0x80040233));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_RECOGNIZER_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define TPC_E_RECOGNIZER_NOT_REGISTERED _HRESULT_TYPEDEF_(0x80040235L)")]
    public const int TPC_E_RECOGNIZER_NOT_REGISTERED = unchecked((int)(0x80040235));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_INVALID_RIGHTS"]/*' />
    [NativeTypeName("#define TPC_E_INVALID_RIGHTS _HRESULT_TYPEDEF_(0x80040236L)")]
    public const int TPC_E_INVALID_RIGHTS = unchecked((int)(0x80040236));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_OUT_OF_ORDER_CALL"]/*' />
    [NativeTypeName("#define TPC_E_OUT_OF_ORDER_CALL _HRESULT_TYPEDEF_(0x80040237L)")]
    public const int TPC_E_OUT_OF_ORDER_CALL = unchecked((int)(0x80040237));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_QUEUE_FULL"]/*' />
    [NativeTypeName("#define TPC_E_QUEUE_FULL _HRESULT_TYPEDEF_(0x80040238L)")]
    public const int TPC_E_QUEUE_FULL = unchecked((int)(0x80040238));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_INVALID_CONFIGURATION"]/*' />
    [NativeTypeName("#define TPC_E_INVALID_CONFIGURATION _HRESULT_TYPEDEF_(0x80040239L)")]
    public const int TPC_E_INVALID_CONFIGURATION = unchecked((int)(0x80040239));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_E_INVALID_DATA_FROM_RECOGNIZER"]/*' />
    [NativeTypeName("#define TPC_E_INVALID_DATA_FROM_RECOGNIZER _HRESULT_TYPEDEF_(0x8004023AL)")]
    public const int TPC_E_INVALID_DATA_FROM_RECOGNIZER = unchecked((int)(0x8004023A));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_S_TRUNCATED"]/*' />
    [NativeTypeName("#define TPC_S_TRUNCATED _HRESULT_TYPEDEF_(0x00040252L)")]
    public const int TPC_S_TRUNCATED = ((int)(0x00040252));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_S_INTERRUPTED"]/*' />
    [NativeTypeName("#define TPC_S_INTERRUPTED _HRESULT_TYPEDEF_(0x00040253L)")]
    public const int TPC_S_INTERRUPTED = ((int)(0x00040253));

    /// <include file='TPC.xml' path='doc/member[@name="TPC.TPC_S_NO_DATA_TO_PROCESS"]/*' />
    [NativeTypeName("#define TPC_S_NO_DATA_TO_PROCESS _HRESULT_TYPEDEF_(0x00040254L)")]
    public const int TPC_S_NO_DATA_TO_PROCESS = ((int)(0x00040254));
}
