// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2"]/*' />
[Guid("CDD83348-E8B7-4CEC-B1B0-DC455FE72C92")]
[NativeTypeName("struct IHttpClient2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpClient2 : IHttpClient2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpClient2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, Guid*, void**, int>)(lpVtbl[0]))((IHttpClient2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, uint>)(lpVtbl[1]))((IHttpClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, uint>)(lpVtbl[2]))((IHttpClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpClient2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, HSTRING*, int>)(lpVtbl[4]))((IHttpClient2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, TrustLevel*, int>)(lpVtbl[5]))((IHttpClient2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TryDeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryDeleteAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int>)(lpVtbl[6]))((IHttpClient2*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TryGetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryGetAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int>)(lpVtbl[7]))((IHttpClient2*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TryGetAsync2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryGetAsync2([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")] HttpCompletionOption completionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IUriRuntimeClass*, HttpCompletionOption, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int>)(lpVtbl[8]))((IHttpClient2*)Unsafe.AsPointer(ref this), uri, completionOption, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TryGetBufferAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryGetBufferAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetBufferResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpGetBufferResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpGetBufferResult>, HttpProgress>**, int>)(lpVtbl[9]))((IHttpClient2*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TryGetInputStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryGetInputStreamAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetInputStreamResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpGetInputStreamResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpGetInputStreamResult>, HttpProgress>**, int>)(lpVtbl[10]))((IHttpClient2*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TryGetStringAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TryGetStringAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetStringResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpGetStringResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpGetStringResult>, HttpProgress>**, int>)(lpVtbl[11]))((IHttpClient2*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TryPostAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TryPostAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IUriRuntimeClass*, IHttpContent*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int>)(lpVtbl[12]))((IHttpClient2*)Unsafe.AsPointer(ref this), uri, content, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TryPutAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT TryPutAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IUriRuntimeClass*, IHttpContent*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int>)(lpVtbl[13]))((IHttpClient2*)Unsafe.AsPointer(ref this), uri, content, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TrySendRequestAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT TrySendRequestAsync([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IHttpRequestMessage*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int>)(lpVtbl[14]))((IHttpClient2*)Unsafe.AsPointer(ref this), request, operation);
    }

    /// <include file='IHttpClient2.xml' path='doc/member[@name="IHttpClient2.TrySendRequestAsync2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TrySendRequestAsync2([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* request, [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")] HttpCompletionOption completionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient2*, IHttpRequestMessage*, HttpCompletionOption, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int>)(lpVtbl[15]))((IHttpClient2*)Unsafe.AsPointer(ref this), request, completionOption, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryDeleteAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation);

        [VtblIndex(7)]
        HRESULT TryGetAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation);

        [VtblIndex(8)]
        HRESULT TryGetAsync2([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")] HttpCompletionOption completionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation);

        [VtblIndex(9)]
        HRESULT TryGetBufferAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetBufferResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpGetBufferResult>, HttpProgress>** operation);

        [VtblIndex(10)]
        HRESULT TryGetInputStreamAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetInputStreamResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpGetInputStreamResult>, HttpProgress>** operation);

        [VtblIndex(11)]
        HRESULT TryGetStringAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetStringResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpGetStringResult>, HttpProgress>** operation);

        [VtblIndex(12)]
        HRESULT TryPostAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation);

        [VtblIndex(13)]
        HRESULT TryPutAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation);

        [VtblIndex(14)]
        HRESULT TrySendRequestAsync([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation);

        [VtblIndex(15)]
        HRESULT TrySendRequestAsync2([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* request, [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")] HttpCompletionOption completionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int> TryDeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int> TryGetAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::HttpCompletionOption, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, HttpCompletionOption, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int> TryGetAsync2;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetBufferResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpGetBufferResult>, HttpProgress>**, int> TryGetBufferAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetInputStreamResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpGetInputStreamResult>, HttpProgress>**, int> TryGetInputStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpGetStringResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpGetStringResult>, HttpProgress>**, int> TryGetStringAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::IHttpContent *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IHttpContent*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int> TryPostAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::IHttpContent *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IHttpContent*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int> TryPutAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestMessage*, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int> TrySendRequestAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage *, ABI::Windows::Web::Http::HttpCompletionOption, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpRequestResult_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestMessage*, HttpCompletionOption, IAsyncOperationWithProgress<Pointer<IHttpRequestResult>, HttpProgress>**, int> TrySendRequestAsync2;
    }
}
