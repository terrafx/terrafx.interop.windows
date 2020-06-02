// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("LPCWSTR *")]
        public ushort** GetArguments()
        {
            return lpVtbl->GetArguments((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCount()
        {
            return lpVtbl->GetCount((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddArguments([NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount)
        {
            return lpVtbl->AddArguments((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddArgumentsUTF8([NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount)
        {
            return lpVtbl->AddArgumentsUTF8((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddDefines([NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount)
        {
            return lpVtbl->AddDefines((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pDefines, defineCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompilerArgs*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompilerArgs*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompilerArgs*, uint> Release;

            [NativeTypeName("LPCWSTR *() __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompilerArgs*, ushort**> GetArguments;

            [NativeTypeName("UINT32 () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompilerArgs*, uint> GetCount;

            [NativeTypeName("HRESULT (LPCWSTR *, UINT32) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompilerArgs*, ushort**, uint, int> AddArguments;

            [NativeTypeName("HRESULT (LPCSTR *, UINT32) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompilerArgs*, sbyte**, uint, int> AddArgumentsUTF8;

            [NativeTypeName("HRESULT (const DxcDefine *, UINT32) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcCompilerArgs*, DxcDefine*, uint, int> AddDefines;
        }
    }
}
