// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("10DF43C8-1DBE-11D3-8B34-006097DF5BD4")]
[NativeTypeName("struct IBrowserFrameOptions : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBrowserFrameOptions : IBrowserFrameOptions.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBrowserFrameOptions*, Guid*, void**, int>)(lpVtbl[0]))((IBrowserFrameOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBrowserFrameOptions*, uint>)(lpVtbl[1]))((IBrowserFrameOptions*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBrowserFrameOptions*, uint>)(lpVtbl[2]))((IBrowserFrameOptions*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFrameOptions([NativeTypeName("BROWSERFRAMEOPTIONS")] uint dwMask, [NativeTypeName("BROWSERFRAMEOPTIONS *")] uint* pdwOptions)
    {
        return ((delegate* unmanaged<IBrowserFrameOptions*, uint, uint*, int>)(lpVtbl[3]))((IBrowserFrameOptions*)Unsafe.AsPointer(ref this), dwMask, pdwOptions);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFrameOptions([NativeTypeName("BROWSERFRAMEOPTIONS")] uint dwMask, [NativeTypeName("BROWSERFRAMEOPTIONS *")] uint* pdwOptions);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserFrameOptions*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserFrameOptions*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserFrameOptions*, uint> Release;

        [NativeTypeName("HRESULT (BROWSERFRAMEOPTIONS, BROWSERFRAMEOPTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserFrameOptions*, uint, uint*, int> GetFrameOptions;
    }
}
