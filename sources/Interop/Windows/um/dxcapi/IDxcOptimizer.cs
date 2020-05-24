// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDxcOptimizer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcOptimizer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcOptimizer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcOptimizer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAvailablePassCount(IDxcOptimizer* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAvailablePass(IDxcOptimizer* pThis, [NativeTypeName("UINT32")] uint index, [NativeTypeName("IDxcOptimizerPass **")] IDxcOptimizerPass** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RunOptimizer(IDxcOptimizer* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] ushort** ppOptions, [NativeTypeName("UINT32")] uint optionCount, [NativeTypeName("IDxcBlob **")] IDxcBlob** pOutputModule, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppOutputText);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcOptimizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcOptimizer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcOptimizer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAvailablePassCount>(lpVtbl->GetAvailablePassCount)((IDxcOptimizer*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailablePass([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDxcOptimizerPass **")] IDxcOptimizerPass** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAvailablePass>(lpVtbl->GetAvailablePass)((IDxcOptimizer*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int RunOptimizer([NativeTypeName("IDxcBlob *")] IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] ushort** ppOptions, [NativeTypeName("UINT32")] uint optionCount, [NativeTypeName("IDxcBlob **")] IDxcBlob** pOutputModule, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppOutputText)
        {
            return Marshal.GetDelegateForFunctionPointer<_RunOptimizer>(lpVtbl->RunOptimizer)((IDxcOptimizer*)Unsafe.AsPointer(ref this), pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public IntPtr GetAvailablePassCount;

            [NativeTypeName("HRESULT (UINT32, IDxcOptimizerPass **) __attribute__((stdcall))")]
            public IntPtr GetAvailablePass;

            [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR *, UINT32, IDxcBlob **, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr RunOptimizer;
        }
    }
}
