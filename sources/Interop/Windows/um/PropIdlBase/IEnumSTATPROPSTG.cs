// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000139-0000-0000-C000-000000000046")]
    public unsafe partial struct IEnumSTATPROPSTG
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumSTATPROPSTG*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumSTATPROPSTG*, uint>)(lpVtbl[1]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumSTATPROPSTG*, uint>)(lpVtbl[2]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("STATPROPSTG *")] STATPROPSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* stdcall<IEnumSTATPROPSTG*, uint, STATPROPSTG*, uint*, int>)(lpVtbl[3]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* stdcall<IEnumSTATPROPSTG*, uint, int>)(lpVtbl[4]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumSTATPROPSTG*, int>)(lpVtbl[5]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumSTATPROPSTG **")] IEnumSTATPROPSTG** ppenum)
        {
            return ((delegate* stdcall<IEnumSTATPROPSTG*, IEnumSTATPROPSTG**, int>)(lpVtbl[6]))((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
