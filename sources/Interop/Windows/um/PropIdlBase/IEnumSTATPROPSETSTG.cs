// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000013B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumSTATPROPSETSTG : IUnknown")]
    public unsafe partial struct IEnumSTATPROPSETSTG
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, uint>)(lpVtbl[1]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, uint>)(lpVtbl[2]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, STATPROPSETSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, uint, STATPROPSETSTG*, uint*, int>)(lpVtbl[3]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, uint, int>)(lpVtbl[4]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, int>)(lpVtbl[5]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumSTATPROPSETSTG** ppenum)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, IEnumSTATPROPSETSTG**, int>)(lpVtbl[6]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
