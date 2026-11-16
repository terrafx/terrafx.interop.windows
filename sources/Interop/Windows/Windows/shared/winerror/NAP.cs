// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NAP
{
    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_INVALID_PACKET"]/*' />
    [NativeTypeName("#define NAP_E_INVALID_PACKET _HRESULT_TYPEDEF_(0x80270001L)")]
    public const int NAP_E_INVALID_PACKET = unchecked((int)(0x80270001));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_MISSING_SOH"]/*' />
    [NativeTypeName("#define NAP_E_MISSING_SOH _HRESULT_TYPEDEF_(0x80270002L)")]
    public const int NAP_E_MISSING_SOH = unchecked((int)(0x80270002));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_CONFLICTING_ID"]/*' />
    [NativeTypeName("#define NAP_E_CONFLICTING_ID _HRESULT_TYPEDEF_(0x80270003L)")]
    public const int NAP_E_CONFLICTING_ID = unchecked((int)(0x80270003));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_NO_CACHED_SOH"]/*' />
    [NativeTypeName("#define NAP_E_NO_CACHED_SOH _HRESULT_TYPEDEF_(0x80270004L)")]
    public const int NAP_E_NO_CACHED_SOH = unchecked((int)(0x80270004));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_STILL_BOUND"]/*' />
    [NativeTypeName("#define NAP_E_STILL_BOUND _HRESULT_TYPEDEF_(0x80270005L)")]
    public const int NAP_E_STILL_BOUND = unchecked((int)(0x80270005));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define NAP_E_NOT_REGISTERED _HRESULT_TYPEDEF_(0x80270006L)")]
    public const int NAP_E_NOT_REGISTERED = unchecked((int)(0x80270006));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_NOT_INITIALIZED"]/*' />
    [NativeTypeName("#define NAP_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x80270007L)")]
    public const int NAP_E_NOT_INITIALIZED = unchecked((int)(0x80270007));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_MISMATCHED_ID"]/*' />
    [NativeTypeName("#define NAP_E_MISMATCHED_ID _HRESULT_TYPEDEF_(0x80270008L)")]
    public const int NAP_E_MISMATCHED_ID = unchecked((int)(0x80270008));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_NOT_PENDING"]/*' />
    [NativeTypeName("#define NAP_E_NOT_PENDING _HRESULT_TYPEDEF_(0x80270009L)")]
    public const int NAP_E_NOT_PENDING = unchecked((int)(0x80270009));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_ID_NOT_FOUND"]/*' />
    [NativeTypeName("#define NAP_E_ID_NOT_FOUND _HRESULT_TYPEDEF_(0x8027000AL)")]
    public const int NAP_E_ID_NOT_FOUND = unchecked((int)(0x8027000A));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_MAXSIZE_TOO_SMALL"]/*' />
    [NativeTypeName("#define NAP_E_MAXSIZE_TOO_SMALL _HRESULT_TYPEDEF_(0x8027000BL)")]
    public const int NAP_E_MAXSIZE_TOO_SMALL = unchecked((int)(0x8027000B));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_SERVICE_NOT_RUNNING"]/*' />
    [NativeTypeName("#define NAP_E_SERVICE_NOT_RUNNING _HRESULT_TYPEDEF_(0x8027000CL)")]
    public const int NAP_E_SERVICE_NOT_RUNNING = unchecked((int)(0x8027000C));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_S_CERT_ALREADY_PRESENT"]/*' />
    [NativeTypeName("#define NAP_S_CERT_ALREADY_PRESENT _HRESULT_TYPEDEF_(0x0027000DL)")]
    public const int NAP_S_CERT_ALREADY_PRESENT = ((int)(0x0027000D));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_ENTITY_DISABLED"]/*' />
    [NativeTypeName("#define NAP_E_ENTITY_DISABLED _HRESULT_TYPEDEF_(0x8027000EL)")]
    public const int NAP_E_ENTITY_DISABLED = unchecked((int)(0x8027000E));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_NETSH_GROUPPOLICY_ERROR"]/*' />
    [NativeTypeName("#define NAP_E_NETSH_GROUPPOLICY_ERROR _HRESULT_TYPEDEF_(0x8027000FL)")]
    public const int NAP_E_NETSH_GROUPPOLICY_ERROR = unchecked((int)(0x8027000F));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_TOO_MANY_CALLS"]/*' />
    [NativeTypeName("#define NAP_E_TOO_MANY_CALLS _HRESULT_TYPEDEF_(0x80270010L)")]
    public const int NAP_E_TOO_MANY_CALLS = unchecked((int)(0x80270010));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_SHV_CONFIG_EXISTED"]/*' />
    [NativeTypeName("#define NAP_E_SHV_CONFIG_EXISTED _HRESULT_TYPEDEF_(0x80270011L)")]
    public const int NAP_E_SHV_CONFIG_EXISTED = unchecked((int)(0x80270011));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_SHV_CONFIG_NOT_FOUND"]/*' />
    [NativeTypeName("#define NAP_E_SHV_CONFIG_NOT_FOUND _HRESULT_TYPEDEF_(0x80270012L)")]
    public const int NAP_E_SHV_CONFIG_NOT_FOUND = unchecked((int)(0x80270012));

    /// <include file='NAP.xml' path='doc/member[@name="NAP.NAP_E_SHV_TIMEOUT"]/*' />
    [NativeTypeName("#define NAP_E_SHV_TIMEOUT _HRESULT_TYPEDEF_(0x80270013L)")]
    public const int NAP_E_SHV_TIMEOUT = unchecked((int)(0x80270013));
}
