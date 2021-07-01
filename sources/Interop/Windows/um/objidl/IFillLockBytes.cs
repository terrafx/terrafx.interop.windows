// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("99CAF010-415E-11CF-8814-00AA00B569F5")]
    [NativeTypeName("struct IFillLockBytes : IUnknown")]
    public unsafe partial struct IFillLockBytes
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFillLockBytes*, Guid*, void**, int>)(lpVtbl[0]))((IFillLockBytes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFillLockBytes*, uint>)(lpVtbl[1]))((IFillLockBytes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFillLockBytes*, uint>)(lpVtbl[2]))((IFillLockBytes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FillAppend([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IFillLockBytes*, void*, uint, uint*, int>)(lpVtbl[3]))((IFillLockBytes*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FillAt(ULARGE_INTEGER ulOffset, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IFillLockBytes*, ULARGE_INTEGER, void*, uint, uint*, int>)(lpVtbl[4]))((IFillLockBytes*)Unsafe.AsPointer(ref this), ulOffset, pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFillSize(ULARGE_INTEGER ulSize)
        {
            return ((delegate* unmanaged<IFillLockBytes*, ULARGE_INTEGER, int>)(lpVtbl[5]))((IFillLockBytes*)Unsafe.AsPointer(ref this), ulSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("BOOL")] int bCanceled)
        {
            return ((delegate* unmanaged<IFillLockBytes*, int, int>)(lpVtbl[6]))((IFillLockBytes*)Unsafe.AsPointer(ref this), bCanceled);
        }
    }
}
