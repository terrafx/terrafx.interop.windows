// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayer6.xml' path='doc/member[@name="IMediaPlayer6"]/*' />
[Guid("E0CAA086-AE65-414C-B010-8BC55F00E692")]
[NativeTypeName("struct IMediaPlayer6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayer6 : IMediaPlayer6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayer6));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayer6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, uint>)(lpVtbl[1]))((IMediaPlayer6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, uint>)(lpVtbl[2]))((IMediaPlayer6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayer6*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayer6*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayer6*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayer6.xml' path='doc/member[@name="IMediaPlayer6.add_SubtitleFrameChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SubtitleFrameChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaPlayer6*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlayer6.xml' path='doc/member[@name="IMediaPlayer6.remove_SubtitleFrameChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SubtitleFrameChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaPlayer6*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer6.xml' path='doc/member[@name="IMediaPlayer6.RenderSubtitlesToSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RenderSubtitlesToSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destination, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, IDirect3DSurface*, byte*, int>)(lpVtbl[8]))((IMediaPlayer6*)Unsafe.AsPointer(ref this), destination, result);
    }

    /// <include file='IMediaPlayer6.xml' path='doc/member[@name="IMediaPlayer6.RenderSubtitlesToSurfaceWithTargetRectangle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RenderSubtitlesToSurfaceWithTargetRectangle([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destination, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect targetRectangle, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer6*, IDirect3DSurface*, Rect, byte*, int>)(lpVtbl[9]))((IMediaPlayer6*)Unsafe.AsPointer(ref this), destination, targetRectangle, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SubtitleFrameChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_SubtitleFrameChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT RenderSubtitlesToSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destination, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT RenderSubtitlesToSurfaceWithTargetRectangle([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destination, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect targetRectangle, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_SubtitleFrameChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SubtitleFrameChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, byte*, int> RenderSubtitlesToSurface;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Foundation::Rect, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, Rect, byte*, int> RenderSubtitlesToSurfaceWithTargetRectangle;
    }
}
