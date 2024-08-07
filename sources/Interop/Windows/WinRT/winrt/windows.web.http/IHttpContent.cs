// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpContent.xml' path='doc/member[@name="IHttpContent"]/*' />
[Guid("6B14A441-FBA7-4BD2-AF0A-839DE7C295DA")]
[NativeTypeName("struct IHttpContent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContent : IHttpContent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpContent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, Guid*, void**, int>)(lpVtbl[0]))((IHttpContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, uint>)(lpVtbl[1]))((IHttpContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, uint>)(lpVtbl[2]))((IHttpContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpContent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, HSTRING*, int>)(lpVtbl[4]))((IHttpContent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, TrustLevel*, int>)(lpVtbl[5]))((IHttpContent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpContent.xml' path='doc/member[@name="IHttpContent.get_Headers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Headers([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentHeaderCollection **")] IHttpContentHeaderCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, IHttpContentHeaderCollection**, int>)(lpVtbl[6]))((IHttpContent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContent.xml' path='doc/member[@name="IHttpContent.BufferAllAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BufferAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, IAsyncOperationWithProgress<ulong, ulong>**, int>)(lpVtbl[7]))((IHttpContent*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IHttpContent.xml' path='doc/member[@name="IHttpContent.ReadAsBufferAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReadAsBufferAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT64_t **")] IAsyncOperationWithProgress<Pointer<IBuffer>, ulong>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, IAsyncOperationWithProgress<Pointer<IBuffer>, ulong>**, int>)(lpVtbl[8]))((IHttpContent*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IHttpContent.xml' path='doc/member[@name="IHttpContent.ReadAsInputStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReadAsInputStreamAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_UINT64_t **")] IAsyncOperationWithProgress<Pointer<IInputStream>, ulong>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, IAsyncOperationWithProgress<Pointer<IInputStream>, ulong>**, int>)(lpVtbl[9]))((IHttpContent*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IHttpContent.xml' path='doc/member[@name="IHttpContent.ReadAsStringAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReadAsStringAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_UINT64_t **")] IAsyncOperationWithProgress<HSTRING, ulong>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, IAsyncOperationWithProgress<HSTRING, ulong>**, int>)(lpVtbl[10]))((IHttpContent*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IHttpContent.xml' path='doc/member[@name="IHttpContent.TryComputeLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TryComputeLength([NativeTypeName("UINT64 *")] ulong* length, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, ulong*, byte*, int>)(lpVtbl[11]))((IHttpContent*)Unsafe.AsPointer(ref this), length, succeeded);
    }

    /// <include file='IHttpContent.xml' path='doc/member[@name="IHttpContent.WriteToStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteToStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* outputStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContent*, IOutputStream*, IAsyncOperationWithProgress<ulong, ulong>**, int>)(lpVtbl[12]))((IHttpContent*)Unsafe.AsPointer(ref this), outputStream, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Headers([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentHeaderCollection **")] IHttpContentHeaderCollection** value);

        [VtblIndex(7)]
        HRESULT BufferAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation);

        [VtblIndex(8)]
        HRESULT ReadAsBufferAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT64_t **")] IAsyncOperationWithProgress<Pointer<IBuffer>, ulong>** operation);

        [VtblIndex(9)]
        HRESULT ReadAsInputStreamAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_UINT64_t **")] IAsyncOperationWithProgress<Pointer<IInputStream>, ulong>** operation);

        [VtblIndex(10)]
        HRESULT ReadAsStringAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_UINT64_t **")] IAsyncOperationWithProgress<HSTRING, ulong>** operation);

        [VtblIndex(11)]
        HRESULT TryComputeLength([NativeTypeName("UINT64 *")] ulong* length, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(12)]
        HRESULT WriteToStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* outputStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentHeaderCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContentHeaderCollection**, int> get_Headers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperationWithProgress<ulong, ulong>**, int> BufferAllAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperationWithProgress<Pointer<IBuffer>, ulong>**, int> ReadAsBufferAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperationWithProgress<Pointer<IInputStream>, ulong>**, int> ReadAsInputStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperationWithProgress<HSTRING, ulong>**, int> ReadAsStringAsync;

        [NativeTypeName("HRESULT (UINT64 *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, byte*, int> TryComputeLength;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutputStream*, IAsyncOperationWithProgress<ulong, ulong>**, int> WriteToStreamAsync;
    }
}
