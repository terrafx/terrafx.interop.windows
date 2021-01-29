// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7DCF57AC-18AD-438B-824D-979BFFB74B7C")]
    [NativeTypeName("struct ITfCompartmentMgr : IUnknown")]
    public unsafe partial struct ITfCompartmentMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCompartmentMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfCompartmentMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCompartmentMgr*, uint>)(lpVtbl[1]))((ITfCompartmentMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCompartmentMgr*, uint>)(lpVtbl[2]))((ITfCompartmentMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCompartment([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("ITfCompartment **")] ITfCompartment** ppcomp)
        {
            return ((delegate* unmanaged<ITfCompartmentMgr*, Guid*, ITfCompartment**, int>)(lpVtbl[3]))((ITfCompartmentMgr*)Unsafe.AsPointer(ref this), rguid, ppcomp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearCompartment([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged<ITfCompartmentMgr*, uint, Guid*, int>)(lpVtbl[4]))((ITfCompartmentMgr*)Unsafe.AsPointer(ref this), tid, rguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumCompartments([NativeTypeName("IEnumGUID **")] IEnumGUID** ppEnum)
        {
            return ((delegate* unmanaged<ITfCompartmentMgr*, IEnumGUID**, int>)(lpVtbl[5]))((ITfCompartmentMgr*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
