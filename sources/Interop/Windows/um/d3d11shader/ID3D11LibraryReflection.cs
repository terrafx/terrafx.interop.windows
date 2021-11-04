// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54384F1B-5B3E-4BB7-AE01-60BA3097CBB6")]
    [NativeTypeName("struct ID3D11LibraryReflection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11LibraryReflection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, uint>)(lpVtbl[1]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, uint>)(lpVtbl[2]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDesc(D3D11_LIBRARY_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, D3D11_LIBRARY_DESC*, int>)(lpVtbl[3]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D11FunctionReflection* GetFunctionByIndex(int FunctionIndex)
        {
            return ((delegate* unmanaged<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*>)(lpVtbl[4]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), FunctionIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11LibraryReflection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11LibraryReflection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11LibraryReflection*, uint> Release;

            [NativeTypeName("HRESULT (D3D11_LIBRARY_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11LibraryReflection*, D3D11_LIBRARY_DESC*, int> GetDesc;

            [NativeTypeName("ID3D11FunctionReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*> GetFunctionByIndex;
        }
    }
}
