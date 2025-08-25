// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPlaybackMediaMarkerSequence.xml' path='doc/member[@name="IPlaybackMediaMarkerSequence"]/*' />
[Guid("F2810CEE-638B-46CF-8817-1D111FE9D8C4")]
[NativeTypeName("struct IPlaybackMediaMarkerSequence : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPlaybackMediaMarkerSequence : IPlaybackMediaMarkerSequence.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPlaybackMediaMarkerSequence);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, Guid*, void**, int>)(lpVtbl[0]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, uint>)(lpVtbl[1]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, uint>)(lpVtbl[2]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, uint*, Guid**, int>)(lpVtbl[3]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, HSTRING*, int>)(lpVtbl[4]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, TrustLevel*, int>)(lpVtbl[5]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPlaybackMediaMarkerSequence.xml' path='doc/member[@name="IPlaybackMediaMarkerSequence.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Size([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, uint*, int>)(lpVtbl[6]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPlaybackMediaMarkerSequence.xml' path='doc/member[@name="IPlaybackMediaMarkerSequence.Insert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Insert([NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker *")] IPlaybackMediaMarker* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, IPlaybackMediaMarker*, int>)(lpVtbl[7]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPlaybackMediaMarkerSequence.xml' path='doc/member[@name="IPlaybackMediaMarkerSequence.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IPlaybackMediaMarkerSequence*, int>)(lpVtbl[8]))((IPlaybackMediaMarkerSequence*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Size([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT Insert([NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarker *")] IPlaybackMediaMarker* value);

        [VtblIndex(8)]
        HRESULT Clear();
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Size;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IPlaybackMediaMarker *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPlaybackMediaMarker*, int> Insert;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;
    }
}
