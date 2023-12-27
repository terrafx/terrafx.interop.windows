// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebSocketServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IWebSocketServerCustomValidationRequestedEventArgs"]/*' />
[Guid("FFEFFE48-022A-4AB7-8B36-E10AF4640E6B")]
[NativeTypeName("struct IWebSocketServerCustomValidationRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebSocketServerCustomValidationRequestedEventArgs : IWebSocketServerCustomValidationRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebSocketServerCustomValidationRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, uint>)(lpVtbl[1]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, uint>)(lpVtbl[2]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebSocketServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IWebSocketServerCustomValidationRequestedEventArgs.get_ServerCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ServerCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, ICertificate**, int>)(lpVtbl[6]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IWebSocketServerCustomValidationRequestedEventArgs.get_ServerCertificateErrorSeverity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServerCertificateErrorSeverity([NativeTypeName("ABI::Windows::Networking::Sockets::SocketSslErrorSeverity *")] SocketSslErrorSeverity* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, SocketSslErrorSeverity*, int>)(lpVtbl[7]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IWebSocketServerCustomValidationRequestedEventArgs.get_ServerCertificateErrors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ServerCertificateErrors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **")] IVectorView<ChainValidationResult>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, IVectorView<ChainValidationResult>**, int>)(lpVtbl[8]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IWebSocketServerCustomValidationRequestedEventArgs.get_ServerIntermediateCertificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ServerIntermediateCertificates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVectorView<Pointer<ICertificate>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, IVectorView<Pointer<ICertificate>>**, int>)(lpVtbl[9]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IWebSocketServerCustomValidationRequestedEventArgs.Reject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Reject()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, int>)(lpVtbl[10]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWebSocketServerCustomValidationRequestedEventArgs.xml' path='doc/member[@name="IWebSocketServerCustomValidationRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketServerCustomValidationRequestedEventArgs*, IDeferral**, int>)(lpVtbl[11]))((IWebSocketServerCustomValidationRequestedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ServerCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value);

        [VtblIndex(7)]
        HRESULT get_ServerCertificateErrorSeverity([NativeTypeName("ABI::Windows::Networking::Sockets::SocketSslErrorSeverity *")] SocketSslErrorSeverity* value);

        [VtblIndex(8)]
        HRESULT get_ServerCertificateErrors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CChainValidationResult_t **")] IVectorView<ChainValidationResult>** value);

        [VtblIndex(9)]
        HRESULT get_ServerIntermediateCertificates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVectorView<Pointer<ICertificate>>** value);

        [VtblIndex(10)]
        HRESULT Reject();

        [VtblIndex(11)]
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
