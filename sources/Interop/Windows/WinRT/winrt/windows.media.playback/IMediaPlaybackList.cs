// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList"]/*' />
[Guid("7F77EE9C-DC42-4E26-A98D-7850DF8EC925")]
[NativeTypeName("struct IMediaPlaybackList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackList : IMediaPlaybackList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaPlaybackList);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, uint>)(lpVtbl[1]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, uint>)(lpVtbl[2]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.add_ItemFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ItemFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemFailedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<IMediaPlaybackItemFailedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<IMediaPlaybackItemFailedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.remove_ItemFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ItemFailed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.add_CurrentItemChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_CurrentItemChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CCurrentMediaPlaybackItemChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<ICurrentMediaPlaybackItemChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<ICurrentMediaPlaybackItemChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.remove_CurrentItemChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_CurrentItemChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, EventRegistrationToken, int>)(lpVtbl[9]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.add_ItemOpened"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ItemOpened([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemOpenedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<IMediaPlaybackItemOpenedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<IMediaPlaybackItemOpenedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.remove_ItemOpened"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ItemOpened(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.get_Items"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Items([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **")] IObservableVector<Pointer<IMediaPlaybackItem>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, IObservableVector<Pointer<IMediaPlaybackItem>>**, int>)(lpVtbl[12]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.get_AutoRepeatEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AutoRepeatEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, byte*, int>)(lpVtbl[13]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.put_AutoRepeatEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_AutoRepeatEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, byte, int>)(lpVtbl[14]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.get_ShuffleEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ShuffleEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, byte*, int>)(lpVtbl[15]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.put_ShuffleEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ShuffleEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, byte, int>)(lpVtbl[16]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.get_CurrentItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CurrentItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, IMediaPlaybackItem**, int>)(lpVtbl[17]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.get_CurrentItemIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CurrentItemIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, uint*, int>)(lpVtbl[18]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.MoveNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MoveNext([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** item)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, IMediaPlaybackItem**, int>)(lpVtbl[19]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), item);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.MovePrevious"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT MovePrevious([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** item)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, IMediaPlaybackItem**, int>)(lpVtbl[20]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), item);
    }

    /// <include file='IMediaPlaybackList.xml' path='doc/member[@name="IMediaPlaybackList.MoveTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT MoveTo([NativeTypeName("UINT32")] uint itemIndex, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** item)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList*, uint, IMediaPlaybackItem**, int>)(lpVtbl[21]))((IMediaPlaybackList*)Unsafe.AsPointer(ref this), itemIndex, item);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ItemFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemFailedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<IMediaPlaybackItemFailedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_ItemFailed(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_CurrentItemChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CCurrentMediaPlaybackItemChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<ICurrentMediaPlaybackItemChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_CurrentItemChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_ItemOpened([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemOpenedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<IMediaPlaybackItemOpenedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ItemOpened(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_Items([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **")] IObservableVector<Pointer<IMediaPlaybackItem>>** value);

        [VtblIndex(13)]
        HRESULT get_AutoRepeatEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_AutoRepeatEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_ShuffleEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_ShuffleEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT get_CurrentItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);

        [VtblIndex(18)]
        HRESULT get_CurrentItemIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(19)]
        HRESULT MoveNext([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** item);

        [VtblIndex(20)]
        HRESULT MovePrevious([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** item);

        [VtblIndex(21)]
        HRESULT MoveTo([NativeTypeName("UINT32")] uint itemIndex, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** item);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<IMediaPlaybackItemFailedEventArgs>>*, EventRegistrationToken*, int> add_ItemFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ItemFailed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CCurrentMediaPlaybackItemChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<ICurrentMediaPlaybackItemChangedEventArgs>>*, EventRegistrationToken*, int> add_CurrentItemChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CurrentItemChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackList_Windows__CMedia__CPlayback__CMediaPlaybackItemOpenedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackList>, Pointer<IMediaPlaybackItemOpenedEventArgs>>*, EventRegistrationToken*, int> add_ItemOpened;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ItemOpened;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IObservableVector<Pointer<IMediaPlaybackItem>>**, int> get_Items;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoRepeatEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AutoRepeatEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShuffleEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShuffleEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> get_CurrentItem;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CurrentItemIndex;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> MoveNext;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> MovePrevious;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IMediaPlaybackItem**, int> MoveTo;
    }
}
