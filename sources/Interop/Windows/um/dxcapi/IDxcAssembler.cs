// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("091f7a26-1c1f-4948-904b-e6e3a8a771d5")]
    public unsafe partial struct IDxcAssembler
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcAssembler*, Guid*, void**, int>)(lpVtbl[0]))((IDxcAssembler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcAssembler*, uint>)(lpVtbl[1]))((IDxcAssembler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcAssembler*, uint>)(lpVtbl[2]))((IDxcAssembler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AssembleToContainer([NativeTypeName("IDxcBlob *")] IDxcBlob* pShader, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return ((delegate* stdcall<IDxcAssembler*, IDxcBlob*, IDxcOperationResult**, int>)(lpVtbl[3]))((IDxcAssembler*)Unsafe.AsPointer(ref this), pShader, ppResult);
        }
    }
}
