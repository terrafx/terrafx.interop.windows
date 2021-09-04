// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7EBFDD85-AD18-11D3-A4C5-00C04F72D6B8")]
    [NativeTypeName("struct IEnumTravelLogEntry : IUnknown")]
    public unsafe partial struct IEnumTravelLogEntry
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTravelLogEntry*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTravelLogEntry*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTravelLogEntry*, uint>)(lpVtbl[1]))((IEnumTravelLogEntry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTravelLogEntry*, uint>)(lpVtbl[2]))((IEnumTravelLogEntry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cElt, ITravelLogEntry** rgElt, [NativeTypeName("ULONG *")] uint* pcEltFetched)
        {
            return ((delegate* unmanaged<IEnumTravelLogEntry*, uint, ITravelLogEntry**, uint*, int>)(lpVtbl[3]))((IEnumTravelLogEntry*)Unsafe.AsPointer(ref this), cElt, rgElt, pcEltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cElt)
        {
            return ((delegate* unmanaged<IEnumTravelLogEntry*, uint, int>)(lpVtbl[4]))((IEnumTravelLogEntry*)Unsafe.AsPointer(ref this), cElt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTravelLogEntry*, int>)(lpVtbl[5]))((IEnumTravelLogEntry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTravelLogEntry** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTravelLogEntry*, IEnumTravelLogEntry**, int>)(lpVtbl[6]))((IEnumTravelLogEntry*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
