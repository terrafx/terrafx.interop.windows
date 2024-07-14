// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastStreamVideoHeader"]/*' />
[Guid("0B9EBECE-7E32-432D-8CA2-36BF10B9F462")]
[NativeTypeName("struct IAppBroadcastStreamVideoHeader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastStreamVideoHeader : IAppBroadcastStreamVideoHeader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastStreamVideoHeader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, uint>)(lpVtbl[1]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, uint>)(lpVtbl[2]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastStreamVideoHeader.get_AbsoluteTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AbsoluteTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, WinRTDateTime*, int>)(lpVtbl[6]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastStreamVideoHeader.get_RelativeTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RelativeTimestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, TimeSpan*, int>)(lpVtbl[7]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastStreamVideoHeader.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, TimeSpan*, int>)(lpVtbl[8]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastStreamVideoHeader.get_IsKeyFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsKeyFrame([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, byte*, int>)(lpVtbl[9]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastStreamVideoHeader.get_HasDiscontinuity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HasDiscontinuity([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, byte*, int>)(lpVtbl[10]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastStreamVideoHeader.get_FrameId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_FrameId([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastStreamVideoHeader*, ulong*, int>)(lpVtbl[11]))((IAppBroadcastStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AbsoluteTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        HRESULT get_RelativeTimestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT get_IsKeyFrame([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_HasDiscontinuity([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_FrameId([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_AbsoluteTimestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_RelativeTimestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsKeyFrame;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HasDiscontinuity;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_FrameId;
    }
}
