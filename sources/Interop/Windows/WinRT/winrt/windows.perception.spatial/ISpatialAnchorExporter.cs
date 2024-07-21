// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAnchorExporter.xml' path='doc/member[@name="ISpatialAnchorExporter"]/*' />
[Guid("9A2A4338-24FB-4269-89C5-88304AEEF20F")]
[NativeTypeName("struct ISpatialAnchorExporter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchorExporter : ISpatialAnchorExporter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchorExporter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExporter*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAnchorExporter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExporter*, uint>)(lpVtbl[1]))((ISpatialAnchorExporter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExporter*, uint>)(lpVtbl[2]))((ISpatialAnchorExporter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExporter*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAnchorExporter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExporter*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAnchorExporter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExporter*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAnchorExporter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAnchorExporter.xml' path='doc/member[@name="ISpatialAnchorExporter.GetAnchorExportSufficiencyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAnchorExportSufficiencyAsync([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* anchor, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose")] SpatialAnchorExportPurpose purpose, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialAnchorExportSufficiency_t **")] IAsyncOperation<Pointer<ISpatialAnchorExportSufficiency>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExporter*, ISpatialAnchor*, SpatialAnchorExportPurpose, IAsyncOperation<Pointer<ISpatialAnchorExportSufficiency>>**, int>)(lpVtbl[6]))((ISpatialAnchorExporter*)Unsafe.AsPointer(ref this), anchor, purpose, operation);
    }

    /// <include file='ISpatialAnchorExporter.xml' path='doc/member[@name="ISpatialAnchorExporter.TryExportAnchorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryExportAnchorAsync([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* anchor, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose")] SpatialAnchorExportPurpose purpose, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorExporter*, ISpatialAnchor*, SpatialAnchorExportPurpose, IOutputStream*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((ISpatialAnchorExporter*)Unsafe.AsPointer(ref this), anchor, purpose, stream, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAnchorExportSufficiencyAsync([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* anchor, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose")] SpatialAnchorExportPurpose purpose, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialAnchorExportSufficiency_t **")] IAsyncOperation<Pointer<ISpatialAnchorExportSufficiency>>** operation);

        [VtblIndex(7)]
        HRESULT TryExportAnchorAsync([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")] ISpatialAnchor* anchor, [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose")] SpatialAnchorExportPurpose purpose, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialAnchor *, ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialAnchorExportSufficiency_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialAnchor*, SpatialAnchorExportPurpose, IAsyncOperation<Pointer<ISpatialAnchorExportSufficiency>>**, int> GetAnchorExportSufficiencyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialAnchor *, ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialAnchor*, SpatialAnchorExportPurpose, IOutputStream*, IAsyncOperation<bool>**, int> TryExportAnchorAsync;
    }
}
