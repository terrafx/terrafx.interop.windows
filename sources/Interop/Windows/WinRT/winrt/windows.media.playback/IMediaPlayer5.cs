// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayer5.xml' path='doc/member[@name="IMediaPlayer5"]/*' />
[Guid("CFE537FD-F86A-4446-BF4D-C8E792B7B4B3")]
[NativeTypeName("struct IMediaPlayer5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayer5 : IMediaPlayer5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayer5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, uint>)(lpVtbl[1]))((IMediaPlayer5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, uint>)(lpVtbl[2]))((IMediaPlayer5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayer5.xml' path='doc/member[@name="IMediaPlayer5.add_VideoFrameAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_VideoFrameAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer5.xml' path='doc/member[@name="IMediaPlayer5.remove_VideoFrameAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_VideoFrameAvailable(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer5.xml' path='doc/member[@name="IMediaPlayer5.get_IsVideoFrameServerEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsVideoFrameServerEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, byte*, int>)(lpVtbl[8]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer5.xml' path='doc/member[@name="IMediaPlayer5.put_IsVideoFrameServerEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsVideoFrameServerEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, byte, int>)(lpVtbl[9]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer5.xml' path='doc/member[@name="IMediaPlayer5.CopyFrameToVideoSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyFrameToVideoSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destination)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, IDirect3DSurface*, int>)(lpVtbl[10]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), destination);
    }

    /// <include file='IMediaPlayer5.xml' path='doc/member[@name="IMediaPlayer5.CopyFrameToVideoSurfaceWithTargetRectangle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CopyFrameToVideoSurfaceWithTargetRectangle([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destination, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect targetRectangle)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, IDirect3DSurface*, Rect, int>)(lpVtbl[11]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), destination, targetRectangle);
    }

    /// <include file='IMediaPlayer5.xml' path='doc/member[@name="IMediaPlayer5.CopyFrameToStereoscopicVideoSurfaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CopyFrameToStereoscopicVideoSurfaces([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destinationLeftEye, [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destinationRightEye)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer5*, IDirect3DSurface*, IDirect3DSurface*, int>)(lpVtbl[12]))((IMediaPlayer5*)Unsafe.AsPointer(ref this), destinationLeftEye, destinationRightEye);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_VideoFrameAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_VideoFrameAvailable(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_IsVideoFrameServerEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsVideoFrameServerEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT CopyFrameToVideoSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destination);

        [VtblIndex(11)]
        HRESULT CopyFrameToVideoSurfaceWithTargetRectangle([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destination, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect targetRectangle);

        [VtblIndex(12)]
        HRESULT CopyFrameToStereoscopicVideoSurfaces([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destinationLeftEye, [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* destinationRightEye);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_VideoFrameAvailable;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VideoFrameAvailable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVideoFrameServerEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsVideoFrameServerEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, int> CopyFrameToVideoSurface;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Foundation::Rect) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, Rect, int> CopyFrameToVideoSurfaceWithTargetRectangle;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, IDirect3DSurface*, int> CopyFrameToStereoscopicVideoSurfaces;
    }
}
