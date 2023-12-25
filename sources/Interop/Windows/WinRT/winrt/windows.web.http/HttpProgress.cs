// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpProgress.xml' path='doc/member[@name="HttpProgress"]/*' />
public unsafe partial struct HttpProgress
{
    /// <include file='HttpProgress.xml' path='doc/member[@name="HttpProgress.Stage"]/*' />
    [NativeTypeName("ABI::Windows::Web::Http::HttpProgressStage")]
    public HttpProgressStage Stage;

    /// <include file='HttpProgress.xml' path='doc/member[@name="HttpProgress.BytesSent"]/*' />
    [NativeTypeName("UINT64")]
    public ulong BytesSent;

    /// <include file='HttpProgress.xml' path='doc/member[@name="HttpProgress.TotalBytesToSend"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
    public IReference<ulong>* TotalBytesToSend;

    /// <include file='HttpProgress.xml' path='doc/member[@name="HttpProgress.BytesReceived"]/*' />
    [NativeTypeName("UINT64")]
    public ulong BytesReceived;

    /// <include file='HttpProgress.xml' path='doc/member[@name="HttpProgress.TotalBytesToReceive"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
    public IReference<ulong>* TotalBytesToReceive;

    /// <include file='HttpProgress.xml' path='doc/member[@name="HttpProgress.Retries"]/*' />
    [NativeTypeName("UINT32")]
    public uint Retries;
}
