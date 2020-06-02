// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE2CD79F-CC22-453F-9B6B-B124E7A5204C")]
    public unsafe partial struct IDxcOptimizerPass
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionName([NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return lpVtbl->GetOptionName((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return lpVtbl->GetDescription((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return lpVtbl->GetOptionArgCount((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgName([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return lpVtbl->GetOptionArgName((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgDescription([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return lpVtbl->GetOptionArgDescription((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizerPass*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizerPass*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizerPass*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizerPass*, ushort**, int> GetOptionName;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizerPass*, ushort**, int> GetDescription;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizerPass*, uint*, int> GetOptionArgCount;

            [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizerPass*, uint, ushort**, int> GetOptionArgName;

            [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcOptimizerPass*, uint, ushort**, int> GetOptionArgDescription;
        }
    }
}
