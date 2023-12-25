// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BackgroundUploadProgress.xml' path='doc/member[@name="BackgroundUploadProgress"]/*' />
public partial struct BackgroundUploadProgress
{
    /// <include file='BackgroundUploadProgress.xml' path='doc/member[@name="BackgroundUploadProgress.BytesReceived"]/*' />
    [NativeTypeName("UINT64")]
    public ulong BytesReceived;

    /// <include file='BackgroundUploadProgress.xml' path='doc/member[@name="BackgroundUploadProgress.BytesSent"]/*' />
    [NativeTypeName("UINT64")]
    public ulong BytesSent;

    /// <include file='BackgroundUploadProgress.xml' path='doc/member[@name="BackgroundUploadProgress.TotalBytesToReceive"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TotalBytesToReceive;

    /// <include file='BackgroundUploadProgress.xml' path='doc/member[@name="BackgroundUploadProgress.TotalBytesToSend"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TotalBytesToSend;

    /// <include file='BackgroundUploadProgress.xml' path='doc/member[@name="BackgroundUploadProgress.Status"]/*' />
    [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferStatus")]
    public BackgroundTransferStatus Status;

    /// <include file='BackgroundUploadProgress.xml' path='doc/member[@name="BackgroundUploadProgress.HasResponseChanged"]/*' />
    [NativeTypeName("boolean")]
    public byte HasResponseChanged;

    /// <include file='BackgroundUploadProgress.xml' path='doc/member[@name="BackgroundUploadProgress.HasRestarted"]/*' />
    [NativeTypeName("boolean")]
    public byte HasRestarted;
}
