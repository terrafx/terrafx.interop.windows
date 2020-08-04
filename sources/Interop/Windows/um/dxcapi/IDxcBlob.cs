// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102")]
    public unsafe partial struct IDxcBlob
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcBlob*, Guid*, void**, int>)(lpVtbl[0]))((IDxcBlob*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcBlob*, uint>)(lpVtbl[1]))((IDxcBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcBlob*, uint>)(lpVtbl[2]))((IDxcBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return ((delegate* stdcall<IDxcBlob*, void*>)(lpVtbl[3]))((IDxcBlob*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return ((delegate* stdcall<IDxcBlob*, nuint>)(lpVtbl[4]))((IDxcBlob*)Unsafe.AsPointer(ref this));
        }
    }
}
