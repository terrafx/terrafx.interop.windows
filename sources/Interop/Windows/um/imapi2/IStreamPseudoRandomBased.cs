// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354145-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IStreamPseudoRandomBased : IStream")]
    [NativeInheritance("IStream")]
    public unsafe partial struct IStreamPseudoRandomBased : IStreamPseudoRandomBased.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, Guid*, void**, int>)(lpVtbl[0]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint>)(lpVtbl[1]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint>)(lpVtbl[2]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, void*, uint, uint*, int>)(lpVtbl[3]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, void*, uint, uint*, int>)(lpVtbl[4]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint, int>)(lpVtbl[8]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Revert()
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, int>)(lpVtbl[9]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, STATSTG*, uint, int>)(lpVtbl[12]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Clone(IStream** ppstm)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, IStream**, int>)(lpVtbl[13]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_Seed([NativeTypeName("ULONG")] uint value)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint, int>)(lpVtbl[14]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_Seed([NativeTypeName("ULONG *")] uint* value)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint*, int>)(lpVtbl[15]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_ExtendedSeed([NativeTypeName("ULONG *")] uint* values, [NativeTypeName("ULONG")] uint eCount)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint*, uint, int>)(lpVtbl[16]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), values, eCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_ExtendedSeed([NativeTypeName("ULONG **")] uint** values, [NativeTypeName("ULONG *")] uint* eCount)
        {
            return ((delegate* unmanaged<IStreamPseudoRandomBased*, uint**, uint*, int>)(lpVtbl[17]))((IStreamPseudoRandomBased*)Unsafe.AsPointer(ref this), values, eCount);
        }

        public interface Interface : IStream.Interface
        {
            [VtblIndex(14)]
            HRESULT put_Seed([NativeTypeName("ULONG")] uint value);

            [VtblIndex(15)]
            HRESULT get_Seed([NativeTypeName("ULONG *")] uint* value);

            [VtblIndex(16)]
            HRESULT put_ExtendedSeed([NativeTypeName("ULONG *")] uint* values, [NativeTypeName("ULONG")] uint eCount);

            [VtblIndex(17)]
            HRESULT get_ExtendedSeed([NativeTypeName("ULONG **")] uint** values, [NativeTypeName("ULONG *")] uint* eCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, uint> Release;

            [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, void*, uint, uint*, int> Read;

            [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, void*, uint, uint*, int> Write;

            [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

            [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, int> SetSize;

            [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> CopyTo;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, uint, int> Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, int> Revert;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> LockRegion;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> UnlockRegion;

            [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, STATSTG*, uint, int> Stat;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, IStream**, int> Clone;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, uint, int> put_Seed;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, uint*, int> get_Seed;

            [NativeTypeName("HRESULT (ULONG *, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, uint*, uint, int> put_ExtendedSeed;

            [NativeTypeName("HRESULT (ULONG **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamPseudoRandomBased*, uint**, uint*, int> get_ExtendedSeed;
        }
    }
}
