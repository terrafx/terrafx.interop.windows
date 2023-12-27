// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IHttpServerCustomValidationRequestedEventArgs"]/*' />
[Guid("3165FE32-E7DD-48B7-A361-939C750E63CC")]
[NativeTypeName("struct IHttpServerCustomValidationRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpServerCustomValidationRequestedEventArgs : IHttpServerCustomValidationRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpServerCustomValidationRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, uint>)(lpVtbl[1]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, uint>)(lpVtbl[2]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IHttpServerCustomValidationRequestedEventArgs.get_RequestMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")] IHttpRequestMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, IHttpRequestMessage**, int>)(lpVtbl[6]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IHttpServerCustomValidationRequestedEventArgs.get_ServerCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServerCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, ICertificate**, int>)(lpVtbl[7]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IHttpServerCustomValidationRequestedEventArgs.get_ServerCertificateErrorSeverity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ServerCertificateErrorSeverity([NativeTypeName("ABI::Windows::Networking::Sockets::SocketSslErrorSeverity *")] SocketSslErrorSeverity* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, SocketSslErrorSeverity*, int>)(lpVtbl[8]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IHttpServerCustomValidationRequestedEventArgs.get_ServerCertificateErrors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ServerCertificateErrors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **")] IVectorView<ChainValidationResult>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, IVectorView<ChainValidationResult>**, int>)(lpVtbl[9]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IHttpServerCustomValidationRequestedEventArgs.get_ServerIntermediateCertificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ServerIntermediateCertificates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVectorView<Pointer<ICertificate>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, IVectorView<Pointer<ICertificate>>**, int>)(lpVtbl[10]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IHttpServerCustomValidationRequestedEventArgs.Reject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Reject()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, int>)(lpVtbl[11]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IHttpServerCustomValidationRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServerCustomValidationRequestedEventArgs*, IDeferral**, int>)(lpVtbl[12]))((IHttpServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")] IHttpRequestMessage** value);

        [VtblIndex(7)]
        HRESULT get_ServerCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value);

        [VtblIndex(8)]
        HRESULT get_ServerCertificateErrorSeverity([NativeTypeName("ABI::Windows::Networking::Sockets::SocketSslErrorSeverity *")] SocketSslErrorSeverity* value);

        [VtblIndex(9)]
        HRESULT get_ServerCertificateErrors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **")] IVectorView<ChainValidationResult>** value);

        [VtblIndex(10)]
        HRESULT get_ServerIntermediateCertificates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVectorView<Pointer<ICertificate>>** value);

        [VtblIndex(11)]
        HRESULT Reject();

        [VtblIndex(12)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestMessage**, int> get_RequestMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate**, int> get_ServerCertificate;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketSslErrorSeverity *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketSslErrorSeverity*, int> get_ServerCertificateErrorSeverity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<ChainValidationResult>**, int> get_ServerCertificateErrors;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ICertificate>>**, int> get_ServerIntermediateCertificates;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reject;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
