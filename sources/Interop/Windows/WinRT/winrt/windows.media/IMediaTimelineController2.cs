// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2"]/*' />
[Guid("EF74EA38-9E72-4DF9-8355-6E90C81BBADD")]
[NativeTypeName("struct IMediaTimelineController2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaTimelineController2 : IMediaTimelineController2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaTimelineController2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, uint>)(lpVtbl[1]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, uint>)(lpVtbl[2]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, HSTRING*, int>)(lpVtbl[4]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, IReference<TimeSpan>**, int>)(lpVtbl[6]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2.put_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, IReference<TimeSpan>*, int>)(lpVtbl[7]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2.get_IsLoopingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsLoopingEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, byte*, int>)(lpVtbl[8]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2.put_IsLoopingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsLoopingEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, byte, int>)(lpVtbl[9]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2.add_Failed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_Failed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_Windows__CMedia__CMediaTimelineControllerFailedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaTimelineController>, Pointer<IMediaTimelineControllerFailedEventArgs>>* eventHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, ITypedEventHandler<Pointer<IMediaTimelineController>, Pointer<IMediaTimelineControllerFailedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), eventHandler, token);
    }

    /// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2.remove_Failed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_Failed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2.add_Ended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_Ended([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaTimelineController>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, ITypedEventHandler<Pointer<IMediaTimelineController>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), eventHandler, token);
    }

    /// <include file='IMediaTimelineController2.xml' path='doc/member[@name="IMediaTimelineController2.remove_Ended"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_Ended(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController2*, EventRegistrationToken, int>)(lpVtbl[13]))((IMediaTimelineController2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(7)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(8)]
        HRESULT get_IsLoopingEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsLoopingEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT add_Failed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_Windows__CMedia__CMediaTimelineControllerFailedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaTimelineController>, Pointer<IMediaTimelineControllerFailedEventArgs>>* eventHandler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_Failed(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_Ended([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaTimelineController>, Pointer<IInspectable>>* eventHandler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_Ended(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_Duration;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsLoopingEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsLoopingEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_Windows__CMedia__CMediaTimelineControllerFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaTimelineController>, Pointer<IMediaTimelineControllerFailedEventArgs>>*, EventRegistrationToken*, int> add_Failed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Failed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaTimelineController>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Ended;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Ended;
    }
}
