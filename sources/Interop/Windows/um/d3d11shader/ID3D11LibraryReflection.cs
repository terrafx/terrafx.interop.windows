// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54384F1B-5B3E-4BB7-AE01-60BA3097CBB6")]
    [NativeTypeName("struct ID3D11LibraryReflection : IUnknown")]
    public unsafe partial struct ID3D11LibraryReflection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11LibraryReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11LibraryReflection*, uint>)(lpVtbl[1]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11LibraryReflection*, uint>)(lpVtbl[2]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_LIBRARY_DESC *")] D3D11_LIBRARY_DESC* pDesc)
        {
            return ((delegate* stdcall<ID3D11LibraryReflection*, D3D11_LIBRARY_DESC*, int>)(lpVtbl[3]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D11FunctionReflection *")]
        public ID3D11FunctionReflection* GetFunctionByIndex([NativeTypeName("INT")] int FunctionIndex)
        {
            return ((delegate* stdcall<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*>)(lpVtbl[4]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), FunctionIndex);
        }
    }
}
