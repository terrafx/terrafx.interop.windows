// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoCompositor.xml' path='doc/member[@name="IVideoCompositor"]/*' />
[Guid("8510B43E-420C-420F-96C7-7C98BBA1FC55")]
[NativeTypeName("struct IVideoCompositor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoCompositor : IVideoCompositor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoCompositor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, Guid*, void**, int>)(lpVtbl[0]))((IVideoCompositor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, uint>)(lpVtbl[1]))((IVideoCompositor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, uint>)(lpVtbl[2]))((IVideoCompositor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoCompositor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, HSTRING*, int>)(lpVtbl[4]))((IVideoCompositor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, TrustLevel*, int>)(lpVtbl[5]))((IVideoCompositor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoCompositor.xml' path='doc/member[@name="IVideoCompositor.get_TimeIndependent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TimeIndependent([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, byte*, int>)(lpVtbl[6]))((IVideoCompositor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoCompositor.xml' path='doc/member[@name="IVideoCompositor.SetEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")] IVideoEncodingProperties* backgroundProperties, [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")] IDirect3DDevice* device)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, IVideoEncodingProperties*, IDirect3DDevice*, int>)(lpVtbl[7]))((IVideoCompositor*)Unsafe.AsPointer(ref this), backgroundProperties, device);
    }

    /// <include file='IVideoCompositor.xml' path='doc/member[@name="IVideoCompositor.CompositeFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CompositeFrame([NativeTypeName("ABI::Windows::Media::Effects::ICompositeVideoFrameContext *")] ICompositeVideoFrameContext* context)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, ICompositeVideoFrameContext*, int>)(lpVtbl[8]))((IVideoCompositor*)Unsafe.AsPointer(ref this), context);
    }

    /// <include file='IVideoCompositor.xml' path='doc/member[@name="IVideoCompositor.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close([NativeTypeName("ABI::Windows::Media::Effects::MediaEffectClosedReason")] MediaEffectClosedReason reason)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, MediaEffectClosedReason, int>)(lpVtbl[9]))((IVideoCompositor*)Unsafe.AsPointer(ref this), reason);
    }

    /// <include file='IVideoCompositor.xml' path='doc/member[@name="IVideoCompositor.DiscardQueuedFrames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DiscardQueuedFrames()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoCompositor*, int>)(lpVtbl[10]))((IVideoCompositor*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TimeIndependent([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT SetEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")] IVideoEncodingProperties* backgroundProperties, [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *")] IDirect3DDevice* device);

        [VtblIndex(8)]
        HRESULT CompositeFrame([NativeTypeName("ABI::Windows::Media::Effects::ICompositeVideoFrameContext *")] ICompositeVideoFrameContext* context);

        [VtblIndex(9)]
        HRESULT Close([NativeTypeName("ABI::Windows::Media::Effects::MediaEffectClosedReason")] MediaEffectClosedReason reason);

        [VtblIndex(10)]
        HRESULT DiscardQueuedFrames();
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_TimeIndependent;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *, ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties*, IDirect3DDevice*, int> SetEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::ICompositeVideoFrameContext *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositeVideoFrameContext*, int> CompositeFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::MediaEffectClosedReason) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaEffectClosedReason, int> Close;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DiscardQueuedFrames;
    }
}
