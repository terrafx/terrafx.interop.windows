// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialEntityFactory.xml' path='doc/member[@name="ISpatialEntityFactory"]/*' />
[Guid("E1F1E325-349F-4225-A2F3-4B01C15FE056")]
[NativeTypeName("struct ISpatialEntityFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialEntityFactory : ISpatialEntityFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialEntityFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialEntityFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityFactory*, uint>)(lpVtbl[1]))((ISpatialEntityFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityFactory*, uint>)(lpVtbl[2]))((ISpatialEntityFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialEntityFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityFactory*, HSTRING*, int>)(lpVtbl[4]))((ISpatialEntityFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialEntityFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialEntityFactory.xml' path='doc/member[@name="ISpatialEntityFactory.CreateWithSpatialAnchor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithSpatialAnchor([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* spatialAnchor, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity **")] ISpatialEntity** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityFactory*, ISpatialAnchor*, ISpatialEntity**, int>)(lpVtbl[6]))((ISpatialEntityFactory*)Unsafe.AsPointer(ref this), spatialAnchor, value);
    }

    /// <include file='ISpatialEntityFactory.xml' path='doc/member[@name="ISpatialEntityFactory.CreateWithSpatialAnchorAndProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithSpatialAnchorAndProperties([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* spatialAnchor, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* propertySet, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity **")] ISpatialEntity** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialEntityFactory*, ISpatialAnchor*, IPropertySet*, ISpatialEntity**, int>)(lpVtbl[7]))((ISpatialEntityFactory*)Unsafe.AsPointer(ref this), spatialAnchor, propertySet, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithSpatialAnchor([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* spatialAnchor, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity **")] ISpatialEntity** value);

        [VtblIndex(7)]
        HRESULT CreateWithSpatialAnchorAndProperties([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* spatialAnchor, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* propertySet, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity **")] ISpatialEntity** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialAnchor *, ABI::Windows::Perception::Spatial::ISpatialEntity **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialAnchor*, ISpatialEntity**, int> CreateWithSpatialAnchor;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialAnchor *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Perception::Spatial::ISpatialEntity **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialAnchor*, IPropertySet*, ISpatialEntity**, int> CreateWithSpatialAnchorAndProperties;
    }
}
