// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102")]
    [NativeTypeName("struct ID3D10Blob : IUnknown")]
    public unsafe partial struct ID3DBlob
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3DBlob*, Guid*, void**, int>)(lpVtbl[0]))((ID3DBlob*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3DBlob*, uint>)(lpVtbl[1]))((ID3DBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3DBlob*, uint>)(lpVtbl[2]))((ID3DBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return ((delegate* stdcall<ID3DBlob*, void*>)(lpVtbl[3]))((ID3DBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return ((delegate* stdcall<ID3DBlob*, nuint>)(lpVtbl[4]))((ID3DBlob*)Unsafe.AsPointer(ref this));
        }
    }
}
