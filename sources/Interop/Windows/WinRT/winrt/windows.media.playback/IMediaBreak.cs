// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaBreak.xml' path='doc/member[@name="IMediaBreak"]/*' />
[Guid("714BE270-0DEF-4EBC-A489-6B34930E1558")]
[NativeTypeName("struct IMediaBreak : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaBreak : IMediaBreak.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaBreak));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBreak*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, uint>)(lpVtbl[1]))((IMediaBreak*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, uint>)(lpVtbl[2]))((IMediaBreak*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaBreak*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, HSTRING*, int>)(lpVtbl[4]))((IMediaBreak*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, TrustLevel*, int>)(lpVtbl[5]))((IMediaBreak*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaBreak.xml' path='doc/member[@name="IMediaBreak.get_PlaybackList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PlaybackList([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackList **")] IMediaPlaybackList** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, IMediaPlaybackList**, int>)(lpVtbl[6]))((IMediaBreak*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreak.xml' path='doc/member[@name="IMediaBreak.get_PresentationPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PresentationPosition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, IReference<TimeSpan>**, int>)(lpVtbl[7]))((IMediaBreak*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreak.xml' path='doc/member[@name="IMediaBreak.get_InsertionMethod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InsertionMethod([NativeTypeName("ABI::Windows::Media::Playback::MediaBreakInsertionMethod *")] MediaBreakInsertionMethod* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, MediaBreakInsertionMethod*, int>)(lpVtbl[8]))((IMediaBreak*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreak.xml' path='doc/member[@name="IMediaBreak.get_CustomProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CustomProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, IPropertySet**, int>)(lpVtbl[9]))((IMediaBreak*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreak.xml' path='doc/member[@name="IMediaBreak.get_CanStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CanStart([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, byte*, int>)(lpVtbl[10]))((IMediaBreak*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreak.xml' path='doc/member[@name="IMediaBreak.put_CanStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CanStart([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreak*, byte, int>)(lpVtbl[11]))((IMediaBreak*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PlaybackList([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackList **")] IMediaPlaybackList** value);

        [VtblIndex(7)]
        HRESULT get_PresentationPosition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(8)]
        HRESULT get_InsertionMethod([NativeTypeName("ABI::Windows::Media::Playback::MediaBreakInsertionMethod *")] MediaBreakInsertionMethod* value);

        [VtblIndex(9)]
        HRESULT get_CustomProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(10)]
        HRESULT get_CanStart([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_CanStart([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackList**, int> get_PlaybackList;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_PresentationPosition;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaBreakInsertionMethod *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaBreakInsertionMethod*, int> get_InsertionMethod;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_CustomProperties;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanStart;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanStart;
    }
}
