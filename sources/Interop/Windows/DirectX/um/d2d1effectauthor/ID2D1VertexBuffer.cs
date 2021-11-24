// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("9B8B1336-00A5-4668-92B7-CED5D8BF9B7B")]
[NativeTypeName("struct ID2D1VertexBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1VertexBuffer : ID2D1VertexBuffer.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, uint>)(lpVtbl[1]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, uint>)(lpVtbl[2]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Map(byte** data, [NativeTypeName("UINT32")] uint bufferSize)
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, byte**, uint, int>)(lpVtbl[3]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this), data, bufferSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unmap()
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, int>)(lpVtbl[4]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Map(byte** data, [NativeTypeName("UINT32")] uint bufferSize);

        [VtblIndex(4)]
        HRESULT Unmap();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1VertexBuffer*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1VertexBuffer*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1VertexBuffer*, uint> Release;

        [NativeTypeName("HRESULT (BYTE **, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1VertexBuffer*, byte**, uint, int> Map;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID2D1VertexBuffer*, int> Unmap;
    }
}
