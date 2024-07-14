// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAttributedNetworkUsage.xml' path='doc/member[@name="IAttributedNetworkUsage"]/*' />
[Guid("F769B039-ECA2-45EB-ADE1-B0368B756C49")]
[NativeTypeName("struct IAttributedNetworkUsage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAttributedNetworkUsage : IAttributedNetworkUsage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAttributedNetworkUsage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, Guid*, void**, int>)(lpVtbl[0]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, uint>)(lpVtbl[1]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, uint>)(lpVtbl[2]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, uint*, Guid**, int>)(lpVtbl[3]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, HSTRING*, int>)(lpVtbl[4]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, TrustLevel*, int>)(lpVtbl[5]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAttributedNetworkUsage.xml' path='doc/member[@name="IAttributedNetworkUsage.get_BytesSent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BytesSent([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, ulong*, int>)(lpVtbl[6]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAttributedNetworkUsage.xml' path='doc/member[@name="IAttributedNetworkUsage.get_BytesReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BytesReceived([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, ulong*, int>)(lpVtbl[7]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAttributedNetworkUsage.xml' path='doc/member[@name="IAttributedNetworkUsage.get_AttributionId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AttributionId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, HSTRING*, int>)(lpVtbl[8]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAttributedNetworkUsage.xml' path='doc/member[@name="IAttributedNetworkUsage.get_AttributionName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AttributionName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, HSTRING*, int>)(lpVtbl[9]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAttributedNetworkUsage.xml' path='doc/member[@name="IAttributedNetworkUsage.get_AttributionThumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AttributionThumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttributedNetworkUsage*, IRandomAccessStreamReference**, int>)(lpVtbl[10]))((IAttributedNetworkUsage*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BytesSent([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_BytesReceived([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(8)]
        HRESULT get_AttributionId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_AttributionName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_AttributionThumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_BytesSent;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_BytesReceived;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AttributionId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AttributionName;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_AttributionThumbnail;
    }
}
