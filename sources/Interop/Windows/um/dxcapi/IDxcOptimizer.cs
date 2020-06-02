// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25740E2E-9CBA-401B-9119-4FB42F39F270")]
    public unsafe partial struct IDxcOptimizer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcOptimizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcOptimizer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcOptimizer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return lpVtbl->GetAvailablePassCount((IDxcOptimizer*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailablePass([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDxcOptimizerPass **")] IDxcOptimizerPass** ppResult)
        {
            return lpVtbl->GetAvailablePass((IDxcOptimizer*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int RunOptimizer([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] ushort** ppOptions, [NativeTypeName("UINT32")] uint optionCount, [NativeTypeName("IDxcBlob **")] IDxcBlob** pOutputModule, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppOutputText)
        {
            return lpVtbl->RunOptimizer((IDxcOptimizer*)Unsafe.AsPointer(ref this), pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizer*, uint> Release;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizer*, uint*, int> GetAvailablePassCount;

            [NativeTypeName("HRESULT (UINT32, IDxcOptimizerPass **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizer*, uint, IDxcOptimizerPass**, int> GetAvailablePass;

            [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR *, UINT32, IDxcBlob **, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizer*, IDxcBlob*, ushort**, uint, IDxcBlob**, IDxcBlobEncoding**, int> RunOptimizer;
        }
    }
}
