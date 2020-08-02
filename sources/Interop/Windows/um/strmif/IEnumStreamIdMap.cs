// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("945C1566-6202-46FC-96C7-D87F289C6534")]
    public unsafe partial struct IEnumStreamIdMap
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumStreamIdMap*, Guid*, void**, int>)(lpVtbl[0]))((IEnumStreamIdMap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumStreamIdMap*, uint>)(lpVtbl[1]))((IEnumStreamIdMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumStreamIdMap*, uint>)(lpVtbl[2]))((IEnumStreamIdMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("STREAM_ID_MAP *")] STREAM_ID_MAP* pStreamIdMap, [NativeTypeName("ULONG *")] uint* pcReceived)
        {
            return ((delegate* stdcall<IEnumStreamIdMap*, uint, STREAM_ID_MAP*, uint*, int>)(lpVtbl[3]))((IEnumStreamIdMap*)Unsafe.AsPointer(ref this), cRequest, pStreamIdMap, pcReceived);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cRecords)
        {
            return ((delegate* stdcall<IEnumStreamIdMap*, uint, int>)(lpVtbl[4]))((IEnumStreamIdMap*)Unsafe.AsPointer(ref this), cRecords);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumStreamIdMap*, int>)(lpVtbl[5]))((IEnumStreamIdMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumStreamIdMap **")] IEnumStreamIdMap** ppIEnumStreamIdMap)
        {
            return ((delegate* stdcall<IEnumStreamIdMap*, IEnumStreamIdMap**, int>)(lpVtbl[6]))((IEnumStreamIdMap*)Unsafe.AsPointer(ref this), ppIEnumStreamIdMap);
        }
    }
}
