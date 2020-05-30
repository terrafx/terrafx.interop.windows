// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler repository (https://github.com/microsoft/DirectXShaderCompiler/) at commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73EFFE2A-70DC-45F8-9690-EFF64C02429D")]
    public unsafe partial struct IDxcCompilerArgs
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcCompilerArgs* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcCompilerArgs* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcCompilerArgs* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("LPCWSTR *")]
        public delegate ushort** _GetArguments(IDxcCompilerArgs* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetCount(IDxcCompilerArgs* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddArguments(IDxcCompilerArgs* pThis, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddArgumentsUTF8(IDxcCompilerArgs* pThis, [NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddDefines(IDxcCompilerArgs* pThis, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPCWSTR *")]
        public ushort** GetArguments()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetArguments>(lpVtbl->GetArguments)((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddArguments([NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddArguments>(lpVtbl->AddArguments)((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddArgumentsUTF8([NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddArgumentsUTF8>(lpVtbl->AddArgumentsUTF8)((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddDefines([NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddDefines>(lpVtbl->AddDefines)((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pDefines, defineCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("LPCWSTR *() __attribute__((stdcall))")]
            public IntPtr GetArguments;

            [NativeTypeName("UINT32 () __attribute__((stdcall))")]
            public IntPtr GetCount;

            [NativeTypeName("HRESULT (LPCWSTR *, UINT32) __attribute__((stdcall))")]
            public IntPtr AddArguments;

            [NativeTypeName("HRESULT (LPCSTR *, UINT32) __attribute__((stdcall))")]
            public IntPtr AddArgumentsUTF8;

            [NativeTypeName("HRESULT (const DxcDefine *, UINT32) __attribute__((stdcall))")]
            public IntPtr AddDefines;
        }
    }
}
