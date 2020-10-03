// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000104-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumOLEVERB : IUnknown")]
    public unsafe partial struct IEnumOLEVERB
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumOLEVERB*, Guid*, void**, int>)(lpVtbl[0]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumOLEVERB*, uint>)(lpVtbl[1]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumOLEVERB*, uint>)(lpVtbl[2]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLEVERB")] OLEVERB* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumOLEVERB*, uint, OLEVERB*, uint*, int>)(lpVtbl[3]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumOLEVERB*, uint, int>)(lpVtbl[4]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumOLEVERB*, int>)(lpVtbl[5]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppenum)
        {
            return ((delegate* unmanaged<IEnumOLEVERB*, IEnumOLEVERB**, int>)(lpVtbl[6]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
