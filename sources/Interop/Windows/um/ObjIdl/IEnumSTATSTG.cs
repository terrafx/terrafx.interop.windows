// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000D-0000-0000-C000-000000000046")]
    public unsafe partial struct IEnumSTATSTG
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumSTATSTG*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSTATSTG*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumSTATSTG*, uint>)(lpVtbl[1]))((IEnumSTATSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumSTATSTG*, uint>)(lpVtbl[2]))((IEnumSTATSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("STATSTG *")] STATSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* stdcall<IEnumSTATSTG*, uint, STATSTG*, uint*, int>)(lpVtbl[3]))((IEnumSTATSTG*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* stdcall<IEnumSTATSTG*, uint, int>)(lpVtbl[4]))((IEnumSTATSTG*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumSTATSTG*, int>)(lpVtbl[5]))((IEnumSTATSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumSTATSTG **")] IEnumSTATSTG** ppenum)
        {
            return ((delegate* stdcall<IEnumSTATSTG*, IEnumSTATSTG**, int>)(lpVtbl[6]))((IEnumSTATSTG*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
