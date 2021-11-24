// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DXProgrammableCapture.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("9F251514-9D4D-4902-9D60-18988AB7D4B5")]
[NativeTypeName("struct IDXGraphicsAnalysis : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGraphicsAnalysis : IDXGraphicsAnalysis.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGraphicsAnalysis*, Guid*, void**, int>)(lpVtbl[0]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGraphicsAnalysis*, uint>)(lpVtbl[1]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGraphicsAnalysis*, uint>)(lpVtbl[2]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void BeginCapture()
    {
        ((delegate* unmanaged<IDXGraphicsAnalysis*, void>)(lpVtbl[3]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void EndCapture()
    {
        ((delegate* unmanaged<IDXGraphicsAnalysis*, void>)(lpVtbl[4]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void BeginCapture();

        [VtblIndex(4)]
        void EndCapture();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGraphicsAnalysis*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGraphicsAnalysis*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGraphicsAnalysis*, uint> Release;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGraphicsAnalysis*, void> BeginCapture;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGraphicsAnalysis*, void> EndCapture;
    }
}
