// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CAC701EE-80FC-4122-8242-10B39C8CEC34")]
    public unsafe partial struct ID3D11Module
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11Module*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Module*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11Module*, uint>)(lpVtbl[1]))((ID3D11Module*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11Module*, uint>)(lpVtbl[2]))((ID3D11Module*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("LPCSTR")] sbyte* pNamespace, [NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance)
        {
            return ((delegate* stdcall<ID3D11Module*, sbyte*, ID3D11ModuleInstance**, int>)(lpVtbl[3]))((ID3D11Module*)Unsafe.AsPointer(ref this), pNamespace, ppModuleInstance);
        }
    }
}
