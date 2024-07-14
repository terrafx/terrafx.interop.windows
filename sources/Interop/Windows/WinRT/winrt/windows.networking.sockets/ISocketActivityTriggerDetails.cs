// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISocketActivityTriggerDetails.xml' path='doc/member[@name="ISocketActivityTriggerDetails"]/*' />
[Guid("45F406A7-FC9F-4F81-ACAD-355FEF51E67B")]
[NativeTypeName("struct ISocketActivityTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISocketActivityTriggerDetails : ISocketActivityTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISocketActivityTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISocketActivityTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((ISocketActivityTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISocketActivityTriggerDetails*, uint>)(lpVtbl[1]))((ISocketActivityTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISocketActivityTriggerDetails*, uint>)(lpVtbl[2]))((ISocketActivityTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISocketActivityTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((ISocketActivityTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISocketActivityTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((ISocketActivityTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISocketActivityTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((ISocketActivityTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISocketActivityTriggerDetails.xml' path='doc/member[@name="ISocketActivityTriggerDetails.get_Reason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Reason([NativeTypeName("ABI::Windows::Networking::Sockets::SocketActivityTriggerReason *")] SocketActivityTriggerReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISocketActivityTriggerDetails*, SocketActivityTriggerReason*, int>)(lpVtbl[6]))((ISocketActivityTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISocketActivityTriggerDetails.xml' path='doc/member[@name="ISocketActivityTriggerDetails.get_SocketInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SocketInformation([NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityInformation **")] ISocketActivityInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISocketActivityTriggerDetails*, ISocketActivityInformation**, int>)(lpVtbl[7]))((ISocketActivityTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Reason([NativeTypeName("ABI::Windows::Networking::Sockets::SocketActivityTriggerReason *")] SocketActivityTriggerReason* value);

        [VtblIndex(7)]
        HRESULT get_SocketInformation([NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityInformation **")] ISocketActivityInformation** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketActivityTriggerReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketActivityTriggerReason*, int> get_Reason;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::ISocketActivityInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISocketActivityInformation**, int> get_SocketInformation;
    }
}
