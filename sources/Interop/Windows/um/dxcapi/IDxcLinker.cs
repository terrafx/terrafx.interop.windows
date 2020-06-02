// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1B5BE2A-62DD-4327-A1C2-42AC1E1E78E6")]
    public unsafe partial struct IDxcLinker
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcLinker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcLinker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcLinker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterLibrary([NativeTypeName("LPCWSTR")] ushort* pLibName, [NativeTypeName("IDxcBlob *")] IDxcBlob* pLib)
        {
            return lpVtbl->RegisterLibrary((IDxcLinker*)Unsafe.AsPointer(ref this), pLibName, pLib);
        }

        [return: NativeTypeName("HRESULT")]
        public int Link([NativeTypeName("LPCWSTR")] ushort* pEntryName, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("const LPCWSTR *")] ushort** pLibNames, [NativeTypeName("UINT32")] uint libCount, [NativeTypeName("const LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return lpVtbl->Link((IDxcLinker*)Unsafe.AsPointer(ref this), pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLinker*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLinker*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLinker*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IDxcBlob *) __attribute__((thiscall))")]
            public delegate* stdcall<IDxcLinker*, ushort*, IDxcBlob*, int> RegisterLibrary;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, const LPCWSTR *, UINT32, const LPCWSTR *, UINT32, IDxcOperationResult **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcLinker*, ushort*, ushort*, ushort**, uint, ushort**, uint, IDxcOperationResult**, int> Link;
        }
    }
}
