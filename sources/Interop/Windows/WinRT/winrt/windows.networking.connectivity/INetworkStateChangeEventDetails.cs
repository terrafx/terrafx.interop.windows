// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INetworkStateChangeEventDetails.xml' path='doc/member[@name="INetworkStateChangeEventDetails"]/*' />
[Guid("1F0CF333-D7A6-44DD-A4E9-687C476B903D")]
[NativeTypeName("struct INetworkStateChangeEventDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct INetworkStateChangeEventDetails : INetworkStateChangeEventDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INetworkStateChangeEventDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, Guid*, void**, int>)(lpVtbl[0]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, uint>)(lpVtbl[1]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, uint>)(lpVtbl[2]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, uint*, Guid**, int>)(lpVtbl[3]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, HSTRING*, int>)(lpVtbl[4]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, TrustLevel*, int>)(lpVtbl[5]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='INetworkStateChangeEventDetails.xml' path='doc/member[@name="INetworkStateChangeEventDetails.get_HasNewInternetConnectionProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HasNewInternetConnectionProfile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, byte*, int>)(lpVtbl[6]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkStateChangeEventDetails.xml' path='doc/member[@name="INetworkStateChangeEventDetails.get_HasNewConnectionCost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HasNewConnectionCost([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, byte*, int>)(lpVtbl[7]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkStateChangeEventDetails.xml' path='doc/member[@name="INetworkStateChangeEventDetails.get_HasNewNetworkConnectivityLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_HasNewNetworkConnectivityLevel([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, byte*, int>)(lpVtbl[8]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkStateChangeEventDetails.xml' path='doc/member[@name="INetworkStateChangeEventDetails.get_HasNewDomainConnectivityLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HasNewDomainConnectivityLevel([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, byte*, int>)(lpVtbl[9]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkStateChangeEventDetails.xml' path='doc/member[@name="INetworkStateChangeEventDetails.get_HasNewHostNameList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HasNewHostNameList([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, byte*, int>)(lpVtbl[10]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='INetworkStateChangeEventDetails.xml' path='doc/member[@name="INetworkStateChangeEventDetails.get_HasNewWwanRegistrationState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_HasNewWwanRegistrationState([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStateChangeEventDetails*, byte*, int>)(lpVtbl[11]))((INetworkStateChangeEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HasNewInternetConnectionProfile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_HasNewConnectionCost([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_HasNewNetworkConnectivityLevel([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_HasNewDomainConnectivityLevel([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_HasNewHostNameList([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_HasNewWwanRegistrationState([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasNewInternetConnectionProfile;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasNewConnectionCost;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasNewNetworkConnectivityLevel;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasNewDomainConnectivityLevel;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasNewHostNameList;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasNewWwanRegistrationState;
    }
}
