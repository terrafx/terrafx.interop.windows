// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositeVideoFrameContext.xml' path='doc/member[@name="ICompositeVideoFrameContext"]/*' />
[Guid("6C30024B-F514-4278-A5F7-B9188049D110")]
[NativeTypeName("struct ICompositeVideoFrameContext : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositeVideoFrameContext : ICompositeVideoFrameContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositeVideoFrameContext));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, Guid*, void**, int>)(lpVtbl[0]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, uint>)(lpVtbl[1]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, uint>)(lpVtbl[2]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, HSTRING*, int>)(lpVtbl[4]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, TrustLevel*, int>)(lpVtbl[5]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositeVideoFrameContext.xml' path='doc/member[@name="ICompositeVideoFrameContext.get_SurfacesToOverlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SurfacesToOverlay([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDirectX__CDirect3D11__CIDirect3DSurface_t **")] IVectorView<Pointer<IDirect3DSurface>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, IVectorView<Pointer<IDirect3DSurface>>**, int>)(lpVtbl[6]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositeVideoFrameContext.xml' path='doc/member[@name="ICompositeVideoFrameContext.get_BackgroundFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BackgroundFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, IVideoFrame**, int>)(lpVtbl[7]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositeVideoFrameContext.xml' path='doc/member[@name="ICompositeVideoFrameContext.get_OutputFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutputFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, IVideoFrame**, int>)(lpVtbl[8]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositeVideoFrameContext.xml' path='doc/member[@name="ICompositeVideoFrameContext.GetOverlayForSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetOverlayForSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* surfaceToOverlay, [NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlay **")] IMediaOverlay** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositeVideoFrameContext*, IDirect3DSurface*, IMediaOverlay**, int>)(lpVtbl[9]))((ICompositeVideoFrameContext*)Unsafe.AsPointer(ref this), surfaceToOverlay, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SurfacesToOverlay([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDirectX__CDirect3D11__CIDirect3DSurface_t **")] IVectorView<Pointer<IDirect3DSurface>>** value);

        [VtblIndex(7)]
        HRESULT get_BackgroundFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value);

        [VtblIndex(8)]
        HRESULT get_OutputFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value);

        [VtblIndex(9)]
        HRESULT GetOverlayForSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *")] IDirect3DSurface* surfaceToOverlay, [NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlay **")] IMediaOverlay** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDirectX__CDirect3D11__CIDirect3DSurface_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IDirect3DSurface>>**, int> get_SurfacesToOverlay;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoFrame**, int> get_BackgroundFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoFrame**, int> get_OutputFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface *, ABI::Windows::Media::Editing::IMediaOverlay **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface*, IMediaOverlay**, int> GetOverlayForSurface;
    }
}
