// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackItem2.xml' path='doc/member[@name="IMediaPlaybackItem2"]/*' />
[Guid("D859D171-D7EF-4B81-AC1F-F40493CBB091")]
[NativeTypeName("struct IMediaPlaybackItem2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackItem2 : IMediaPlaybackItem2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackItem2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, uint>)(lpVtbl[1]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, uint>)(lpVtbl[2]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackItem2.xml' path='doc/member[@name="IMediaPlaybackItem2.get_BreakSchedule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BreakSchedule([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreakSchedule **")] IMediaBreakSchedule** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, IMediaBreakSchedule**, int>)(lpVtbl[6]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem2.xml' path='doc/member[@name="IMediaPlaybackItem2.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, TimeSpan*, int>)(lpVtbl[7]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem2.xml' path='doc/member[@name="IMediaPlaybackItem2.get_DurationLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DurationLimit([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, IReference<TimeSpan>**, int>)(lpVtbl[8]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem2.xml' path='doc/member[@name="IMediaPlaybackItem2.get_CanSkip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CanSkip([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, byte*, int>)(lpVtbl[9]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem2.xml' path='doc/member[@name="IMediaPlaybackItem2.put_CanSkip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CanSkip([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, byte, int>)(lpVtbl[10]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem2.xml' path='doc/member[@name="IMediaPlaybackItem2.GetDisplayProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDisplayProperties([NativeTypeName("ABI::Windows::Media::Playback::IMediaItemDisplayProperties **")] IMediaItemDisplayProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, IMediaItemDisplayProperties**, int>)(lpVtbl[11]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem2.xml' path='doc/member[@name="IMediaPlaybackItem2.ApplyDisplayProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ApplyDisplayProperties([NativeTypeName("ABI::Windows::Media::Playback::IMediaItemDisplayProperties *")] IMediaItemDisplayProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem2*, IMediaItemDisplayProperties*, int>)(lpVtbl[12]))((IMediaPlaybackItem2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BreakSchedule([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreakSchedule **")] IMediaBreakSchedule** value);

        [VtblIndex(7)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT get_DurationLimit([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(9)]
        HRESULT get_CanSkip([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_CanSkip([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT GetDisplayProperties([NativeTypeName("ABI::Windows::Media::Playback::IMediaItemDisplayProperties **")] IMediaItemDisplayProperties** value);

        [VtblIndex(12)]
        HRESULT ApplyDisplayProperties([NativeTypeName("ABI::Windows::Media::Playback::IMediaItemDisplayProperties *")] IMediaItemDisplayProperties* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreakSchedule **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreakSchedule**, int> get_BreakSchedule;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_DurationLimit;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanSkip;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanSkip;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaItemDisplayProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaItemDisplayProperties**, int> GetDisplayProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaItemDisplayProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaItemDisplayProperties*, int> ApplyDisplayProperties;
    }
}
