// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows8.0")]
[Guid("EACDD04C-117E-4E17-88F4-D1B12B0E3D89")]
[NativeTypeName("struct IDCompositionTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionTarget : IDCompositionTarget.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionTarget*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionTarget*, uint>)(lpVtbl[1]))((IDCompositionTarget*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionTarget*, uint>)(lpVtbl[2]))((IDCompositionTarget*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetRoot(IDCompositionVisual* visual)
    {
        return ((delegate* unmanaged<IDCompositionTarget*, IDCompositionVisual*, int>)(lpVtbl[3]))((IDCompositionTarget*)Unsafe.AsPointer(ref this), visual);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetRoot(IDCompositionVisual* visual);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionTarget*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionTarget*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionTarget*, uint> Release;

        [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionTarget*, IDCompositionVisual*, int> SetRoot;
    }
}
