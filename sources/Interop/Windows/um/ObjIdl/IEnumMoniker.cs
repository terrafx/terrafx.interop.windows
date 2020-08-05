// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000102-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumMoniker : IUnknown")]
    public unsafe partial struct IEnumMoniker
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IEnumMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumMoniker*, uint>)(lpVtbl[1]))((IEnumMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumMoniker*, uint>)(lpVtbl[2]))((IEnumMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("IMoniker **")] IMoniker** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* stdcall<IEnumMoniker*, uint, IMoniker**, uint*, int>)(lpVtbl[3]))((IEnumMoniker*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* stdcall<IEnumMoniker*, uint, int>)(lpVtbl[4]))((IEnumMoniker*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumMoniker*, int>)(lpVtbl[5]))((IEnumMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenum)
        {
            return ((delegate* stdcall<IEnumMoniker*, IEnumMoniker**, int>)(lpVtbl[6]))((IEnumMoniker*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
