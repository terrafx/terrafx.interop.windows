// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaSource2.xml' path='doc/member[@name="IMediaSource2"]/*' />
[Guid("2EB61048-655F-4C37-B813-B4E45DFA0ABE")]
[NativeTypeName("struct IMediaSource2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaSource2 : IMediaSource2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaSource2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, uint>)(lpVtbl[1]))((IMediaSource2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, uint>)(lpVtbl[2]))((IMediaSource2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaSource2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, HSTRING*, int>)(lpVtbl[4]))((IMediaSource2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaSource2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaSource2.xml' path='doc/member[@name="IMediaSource2.add_OpenOperationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_OpenOperationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaSource_Windows__CMedia__CCore__CMediaSourceOpenOperationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaSource>, Pointer<IMediaSourceOpenOperationCompletedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, ITypedEventHandler<Pointer<IMediaSource>, Pointer<IMediaSourceOpenOperationCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaSource2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaSource2.xml' path='doc/member[@name="IMediaSource2.remove_OpenOperationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_OpenOperationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaSource2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaSource2.xml' path='doc/member[@name="IMediaSource2.get_CustomProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CustomProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, IPropertySet**, int>)(lpVtbl[8]))((IMediaSource2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSource2.xml' path='doc/member[@name="IMediaSource2.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, IReference<TimeSpan>**, int>)(lpVtbl[9]))((IMediaSource2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSource2.xml' path='doc/member[@name="IMediaSource2.get_IsOpen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsOpen([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, byte*, int>)(lpVtbl[10]))((IMediaSource2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSource2.xml' path='doc/member[@name="IMediaSource2.get_ExternalTimedTextSources"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ExternalTimedTextSources([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CCore__CTimedTextSource_t **")] IObservableVector<Pointer<ITimedTextSource>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, IObservableVector<Pointer<ITimedTextSource>>**, int>)(lpVtbl[11]))((IMediaSource2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSource2.xml' path='doc/member[@name="IMediaSource2.get_ExternalTimedMetadataTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ExternalTimedMetadataTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **")] IObservableVector<Pointer<ITimedMetadataTrack>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSource2*, IObservableVector<Pointer<ITimedMetadataTrack>>**, int>)(lpVtbl[12]))((IMediaSource2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_OpenOperationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaSource_Windows__CMedia__CCore__CMediaSourceOpenOperationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaSource>, Pointer<IMediaSourceOpenOperationCompletedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_OpenOperationCompleted(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_CustomProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(9)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(10)]
        HRESULT get_IsOpen([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_ExternalTimedTextSources([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CCore__CTimedTextSource_t **")] IObservableVector<Pointer<ITimedTextSource>>** value);

        [VtblIndex(12)]
        HRESULT get_ExternalTimedMetadataTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **")] IObservableVector<Pointer<ITimedMetadataTrack>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CMediaSource_Windows__CMedia__CCore__CMediaSourceOpenOperationCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaSource>, Pointer<IMediaSourceOpenOperationCompletedEventArgs>>*, EventRegistrationToken*, int> add_OpenOperationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OpenOperationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_CustomProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Duration;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsOpen;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CCore__CTimedTextSource_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IObservableVector<Pointer<ITimedTextSource>>**, int> get_ExternalTimedTextSources;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IObservableVector<Pointer<ITimedMetadataTrack>>**, int> get_ExternalTimedMetadataTracks;
    }
}
