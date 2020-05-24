// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDxcLinker
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcLinker* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcLinker* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcLinker* pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterLibrary(IDxcLinker* pThis, [NativeTypeName("LPCWSTR")] ushort* pLibName, [NativeTypeName("IDxcBlob *")] IDxcBlob* pLib);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Link(IDxcLinker* pThis, [NativeTypeName("LPCWSTR")] ushort* pEntryName, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("const LPCWSTR *")] ushort** pLibNames, [NativeTypeName("UINT32")] uint libCount, [NativeTypeName("const LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcLinker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcLinker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcLinker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterLibrary([NativeTypeName("LPCWSTR")] ushort* pLibName, [NativeTypeName("IDxcBlob *")] IDxcBlob* pLib)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterLibrary>(lpVtbl->RegisterLibrary)((IDxcLinker*)Unsafe.AsPointer(ref this), pLibName, pLib);
        }

        [return: NativeTypeName("HRESULT")]
        public int Link([NativeTypeName("LPCWSTR")] ushort* pEntryName, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("const LPCWSTR *")] ushort** pLibNames, [NativeTypeName("UINT32")] uint libCount, [NativeTypeName("const LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_Link>(lpVtbl->Link)((IDxcLinker*)Unsafe.AsPointer(ref this), pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, IDxcBlob *) __attribute__((thiscall))")]
            public IntPtr RegisterLibrary;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, const LPCWSTR *, UINT32, const LPCWSTR *, UINT32, IDxcOperationResult **) __attribute__((stdcall))")]
            public IntPtr Link;
        }
    }
}
