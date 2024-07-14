// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundDownloadProgress.xml' path='doc/member[@name="BackgroundDownloadProgress"]/*' />
public partial struct BackgroundDownloadProgress
{
    /// <include file='BackgroundDownloadProgress.xml' path='doc/member[@name="BackgroundDownloadProgress.BytesReceived"]/*' />
    [NativeTypeName("UINT64")]
    public ulong BytesReceived;

    /// <include file='BackgroundDownloadProgress.xml' path='doc/member[@name="BackgroundDownloadProgress.TotalBytesToReceive"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TotalBytesToReceive;

    /// <include file='BackgroundDownloadProgress.xml' path='doc/member[@name="BackgroundDownloadProgress.Status"]/*' />
    [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferStatus")]
    public BackgroundTransferStatus Status;

    /// <include file='BackgroundDownloadProgress.xml' path='doc/member[@name="BackgroundDownloadProgress.HasResponseChanged"]/*' />
    [NativeTypeName("boolean")]
    public byte HasResponseChanged;

    /// <include file='BackgroundDownloadProgress.xml' path='doc/member[@name="BackgroundDownloadProgress.HasRestarted"]/*' />
    [NativeTypeName("boolean")]
    public byte HasRestarted;
}
