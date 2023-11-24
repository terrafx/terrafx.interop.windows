// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositorInterop2.xml' path='doc/member[@name="ICompositorInterop2"]/*' />
[Guid("D3EEF34C-0667-4AFC-8D13-867607B0FE91")]
[NativeTypeName("struct ICompositorInterop2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositorInterop2 : ICompositorInterop2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositorInterop2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorInterop2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositorInterop2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorInterop2*, uint>)(lpVtbl[1]))((ICompositorInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorInterop2*, uint>)(lpVtbl[2]))((ICompositorInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositorInterop2.xml' path='doc/member[@name="ICompositorInterop2.CheckCompositionTextureSupport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CheckCompositionTextureSupport(IUnknown* renderingDevice, BOOL* supportsCompositionTextures)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorInterop2*, IUnknown*, BOOL*, int>)(lpVtbl[3]))((ICompositorInterop2*)Unsafe.AsPointer(ref this), renderingDevice, supportsCompositionTextures);
    }

    /// <include file='ICompositorInterop2.xml' path='doc/member[@name="ICompositorInterop2.CreateCompositionTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateCompositionTexture(IUnknown* d3dTexture, IInspectable** compositionTexture)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositorInterop2*, IUnknown*, IInspectable**, int>)(lpVtbl[4]))((ICompositorInterop2*)Unsafe.AsPointer(ref this), d3dTexture, compositionTexture);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CheckCompositionTextureSupport(IUnknown* renderingDevice, BOOL* supportsCompositionTextures);

        [VtblIndex(4)]
        HRESULT CreateCompositionTexture(IUnknown* d3dTexture, IInspectable** compositionTexture);
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

        [NativeTypeName("HRESULT (IUnknown *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, BOOL*, int> CheckCompositionTextureSupport;

        [NativeTypeName("HRESULT (IUnknown *, ICompositionTexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, IInspectable**, int> CreateCompositionTexture;
    }
}
