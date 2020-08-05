// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000105-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumSTATDATA : IUnknown")]
    public unsafe partial struct IEnumSTATDATA
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumSTATDATA*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumSTATDATA*, uint>)(lpVtbl[1]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumSTATDATA*, uint>)(lpVtbl[2]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("STATDATA *")] STATDATA* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* stdcall<IEnumSTATDATA*, uint, STATDATA*, uint*, int>)(lpVtbl[3]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* stdcall<IEnumSTATDATA*, uint, int>)(lpVtbl[4]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumSTATDATA*, int>)(lpVtbl[5]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenum)
        {
            return ((delegate* stdcall<IEnumSTATDATA*, IEnumSTATDATA**, int>)(lpVtbl[6]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
