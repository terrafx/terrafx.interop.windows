// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B3E7C340-EF97-11CE-9BC9-00AA00608E01")]
    [NativeTypeName("struct IEnumOleUndoUnits : IUnknown")]
    public unsafe partial struct IEnumOleUndoUnits
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumOleUndoUnits*, Guid*, void**, int>)(lpVtbl[0]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumOleUndoUnits*, uint>)(lpVtbl[1]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumOleUndoUnits*, uint>)(lpVtbl[2]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cElt, IOleUndoUnit** rgElt, [NativeTypeName("ULONG *")] uint* pcEltFetched)
        {
            return ((delegate* unmanaged<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int>)(lpVtbl[3]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), cElt, rgElt, pcEltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cElt)
        {
            return ((delegate* unmanaged<IEnumOleUndoUnits*, uint, int>)(lpVtbl[4]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), cElt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumOleUndoUnits*, int>)(lpVtbl[5]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumOleUndoUnits** ppEnum)
        {
            return ((delegate* unmanaged<IEnumOleUndoUnits*, IEnumOleUndoUnits**, int>)(lpVtbl[6]))((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
