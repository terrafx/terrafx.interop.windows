// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSourceStatics.xml' path='doc/member[@name="IAdaptiveMediaSourceStatics"]/*' />
[Guid("50A6BD5D-66EF-4CD3-9579-9E660507DC3F")]
[NativeTypeName("struct IAdaptiveMediaSourceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceStatics : IAdaptiveMediaSourceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, uint>)(lpVtbl[1]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, uint>)(lpVtbl[2]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSourceStatics.xml' path='doc/member[@name="IAdaptiveMediaSourceStatics.IsContentTypeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsContentTypeSupported(HSTRING contentType, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, HSTRING, byte*, int>)(lpVtbl[6]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), contentType, result);
    }

    /// <include file='IAdaptiveMediaSourceStatics.xml' path='doc/member[@name="IAdaptiveMediaSourceStatics.CreateFromUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromUriAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **")] IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, IUriRuntimeClass*, IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>**, int>)(lpVtbl[7]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), uri, result);
    }

    /// <include file='IAdaptiveMediaSourceStatics.xml' path='doc/member[@name="IAdaptiveMediaSourceStatics.CreateFromUriWithDownloaderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromUriWithDownloaderAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpClient *")] IHttpClient* httpClient, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **")] IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, IUriRuntimeClass*, IHttpClient*, IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>**, int>)(lpVtbl[8]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), uri, httpClient, result);
    }

    /// <include file='IAdaptiveMediaSourceStatics.xml' path='doc/member[@name="IAdaptiveMediaSourceStatics.CreateFromStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, HSTRING contentType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **")] IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, IInputStream*, IUriRuntimeClass*, HSTRING, IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>**, int>)(lpVtbl[9]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), stream, uri, contentType, result);
    }

    /// <include file='IAdaptiveMediaSourceStatics.xml' path='doc/member[@name="IAdaptiveMediaSourceStatics.CreateFromStreamWithDownloaderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFromStreamWithDownloaderAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, HSTRING contentType, [NativeTypeName("ABI::Windows::Web::Http::IHttpClient *")] IHttpClient* httpClient, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **")] IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceStatics*, IInputStream*, IUriRuntimeClass*, HSTRING, IHttpClient*, IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>**, int>)(lpVtbl[10]))((IAdaptiveMediaSourceStatics*)Unsafe.AsPointer(ref this), stream, uri, contentType, httpClient, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsContentTypeSupported(HSTRING contentType, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT CreateFromUriAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **")] IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>** result);

        [VtblIndex(8)]
        HRESULT CreateFromUriWithDownloaderAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpClient *")] IHttpClient* httpClient, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **")] IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>** result);

        [VtblIndex(9)]
        HRESULT CreateFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, HSTRING contentType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **")] IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>** result);

        [VtblIndex(10)]
        HRESULT CreateFromStreamWithDownloaderAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, HSTRING contentType, [NativeTypeName("ABI::Windows::Web::Http::IHttpClient *")] IHttpClient* httpClient, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **")] IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>** result);
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

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsContentTypeSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>**, int> CreateFromUriAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::IHttpClient *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IHttpClient*, IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>**, int> CreateFromUriWithDownloaderAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IUriRuntimeClass*, HSTRING, IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>**, int> CreateFromStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Web::Http::IHttpClient *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceCreationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IUriRuntimeClass*, HSTRING, IHttpClient*, IAsyncOperation<Pointer<IAdaptiveMediaSourceCreationResult>>**, int> CreateFromStreamWithDownloaderAsync;
    }
}
