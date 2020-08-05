// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000148-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IAddrExclusionControl : IUnknown")]
    public unsafe partial struct IAddrExclusionControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAddrExclusionControl*, Guid*, void**, int>)(lpVtbl[0]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAddrExclusionControl*, uint>)(lpVtbl[1]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAddrExclusionControl*, uint>)(lpVtbl[2]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentAddrExclusionList([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppEnumerator)
        {
            return ((delegate* stdcall<IAddrExclusionControl*, Guid*, void**, int>)(lpVtbl[3]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this), riid, ppEnumerator);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateAddrExclusionList([NativeTypeName("IUnknown *")] IUnknown* pEnumerator)
        {
            return ((delegate* stdcall<IAddrExclusionControl*, IUnknown*, int>)(lpVtbl[4]))((IAddrExclusionControl*)Unsafe.AsPointer(ref this), pEnumerator);
        }
    }
}
