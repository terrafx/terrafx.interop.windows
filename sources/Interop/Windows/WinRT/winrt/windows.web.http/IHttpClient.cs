// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient"]/*' />
[Guid("7FDA1151-3574-4880-A8BA-E6B1E0061F3D")]
[NativeTypeName("struct IHttpClient : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpClient : IHttpClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpClient));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, Guid*, void**, int>)(lpVtbl[0]))((IHttpClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, uint>)(lpVtbl[1]))((IHttpClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, uint>)(lpVtbl[2]))((IHttpClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpClient*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, HSTRING*, int>)(lpVtbl[4]))((IHttpClient*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, TrustLevel*, int>)(lpVtbl[5]))((IHttpClient*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int>)(lpVtbl[6]))((IHttpClient*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.GetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int>)(lpVtbl[7]))((IHttpClient*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.GetWithOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWithOptionAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")] HttpCompletionOption completionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IUriRuntimeClass*, HttpCompletionOption, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int>)(lpVtbl[8]))((IHttpClient*)Unsafe.AsPointer(ref this), uri, completionOption, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.GetBufferAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBufferAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IBuffer>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IBuffer>, HttpProgress>**, int>)(lpVtbl[9]))((IHttpClient*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.GetInputStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInputStreamAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IInputStream>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IInputStream>, HttpProgress>**, int>)(lpVtbl[10]))((IHttpClient*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.GetStringAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStringAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<HSTRING, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IUriRuntimeClass*, IAsyncOperationWithProgress<HSTRING, HttpProgress>**, int>)(lpVtbl[11]))((IHttpClient*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.PostAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PostAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IUriRuntimeClass*, IHttpContent*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int>)(lpVtbl[12]))((IHttpClient*)Unsafe.AsPointer(ref this), uri, content, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.PutAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PutAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IUriRuntimeClass*, IHttpContent*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int>)(lpVtbl[13]))((IHttpClient*)Unsafe.AsPointer(ref this), uri, content, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.SendRequestAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SendRequestAsync([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IHttpRequestMessage*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int>)(lpVtbl[14]))((IHttpClient*)Unsafe.AsPointer(ref this), request, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.SendRequestWithOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SendRequestWithOptionAsync([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* request, [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")] HttpCompletionOption completionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IHttpRequestMessage*, HttpCompletionOption, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int>)(lpVtbl[15]))((IHttpClient*)Unsafe.AsPointer(ref this), request, completionOption, operation);
    }

    /// <include file='IHttpClient.xml' path='doc/member[@name="IHttpClient.get_DefaultRequestHeaders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DefaultRequestHeaders([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **")] IHttpRequestHeaderCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpClient*, IHttpRequestHeaderCollection**, int>)(lpVtbl[16]))((IHttpClient*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation);

        [VtblIndex(7)]
        HRESULT GetAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation);

        [VtblIndex(8)]
        HRESULT GetWithOptionAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")] HttpCompletionOption completionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation);

        [VtblIndex(9)]
        HRESULT GetBufferAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IBuffer>, HttpProgress>** operation);

        [VtblIndex(10)]
        HRESULT GetInputStreamAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IInputStream>, HttpProgress>** operation);

        [VtblIndex(11)]
        HRESULT GetStringAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<HSTRING, HttpProgress>** operation);

        [VtblIndex(12)]
        HRESULT PostAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation);

        [VtblIndex(13)]
        HRESULT PutAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation);

        [VtblIndex(14)]
        HRESULT SendRequestAsync([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation);

        [VtblIndex(15)]
        HRESULT SendRequestWithOptionAsync([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* request, [NativeTypeName("ABI::Windows::Web::Http::HttpCompletionOption")] HttpCompletionOption completionOption, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **")] IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>** operation);

        [VtblIndex(16)]
        HRESULT get_DefaultRequestHeaders([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **")] IHttpRequestHeaderCollection** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int> GetAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::HttpCompletionOption, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, HttpCompletionOption, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int> GetWithOptionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IBuffer>, HttpProgress>**, int> GetBufferAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<Pointer<IInputStream>, HttpProgress>**, int> GetInputStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperationWithProgress<HSTRING, HttpProgress>**, int> GetStringAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::IHttpContent *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IHttpContent*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int> PostAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Web::Http::IHttpContent *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IHttpContent*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int> PutAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestMessage*, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int> SendRequestAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage *, ABI::Windows::Web::Http::HttpCompletionOption, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CWeb__CHttp__CHttpResponseMessage_Windows__CWeb__CHttp__CHttpProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestMessage*, HttpCompletionOption, IAsyncOperationWithProgress<Pointer<IHttpResponseMessage>, HttpProgress>**, int> SendRequestWithOptionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestHeaderCollection**, int> get_DefaultRequestHeaders;
    }
}
