// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaOverlayLayerFactory.xml' path='doc/member[@name="IMediaOverlayLayerFactory"]/*' />
[Guid("947CB473-A39E-4362-ABBF-9F8B5070A062")]
[NativeTypeName("struct IMediaOverlayLayerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaOverlayLayerFactory : IMediaOverlayLayerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaOverlayLayerFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlayLayerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMediaOverlayLayerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlayLayerFactory*, uint>)(lpVtbl[1]))((IMediaOverlayLayerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlayLayerFactory*, uint>)(lpVtbl[2]))((IMediaOverlayLayerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlayLayerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaOverlayLayerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlayLayerFactory*, HSTRING*, int>)(lpVtbl[4]))((IMediaOverlayLayerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlayLayerFactory*, TrustLevel*, int>)(lpVtbl[5]))((IMediaOverlayLayerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaOverlayLayerFactory.xml' path='doc/member[@name="IMediaOverlayLayerFactory.CreateWithCompositorDefinition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithCompositorDefinition([NativeTypeName("ABI::Windows::Media::Effects::IVideoCompositorDefinition *")] IVideoCompositorDefinition* compositorDefinition, [NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlayLayer **")] IMediaOverlayLayer** mediaOverlayLayer)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaOverlayLayerFactory*, IVideoCompositorDefinition*, IMediaOverlayLayer**, int>)(lpVtbl[6]))((IMediaOverlayLayerFactory*)Unsafe.AsPointer(ref this), compositorDefinition, mediaOverlayLayer);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithCompositorDefinition([NativeTypeName("ABI::Windows::Media::Effects::IVideoCompositorDefinition *")] IVideoCompositorDefinition* compositorDefinition, [NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlayLayer **")] IMediaOverlayLayer** mediaOverlayLayer);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Effects::IVideoCompositorDefinition *, ABI::Windows::Media::Editing::IMediaOverlayLayer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoCompositorDefinition*, IMediaOverlayLayer**, int> CreateWithCompositorDefinition;
    }
}
