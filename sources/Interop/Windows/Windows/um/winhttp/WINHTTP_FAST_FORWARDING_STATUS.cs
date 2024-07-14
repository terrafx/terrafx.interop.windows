// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_FAST_FORWARDING_STATUS.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATUS"]/*' />
public partial struct WINHTTP_FAST_FORWARDING_STATUS
{
    /// <include file='WINHTTP_FAST_FORWARDING_STATUS.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATUS.TransferState"]/*' />
    public WINHTTP_FAST_FORWARDING_STATE TransferState;

    /// <include file='WINHTTP_FAST_FORWARDING_STATUS.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATUS.NtStatus"]/*' />
    [NativeTypeName("LONG")]
    public int NtStatus;

    /// <include file='WINHTTP_FAST_FORWARDING_STATUS.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATUS.dwError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwError;

    /// <include file='WINHTTP_FAST_FORWARDING_STATUS.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATUS.ullBytesTransferred"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullBytesTransferred;
}
