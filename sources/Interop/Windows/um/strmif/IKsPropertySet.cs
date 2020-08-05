// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("31EFAC30-515C-11D0-A9AA-00AA0061BE93")]
    [NativeTypeName("struct IKsPropertySet : IUnknown")]
    public unsafe partial struct IKsPropertySet
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IKsPropertySet*, Guid*, void**, int>)(lpVtbl[0]))((IKsPropertySet*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IKsPropertySet*, uint>)(lpVtbl[1]))((IKsPropertySet*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IKsPropertySet*, uint>)(lpVtbl[2]))((IKsPropertySet*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Set([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("LPVOID")] void* pInstanceData, [NativeTypeName("DWORD")] uint cbInstanceData, [NativeTypeName("LPVOID")] void* pPropData, [NativeTypeName("DWORD")] uint cbPropData)
        {
            return ((delegate* stdcall<IKsPropertySet*, Guid*, uint, void*, uint, void*, uint, int>)(lpVtbl[3]))((IKsPropertySet*)Unsafe.AsPointer(ref this), guidPropSet, dwPropID, pInstanceData, cbInstanceData, pPropData, cbPropData);
        }

        [return: NativeTypeName("HRESULT")]
        public int Get([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("LPVOID")] void* pInstanceData, [NativeTypeName("DWORD")] uint cbInstanceData, [NativeTypeName("LPVOID")] void* pPropData, [NativeTypeName("DWORD")] uint cbPropData, [NativeTypeName("DWORD *")] uint* pcbReturned)
        {
            return ((delegate* stdcall<IKsPropertySet*, Guid*, uint, void*, uint, void*, uint, uint*, int>)(lpVtbl[4]))((IKsPropertySet*)Unsafe.AsPointer(ref this), guidPropSet, dwPropID, pInstanceData, cbInstanceData, pPropData, cbPropData, pcbReturned);
        }

        [return: NativeTypeName("HRESULT")]
        public int QuerySupported([NativeTypeName("const GUID &")] Guid* guidPropSet, [NativeTypeName("DWORD")] uint dwPropID, [NativeTypeName("DWORD *")] uint* pTypeSupport)
        {
            return ((delegate* stdcall<IKsPropertySet*, Guid*, uint, uint*, int>)(lpVtbl[5]))((IKsPropertySet*)Unsafe.AsPointer(ref this), guidPropSet, dwPropID, pTypeSupport);
        }
    }
}
