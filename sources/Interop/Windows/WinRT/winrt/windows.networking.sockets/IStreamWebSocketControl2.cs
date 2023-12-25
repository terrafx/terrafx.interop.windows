// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamWebSocketControl2.xml' path='doc/member[@name="IStreamWebSocketControl2"]/*' />
[Guid("215D9F7E-FA58-40DA-9F11-A48DAFE95037")]
[NativeTypeName("struct IStreamWebSocketControl2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamWebSocketControl2 : IStreamWebSocketControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamWebSocketControl2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, Guid*, void**, int>)(lpVtbl[0]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, uint>)(lpVtbl[1]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, uint>)(lpVtbl[2]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, HSTRING*, int>)(lpVtbl[4]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, TrustLevel*, int>)(lpVtbl[5]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamWebSocketControl2.xml' path='doc/member[@name="IStreamWebSocketControl2.get_DesiredUnsolicitedPongInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesiredUnsolicitedPongInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, TimeSpan*, int>)(lpVtbl[6]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamWebSocketControl2.xml' path='doc/member[@name="IStreamWebSocketControl2.put_DesiredUnsolicitedPongInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredUnsolicitedPongInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, TimeSpan, int>)(lpVtbl[7]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamWebSocketControl2.xml' path='doc/member[@name="IStreamWebSocketControl2.get_ActualUnsolicitedPongInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ActualUnsolicitedPongInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, TimeSpan*, int>)(lpVtbl[8]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamWebSocketControl2.xml' path='doc/member[@name="IStreamWebSocketControl2.get_ClientCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ClientCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, ICertificate**, int>)(lpVtbl[9]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamWebSocketControl2.xml' path='doc/member[@name="IStreamWebSocketControl2.put_ClientCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ClientCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocketControl2*, ICertificate*, int>)(lpVtbl[10]))((IStreamWebSocketControl2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesiredUnsolicitedPongInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT put_DesiredUnsolicitedPongInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(8)]
        HRESULT get_ActualUnsolicitedPongInterval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT get_ClientCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value);

        [VtblIndex(10)]
        HRESULT put_ClientCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_DesiredUnsolicitedPongInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_DesiredUnsolicitedPongInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_ActualUnsolicitedPongInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate**, int> get_ClientCertificate;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate*, int> put_ClientCertificate;
    }
}
