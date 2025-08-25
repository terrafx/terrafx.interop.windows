// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackList2.xml' path='doc/member[@name="IMediaPlaybackList2"]/*' />
[Guid("0E09B478-600A-4274-A14B-0B6723D0F48B")]
[NativeTypeName("struct IMediaPlaybackList2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackList2 : IMediaPlaybackList2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaPlaybackList2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, uint>)(lpVtbl[1]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, uint>)(lpVtbl[2]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackList2.xml' path='doc/member[@name="IMediaPlaybackList2.get_MaxPrefetchTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxPrefetchTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, IReference<TimeSpan>**, int>)(lpVtbl[6]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList2.xml' path='doc/member[@name="IMediaPlaybackList2.put_MaxPrefetchTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MaxPrefetchTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, IReference<TimeSpan>*, int>)(lpVtbl[7]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList2.xml' path='doc/member[@name="IMediaPlaybackList2.get_StartingItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_StartingItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, IMediaPlaybackItem**, int>)(lpVtbl[8]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList2.xml' path='doc/member[@name="IMediaPlaybackList2.put_StartingItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_StartingItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem *")] IMediaPlaybackItem* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, IMediaPlaybackItem*, int>)(lpVtbl[9]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList2.xml' path='doc/member[@name="IMediaPlaybackList2.get_ShuffledItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ShuffledItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **")] IVectorView<Pointer<IMediaPlaybackItem>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, IVectorView<Pointer<IMediaPlaybackItem>>**, int>)(lpVtbl[10]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackList2.xml' path='doc/member[@name="IMediaPlaybackList2.SetShuffledItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetShuffledItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t *")] IIterable<Pointer<IMediaPlaybackItem>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackList2*, IIterable<Pointer<IMediaPlaybackItem>>*, int>)(lpVtbl[11]))((IMediaPlaybackList2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxPrefetchTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(7)]
        HRESULT put_MaxPrefetchTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(8)]
        HRESULT get_StartingItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);

        [VtblIndex(9)]
        HRESULT put_StartingItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem *")] IMediaPlaybackItem* value);

        [VtblIndex(10)]
        HRESULT get_ShuffledItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **")] IVectorView<Pointer<IMediaPlaybackItem>>** value);

        [VtblIndex(11)]
        HRESULT SetShuffledItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t *")] IIterable<Pointer<IMediaPlaybackItem>>* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_MaxPrefetchTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_MaxPrefetchTime;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> get_StartingItem;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem*, int> put_StartingItem;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IMediaPlaybackItem>>**, int> get_ShuffledItems;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CMedia__CPlayback__CMediaPlaybackItem_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IMediaPlaybackItem>>*, int> SetShuffledItems;
    }
}
