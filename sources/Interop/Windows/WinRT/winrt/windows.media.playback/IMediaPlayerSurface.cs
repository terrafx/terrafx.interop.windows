// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayerSurface.xml' path='doc/member[@name="IMediaPlayerSurface"]/*' />
[Guid("0ED653BC-B736-49C3-830B-764A3845313A")]
[NativeTypeName("struct IMediaPlayerSurface : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayerSurface : IMediaPlayerSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayerSurface));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, uint>)(lpVtbl[1]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, uint>)(lpVtbl[2]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayerSurface.xml' path='doc/member[@name="IMediaPlayerSurface.get_CompositionSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CompositionSurface([NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] ICompositionSurface** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, ICompositionSurface**, int>)(lpVtbl[6]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayerSurface.xml' path='doc/member[@name="IMediaPlayerSurface.get_Compositor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Compositor([NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, ICompositor**, int>)(lpVtbl[7]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayerSurface.xml' path='doc/member[@name="IMediaPlayerSurface.get_MediaPlayer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MediaPlayer([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerSurface*, IMediaPlayer**, int>)(lpVtbl[8]))((IMediaPlayerSurface*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CompositionSurface([NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] ICompositionSurface** value);

        [VtblIndex(7)]
        HRESULT get_Compositor([NativeTypeName("ABI::Windows::UI::Composition::ICompositor **")] ICompositor** value);

        [VtblIndex(8)]
        HRESULT get_MediaPlayer([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionSurface**, int> get_CompositionSurface;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositor**, int> get_Compositor;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlayer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlayer**, int> get_MediaPlayer;
    }
}
