// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectXShaderCompiler, include/dxc/dxcapi.h, at commit d356a8bc546da38612cac13d1e643de17a0ba38f
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IDxcCompiler2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcCompiler2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcCompiler2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcCompiler2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Compile(IDxcCompiler2* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Preprocess(IDxcCompiler2* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Disassemble(IDxcCompiler2* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppDisassembly);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CompileWithDebug(IDxcCompiler2* pThis, [NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult, [NativeTypeName("LPWSTR *")] ushort** ppDebugBlobName, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppDebugBlob);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcCompiler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcCompiler2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcCompiler2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Compile([NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_Compile>(lpVtbl->Compile)((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Preprocess([NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_Preprocess>(lpVtbl->Preprocess)((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Disassemble([NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppDisassembly)
        {
            return Marshal.GetDelegateForFunctionPointer<_Disassemble>(lpVtbl->Disassemble)((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, ppDisassembly);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompileWithDebug([NativeTypeName("IDxcBlob *")] IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, [NativeTypeName("IDxcIncludeHandler *")] IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult, [NativeTypeName("LPWSTR *")] ushort** ppDebugBlobName, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppDebugBlob)
        {
            return Marshal.GetDelegateForFunctionPointer<_CompileWithDebug>(lpVtbl->CompileWithDebug)((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult, ppDebugBlobName, ppDebugBlob);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **) __attribute__((stdcall))")]
            public IntPtr Compile;

            [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **) __attribute__((stdcall))")]
            public IntPtr Preprocess;

            [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr Disassemble;

            [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **, LPWSTR *, IDxcBlob **) __attribute__((stdcall))")]
            public IntPtr CompileWithDebug;
        }
    }
}
