// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("59A6CD0E-E10D-4C1F-88C0-63ABA1DAF30E")]
    public unsafe partial struct ID3D11Linker
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11Linker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11Linker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11Linker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Link([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pEntry, [NativeTypeName("LPCSTR")] sbyte* pEntryName, [NativeTypeName("LPCSTR")] sbyte* pTargetName, [NativeTypeName("UINT")] uint uFlags, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppShaderBlob, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBuffer)
        {
            return lpVtbl->Link((ID3D11Linker*)Unsafe.AsPointer(ref this), pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int UseLibrary([NativeTypeName("struct ID3D11ModuleInstance *")] ID3D11ModuleInstance* pLibraryMI)
        {
            return lpVtbl->UseLibrary((ID3D11Linker*)Unsafe.AsPointer(ref this), pLibraryMI);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddClipPlaneFromCBuffer([NativeTypeName("UINT")] uint uCBufferSlot, [NativeTypeName("UINT")] uint uCBufferEntry)
        {
            return lpVtbl->AddClipPlaneFromCBuffer((ID3D11Linker*)Unsafe.AsPointer(ref this), uCBufferSlot, uCBufferEntry);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Linker*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Linker*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Linker*, uint> Release;

            [NativeTypeName("HRESULT (struct ID3D11ModuleInstance *, LPCSTR, LPCSTR, UINT, ID3DBlob **, ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Linker*, ID3D11ModuleInstance*, sbyte*, sbyte*, uint, ID3DBlob**, ID3DBlob**, int> Link;

            [NativeTypeName("HRESULT (struct ID3D11ModuleInstance *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Linker*, ID3D11ModuleInstance*, int> UseLibrary;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Linker*, uint, uint, int> AddClipPlaneFromCBuffer;
        }
    }
}
