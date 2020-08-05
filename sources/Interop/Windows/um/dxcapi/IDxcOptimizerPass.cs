// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE2CD79F-CC22-453F-9B6B-B124E7A5204C")]
    [NativeTypeName("struct IDxcOptimizerPass : IUnknown")]
    public unsafe partial struct IDxcOptimizerPass
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcOptimizerPass*, Guid*, void**, int>)(lpVtbl[0]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcOptimizerPass*, uint>)(lpVtbl[1]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcOptimizerPass*, uint>)(lpVtbl[2]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionName([NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return ((delegate* stdcall<IDxcOptimizerPass*, ushort**, int>)(lpVtbl[3]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return ((delegate* stdcall<IDxcOptimizerPass*, ushort**, int>)(lpVtbl[4]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return ((delegate* stdcall<IDxcOptimizerPass*, uint*, int>)(lpVtbl[5]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), pCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgName([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return ((delegate* stdcall<IDxcOptimizerPass*, uint, ushort**, int>)(lpVtbl[6]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgDescription([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return ((delegate* stdcall<IDxcOptimizerPass*, uint, ushort**, int>)(lpVtbl[7]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
        }
    }
}
