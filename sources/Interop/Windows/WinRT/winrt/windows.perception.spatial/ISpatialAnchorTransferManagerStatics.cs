// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialAnchorTransferManagerStatics.xml' path='doc/member[@name="ISpatialAnchorTransferManagerStatics"]/*' />
[Guid("03BBF9B9-12D8-4BCE-8835-C5DF3AC0ADAB")]
[NativeTypeName("struct ISpatialAnchorTransferManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
public unsafe partial struct ISpatialAnchorTransferManagerStatics : ISpatialAnchorTransferManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpatialAnchorTransferManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, uint>)(lpVtbl[1]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, uint>)(lpVtbl[2]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialAnchorTransferManagerStatics.xml' path='doc/member[@name="ISpatialAnchorTransferManagerStatics.TryImportAnchorsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
    public HRESULT TryImportAnchorsAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **")] IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<ISpatialAnchor>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, IInputStream*, IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<ISpatialAnchor>>>>**, int>)(lpVtbl[6]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this), stream, operation);
    }

    /// <include file='ISpatialAnchorTransferManagerStatics.xml' path='doc/member[@name="ISpatialAnchorTransferManagerStatics.TryExportAnchorsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
    public HRESULT TryExportAnchorsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<ISpatialAnchor>>>>* anchors, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<ISpatialAnchor>>>>*, IOutputStream*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this), anchors, stream, operation);
    }

    /// <include file='ISpatialAnchorTransferManagerStatics.xml' path='doc/member[@name="ISpatialAnchorTransferManagerStatics.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialPerceptionAccessStatus_t **")] IAsyncOperation<SpatialPerceptionAccessStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialAnchorTransferManagerStatics*, IAsyncOperation<SpatialPerceptionAccessStatus>**, int>)(lpVtbl[8]))((ISpatialAnchorTransferManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
        HRESULT TryImportAnchorsAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **")] IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<ISpatialAnchor>>>>** operation);

        [VtblIndex(7)]
        [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
        HRESULT TryExportAnchorsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<ISpatialAnchor>>>>* anchors, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(8)]
        [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialPerceptionAccessStatus_t **")] IAsyncOperation<SpatialPerceptionAccessStatus>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **) __attribute__((stdcall))")]
        [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<ISpatialAnchor>>>>**, int> TryImportAnchorsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<ISpatialAnchor>>>>*, IOutputStream*, IAsyncOperation<bool>**, int> TryExportAnchorsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialPerceptionAccessStatus_t **) __attribute__((stdcall))")]
        [Obsolete("Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<SpatialPerceptionAccessStatus>**, int> RequestAccessAsync;
    }
}
