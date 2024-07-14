// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastPreviewStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamVideoHeader"]/*' />
[Guid("8BEF6113-DA84-4499-A7AB-87118CB4A157")]
[NativeTypeName("struct IAppBroadcastPreviewStreamVideoHeader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastPreviewStreamVideoHeader : IAppBroadcastPreviewStreamVideoHeader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastPreviewStreamVideoHeader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, uint>)(lpVtbl[1]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, uint>)(lpVtbl[2]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastPreviewStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamVideoHeader.get_AbsoluteTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AbsoluteTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, WinRTDateTime*, int>)(lpVtbl[6]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPreviewStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamVideoHeader.get_RelativeTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RelativeTimestamp([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, TimeSpan*, int>)(lpVtbl[7]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPreviewStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamVideoHeader.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, TimeSpan*, int>)(lpVtbl[8]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastPreviewStreamVideoHeader.xml' path='doc/member[@name="IAppBroadcastPreviewStreamVideoHeader.get_FrameId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_FrameId([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastPreviewStreamVideoHeader*, ulong*, int>)(lpVtbl[9]))((IAppBroadcastPreviewStreamVideoHeader*)Unsafe.AsPointer(ref this), value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_FrameId;
    }
}
