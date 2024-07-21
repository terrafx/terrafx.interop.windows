// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties"]/*' />
[Guid("5125316A-C3A2-475B-8507-93534DC88F15")]
[NativeTypeName("struct ISystemMediaTransportControlsTimelineProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemMediaTransportControlsTimelineProperties : ISystemMediaTransportControlsTimelineProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemMediaTransportControlsTimelineProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, uint>)(lpVtbl[1]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, uint>)(lpVtbl[2]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, HSTRING*, int>)(lpVtbl[4]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan*, int>)(lpVtbl[6]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.put_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan, int>)(lpVtbl[7]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.get_EndTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_EndTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan*, int>)(lpVtbl[8]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.put_EndTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_EndTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan, int>)(lpVtbl[9]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.get_MinSeekTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MinSeekTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan*, int>)(lpVtbl[10]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.put_MinSeekTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MinSeekTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan, int>)(lpVtbl[11]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.get_MaxSeekTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MaxSeekTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan*, int>)(lpVtbl[12]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.put_MaxSeekTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_MaxSeekTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan, int>)(lpVtbl[13]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan*, int>)(lpVtbl[14]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsTimelineProperties.xml' path='doc/member[@name="ISystemMediaTransportControlsTimelineProperties.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsTimelineProperties*, TimeSpan, int>)(lpVtbl[15]))((ISystemMediaTransportControlsTimelineProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(8)]
        HRESULT get_EndTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT put_EndTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_MinSeekTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(11)]
        HRESULT put_MinSeekTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(12)]
        HRESULT get_MaxSeekTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(13)]
        HRESULT put_MaxSeekTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(14)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(15)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_EndTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_EndTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_MinSeekTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_MinSeekTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_MaxSeekTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_MaxSeekTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Position;
    }
}
