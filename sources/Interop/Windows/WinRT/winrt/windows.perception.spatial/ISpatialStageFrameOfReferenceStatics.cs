// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialStageFrameOfReferenceStatics.xml' path='doc/member[@name="ISpatialStageFrameOfReferenceStatics"]/*' />
[Guid("F78D5C4D-A0A4-499C-8D91-A8C965D40654")]
[NativeTypeName("struct ISpatialStageFrameOfReferenceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialStageFrameOfReferenceStatics : ISpatialStageFrameOfReferenceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpatialStageFrameOfReferenceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, uint>)(lpVtbl[1]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, uint>)(lpVtbl[2]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialStageFrameOfReferenceStatics.xml' path='doc/member[@name="ISpatialStageFrameOfReferenceStatics.get_Current"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Current([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStageFrameOfReference **")] ISpatialStageFrameOfReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, ISpatialStageFrameOfReference**, int>)(lpVtbl[6]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialStageFrameOfReferenceStatics.xml' path='doc/member[@name="ISpatialStageFrameOfReferenceStatics.add_CurrentChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_CurrentChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ISpatialStageFrameOfReferenceStatics.xml' path='doc/member[@name="ISpatialStageFrameOfReferenceStatics.remove_CurrentChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_CurrentChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, EventRegistrationToken, int>)(lpVtbl[8]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ISpatialStageFrameOfReferenceStatics.xml' path='doc/member[@name="ISpatialStageFrameOfReferenceStatics.RequestNewStageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestNewStageAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialStageFrameOfReference_t **")] IAsyncOperation<Pointer<ISpatialStageFrameOfReference>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialStageFrameOfReferenceStatics*, IAsyncOperation<Pointer<ISpatialStageFrameOfReference>>**, int>)(lpVtbl[9]))((ISpatialStageFrameOfReferenceStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Current([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialStageFrameOfReference **")] ISpatialStageFrameOfReference** value);

        [VtblIndex(7)]
        HRESULT add_CurrentChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(8)]
        HRESULT remove_CurrentChanged(EventRegistrationToken cookie);

        [VtblIndex(9)]
        HRESULT RequestNewStageAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialStageFrameOfReference_t **")] IAsyncOperation<Pointer<ISpatialStageFrameOfReference>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialStageFrameOfReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialStageFrameOfReference**, int> get_Current;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_CurrentChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CurrentChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialStageFrameOfReference_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISpatialStageFrameOfReference>>**, int> RequestNewStageAsync;
    }
}
