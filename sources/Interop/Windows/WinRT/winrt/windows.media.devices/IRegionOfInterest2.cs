// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRegionOfInterest2.xml' path='doc/member[@name="IRegionOfInterest2"]/*' />
[Guid("19FE2A91-73AA-4D51-8A9D-56CCF7DB7F54")]
[NativeTypeName("struct IRegionOfInterest2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRegionOfInterest2 : IRegionOfInterest2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRegionOfInterest2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, Guid*, void**, int>)(lpVtbl[0]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, uint>)(lpVtbl[1]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, uint>)(lpVtbl[2]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, uint*, Guid**, int>)(lpVtbl[3]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, HSTRING*, int>)(lpVtbl[4]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, TrustLevel*, int>)(lpVtbl[5]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRegionOfInterest2.xml' path='doc/member[@name="IRegionOfInterest2.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Media::Devices::RegionOfInterestType *")] RegionOfInterestType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, RegionOfInterestType*, int>)(lpVtbl[6]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest2.xml' path='doc/member[@name="IRegionOfInterest2.put_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Type([NativeTypeName("ABI::Windows::Media::Devices::RegionOfInterestType")] RegionOfInterestType value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, RegionOfInterestType, int>)(lpVtbl[7]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest2.xml' path='doc/member[@name="IRegionOfInterest2.get_BoundsNormalized"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BoundsNormalized([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, byte*, int>)(lpVtbl[8]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest2.xml' path='doc/member[@name="IRegionOfInterest2.put_BoundsNormalized"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BoundsNormalized([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, byte, int>)(lpVtbl[9]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest2.xml' path='doc/member[@name="IRegionOfInterest2.get_Weight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Weight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, uint*, int>)(lpVtbl[10]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRegionOfInterest2.xml' path='doc/member[@name="IRegionOfInterest2.put_Weight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Weight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRegionOfInterest2*, uint, int>)(lpVtbl[11]))((IRegionOfInterest2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Media::Devices::RegionOfInterestType *")] RegionOfInterestType* value);

        [VtblIndex(7)]
        HRESULT put_Type([NativeTypeName("ABI::Windows::Media::Devices::RegionOfInterestType")] RegionOfInterestType value);

        [VtblIndex(8)]
        HRESULT get_BoundsNormalized([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_BoundsNormalized([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_Weight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT put_Weight([NativeTypeName("UINT32")] uint value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::RegionOfInterestType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RegionOfInterestType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::RegionOfInterestType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RegionOfInterestType, int> put_Type;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_BoundsNormalized;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_BoundsNormalized;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Weight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Weight;
    }
}
