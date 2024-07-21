// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayer4.xml' path='doc/member[@name="IMediaPlayer4"]/*' />
[Guid("80035DB0-7448-4770-AFCF-2A57450914C5")]
[NativeTypeName("struct IMediaPlayer4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayer4 : IMediaPlayer4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayer4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer4*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayer4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer4*, uint>)(lpVtbl[1]))((IMediaPlayer4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer4*, uint>)(lpVtbl[2]))((IMediaPlayer4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer4*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayer4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer4*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayer4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer4*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayer4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayer4.xml' path='doc/member[@name="IMediaPlayer4.SetSurfaceSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSurfaceSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size size)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer4*, Size, int>)(lpVtbl[6]))((IMediaPlayer4*)Unsafe.AsPointer(ref this), size);
    }

    /// <include file='IMediaPlayer4.xml' path='doc/member[@name="IMediaPlayer4.GetSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSurface([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* compositor, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayerSurface **")] IMediaPlayerSurface** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer4*, ICompositor*, IMediaPlayerSurface**, int>)(lpVtbl[7]))((IMediaPlayer4*)Unsafe.AsPointer(ref this), compositor, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetSurfaceSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size size);

        [VtblIndex(7)]
        HRESULT GetSurface([NativeTypeName("ABI::Windows::UI::Composition::ICompositor *")] ICompositor* compositor, [NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayerSurface **")] IMediaPlayerSurface** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, int> SetSurfaceSize;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor *, ABI::Windows::Media::Playback::IMediaPlayerSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor*, IMediaPlayerSurface**, int> GetSurface;
    }
}
