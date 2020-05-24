// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDxcOptimizerPass
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcOptimizerPass* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcOptimizerPass* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcOptimizerPass* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOptionName(IDxcOptimizerPass* pThis, [NativeTypeName("LPWSTR *")] ushort** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDescription(IDxcOptimizerPass* pThis, [NativeTypeName("LPWSTR *")] ushort** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOptionArgCount(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOptionArgName(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOptionArgDescription(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionName([NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionName>(lpVtbl->GetOptionName)((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgCount>(lpVtbl->GetOptionArgCount)((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgName([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgName>(lpVtbl->GetOptionArgName)((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgDescription([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgDescription>(lpVtbl->GetOptionArgDescription)((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public IntPtr GetOptionName;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public IntPtr GetDescription;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public IntPtr GetOptionArgCount;

            [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
            public IntPtr GetOptionArgName;

            [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
            public IntPtr GetOptionArgDescription;
        }
    }
}
