// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("20168D64-5A8F-4A5A-B7BD-CFA29F4D0FD9")]
    [NativeTypeName("struct ITfComposition : IUnknown")]
    public unsafe partial struct ITfComposition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfComposition*, Guid*, void**, int>)(lpVtbl[0]))((ITfComposition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfComposition*, uint>)(lpVtbl[1]))((ITfComposition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfComposition*, uint>)(lpVtbl[2]))((ITfComposition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRange(ITfRange** ppRange)
        {
            return ((delegate* unmanaged<ITfComposition*, ITfRange**, int>)(lpVtbl[3]))((ITfComposition*)Unsafe.AsPointer(ref this), ppRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftStart([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange* pNewStart)
        {
            return ((delegate* unmanaged<ITfComposition*, uint, ITfRange*, int>)(lpVtbl[4]))((ITfComposition*)Unsafe.AsPointer(ref this), ecWrite, pNewStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShiftEnd([NativeTypeName("TfEditCookie")] uint ecWrite, ITfRange* pNewEnd)
        {
            return ((delegate* unmanaged<ITfComposition*, uint, ITfRange*, int>)(lpVtbl[5]))((ITfComposition*)Unsafe.AsPointer(ref this), ecWrite, pNewEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndComposition([NativeTypeName("TfEditCookie")] uint ecWrite)
        {
            return ((delegate* unmanaged<ITfComposition*, uint, int>)(lpVtbl[6]))((ITfComposition*)Unsafe.AsPointer(ref this), ecWrite);
        }
    }
}
