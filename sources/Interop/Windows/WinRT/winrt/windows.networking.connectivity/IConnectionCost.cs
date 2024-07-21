// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectionCost.xml' path='doc/member[@name="IConnectionCost"]/*' />
[Guid("BAD7D829-3416-4B10-A202-BAC0B075BDAE")]
[NativeTypeName("struct IConnectionCost : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectionCost : IConnectionCost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionCost));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionCost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, uint>)(lpVtbl[1]))((IConnectionCost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, uint>)(lpVtbl[2]))((IConnectionCost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectionCost*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, HSTRING*, int>)(lpVtbl[4]))((IConnectionCost*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, TrustLevel*, int>)(lpVtbl[5]))((IConnectionCost*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectionCost.xml' path='doc/member[@name="IConnectionCost.get_NetworkCostType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NetworkCostType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType *")] NetworkCostType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, NetworkCostType*, int>)(lpVtbl[6]))((IConnectionCost*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionCost.xml' path='doc/member[@name="IConnectionCost.get_Roaming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Roaming([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, byte*, int>)(lpVtbl[7]))((IConnectionCost*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionCost.xml' path='doc/member[@name="IConnectionCost.get_OverDataLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OverDataLimit([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, byte*, int>)(lpVtbl[8]))((IConnectionCost*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IConnectionCost.xml' path='doc/member[@name="IConnectionCost.get_ApproachingDataLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ApproachingDataLimit([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionCost*, byte*, int>)(lpVtbl[9]))((IConnectionCost*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NetworkCostType([NativeTypeName("ABI::Windows::Networking::Connectivity::NetworkCostType *")] NetworkCostType* value);

        [VtblIndex(7)]
        HRESULT get_Roaming([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_OverDataLimit([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_ApproachingDataLimit([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::NetworkCostType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, NetworkCostType*, int> get_NetworkCostType;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Roaming;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_OverDataLimit;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ApproachingDataLimit;
    }
}
