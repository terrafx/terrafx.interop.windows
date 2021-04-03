// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56988052-47DA-4A05-911A-E3D941F17145")]
    [NativeTypeName("struct IEnumTfLatticeElements : IUnknown")]
    public unsafe partial struct IEnumTfLatticeElements
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfLatticeElements*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfLatticeElements*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfLatticeElements*, uint>)(lpVtbl[1]))((IEnumTfLatticeElements*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfLatticeElements*, uint>)(lpVtbl[2]))((IEnumTfLatticeElements*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfLatticeElements** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfLatticeElements*, IEnumTfLatticeElements**, int>)(lpVtbl[3]))((IEnumTfLatticeElements*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, TF_LMLATTELEMENT* rgsElements, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfLatticeElements*, uint, TF_LMLATTELEMENT*, uint*, int>)(lpVtbl[4]))((IEnumTfLatticeElements*)Unsafe.AsPointer(ref this), ulCount, rgsElements, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfLatticeElements*, int>)(lpVtbl[5]))((IEnumTfLatticeElements*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfLatticeElements*, uint, int>)(lpVtbl[6]))((IEnumTfLatticeElements*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
