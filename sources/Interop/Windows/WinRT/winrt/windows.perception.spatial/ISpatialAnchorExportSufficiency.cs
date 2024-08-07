// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAnchorExportSufficiency.xml' path='doc/member[@name="ISpatialAnchorExportSufficiency"]/*' />
[Guid("77C25B2B-3409-4088-B91B-FDFD05D1648F")]
[NativeTypeName("struct ISpatialAnchorExportSufficiency : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchorExportSufficiency : ISpatialAnchorExportSufficiency.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchorExportSufficiency));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, uint>)(lpVtbl[1]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, uint>)(lpVtbl[2]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAnchorExportSufficiency.xml' path='doc/member[@name="ISpatialAnchorExportSufficiency.get_IsMinimallySufficient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsMinimallySufficient([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, byte*, int>)(lpVtbl[6]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAnchorExportSufficiency.xml' path='doc/member[@name="ISpatialAnchorExportSufficiency.get_SufficiencyLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SufficiencyLevel(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, double*, int>)(lpVtbl[7]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialAnchorExportSufficiency.xml' path='doc/member[@name="ISpatialAnchorExportSufficiency.get_RecommendedSufficiencyLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RecommendedSufficiencyLevel(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExportSufficiency*, double*, int>)(lpVtbl[8]))((ISpatialAnchorExportSufficiency*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsMinimallySufficient([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SufficiencyLevel(double* value);

        [VtblIndex(8)]
        HRESULT get_RecommendedSufficiencyLevel(double* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMinimallySufficient;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_SufficiencyLevel;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RecommendedSufficiencyLevel;
    }
}
