// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDatagramSocketControl.xml' path='doc/member[@name="IDatagramSocketControl"]/*' />
[Guid("52AC3F2E-349A-4135-BB58-B79B2647D390")]
[NativeTypeName("struct IDatagramSocketControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocketControl : IDatagramSocketControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocketControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, Guid*, void**, int>)(lpVtbl[0]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, uint>)(lpVtbl[1]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, uint>)(lpVtbl[2]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, uint*, Guid**, int>)(lpVtbl[3]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, HSTRING*, int>)(lpVtbl[4]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, TrustLevel*, int>)(lpVtbl[5]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDatagramSocketControl.xml' path='doc/member[@name="IDatagramSocketControl.get_QualityOfService"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_QualityOfService([NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService *")] SocketQualityOfService* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, SocketQualityOfService*, int>)(lpVtbl[6]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketControl.xml' path='doc/member[@name="IDatagramSocketControl.put_QualityOfService"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_QualityOfService([NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService")] SocketQualityOfService value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, SocketQualityOfService, int>)(lpVtbl[7]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketControl.xml' path='doc/member[@name="IDatagramSocketControl.get_OutboundUnicastHopLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutboundUnicastHopLimit(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, byte*, int>)(lpVtbl[8]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocketControl.xml' path='doc/member[@name="IDatagramSocketControl.put_OutboundUnicastHopLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_OutboundUnicastHopLimit(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocketControl*, byte, int>)(lpVtbl[9]))((IDatagramSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_QualityOfService([NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService *")] SocketQualityOfService* value);

        [VtblIndex(7)]
        HRESULT put_QualityOfService([NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService")] SocketQualityOfService value);

        [VtblIndex(8)]
        HRESULT get_OutboundUnicastHopLimit(byte* value);

        [VtblIndex(9)]
        HRESULT put_OutboundUnicastHopLimit(byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketQualityOfService *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketQualityOfService*, int> get_QualityOfService;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketQualityOfService) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketQualityOfService, int> put_QualityOfService;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_OutboundUnicastHopLimit;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_OutboundUnicastHopLimit;
    }
}
