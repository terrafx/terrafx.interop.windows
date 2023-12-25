// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoFrame.xml' path='doc/member[@name="IVideoFrame"]/*' />
[Guid("0CC06625-90FC-4C92-BD95-7DED21819D1C")]
[NativeTypeName("struct IVideoFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoFrame : IVideoFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoFrame));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, Guid*, void**, int>)(lpVtbl[0]))((IVideoFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, uint>)(lpVtbl[1]))((IVideoFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, uint>)(lpVtbl[2]))((IVideoFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoFrame*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, HSTRING*, int>)(lpVtbl[4]))((IVideoFrame*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, TrustLevel*, int>)(lpVtbl[5]))((IVideoFrame*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoFrame.xml' path='doc/member[@name="IVideoFrame.get_SoftwareBitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, ISoftwareBitmap**, int>)(lpVtbl[6]))((IVideoFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoFrame.xml' path='doc/member[@name="IVideoFrame.CopyToAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyToAsync([NativeTypeName("ABI::Windows::Media::IVideoFrame *")] IVideoFrame* frame, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, IVideoFrame*, IAsyncAction**, int>)(lpVtbl[7]))((IVideoFrame*)Unsafe.AsPointer(ref this), frame, value);
    }

    /// <include file='IVideoFrame.xml' path='doc/member[@name="IVideoFrame.get_Direct3DSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Direct3DSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **")] IDirect3DSurface** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoFrame*, IDirect3DSurface**, int>)(lpVtbl[8]))((IVideoFrame*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);

        [VtblIndex(7)]
        HRESULT CopyToAsync([NativeTypeName("ABI::Windows::Media::IVideoFrame *")] IVideoFrame* frame, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(8)]
        HRESULT get_Direct3DSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **")] IDirect3DSurface** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap**, int> get_SoftwareBitmap;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoFrame *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoFrame*, IAsyncAction**, int> CopyToAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface**, int> get_Direct3DSurface;
    }
}
