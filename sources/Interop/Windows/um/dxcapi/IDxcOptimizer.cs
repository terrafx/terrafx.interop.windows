// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25740E2E-9CBA-401B-9119-4FB42F39F270")]
    public unsafe partial struct IDxcOptimizer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcOptimizer*, Guid*, void**, int>)(lpVtbl[0]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcOptimizer*, uint>)(lpVtbl[1]))((IDxcOptimizer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcOptimizer*, uint>)(lpVtbl[2]))((IDxcOptimizer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return ((delegate* stdcall<IDxcOptimizer*, uint*, int>)(lpVtbl[3]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailablePass([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDxcOptimizerPass **")] IDxcOptimizerPass** ppResult)
        {
            return ((delegate* stdcall<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)(lpVtbl[4]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int RunOptimizer([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] ushort** ppOptions, [NativeTypeName("UINT32")] uint optionCount, [NativeTypeName("IDxcBlob **")] IDxcBlob** pOutputModule, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppOutputText)
        {
            return ((delegate* stdcall<IDxcOptimizer*, IDxcBlob*, ushort**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        }
    }
}
