// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundTransferFileRange.xml' path='doc/member[@name="BackgroundTransferFileRange"]/*' />
public partial struct BackgroundTransferFileRange
{
    /// <include file='BackgroundTransferFileRange.xml' path='doc/member[@name="BackgroundTransferFileRange.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='BackgroundTransferFileRange.xml' path='doc/member[@name="BackgroundTransferFileRange.Length"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Length;
}
