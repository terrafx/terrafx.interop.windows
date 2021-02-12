// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354145-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IStreamPseudoRandomBased : IStream")]
    public unsafe partial struct IStreamPseudoRandomBased
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, Guid*, void**, int>)(lpVtbl[0]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint>)(lpVtbl[1]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint>)(lpVtbl[2]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, void*, uint, uint*, int>)(lpVtbl[3]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, void*, uint, uint*, int>)(lpVtbl[4]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint, int>)(lpVtbl[8]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, int>)(lpVtbl[9]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, STATSTG*, uint, int>)(lpVtbl[12]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, IStream**, int>)(lpVtbl[13]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Seed([NativeTypeName("ULONG")] uint value)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint, int>)(lpVtbl[14]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Seed([NativeTypeName("ULONG *")] uint* value)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint*, int>)(lpVtbl[15]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ExtendedSeed([NativeTypeName("ULONG *")] uint* values, [NativeTypeName("ULONG")] uint eCount)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint*, uint, int>)(lpVtbl[16]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), values, eCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExtendedSeed([NativeTypeName("ULONG **")] uint** values, [NativeTypeName("ULONG *")] uint* eCount)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint**, uint*, int>)(lpVtbl[17]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), values, eCount);
        }
    }
}
