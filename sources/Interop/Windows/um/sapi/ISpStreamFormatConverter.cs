// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("678A932C-EA71-4446-9B41-78FDA6280A29")]
    [NativeTypeName("struct ISpStreamFormatConverter : ISpStreamFormat")]
    [NativeInheritance("ISpStreamFormat")]
    public unsafe partial struct ISpStreamFormatConverter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, Guid*, void**, int>)(lpVtbl[0]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, uint>)(lpVtbl[1]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, uint>)(lpVtbl[2]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, void*, uint, uint*, int>)(lpVtbl[3]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, void*, uint, uint*, int>)(lpVtbl[4]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, uint, int>)(lpVtbl[8]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Revert()
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, int>)(lpVtbl[9]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, STATSTG*, uint, int>)(lpVtbl[12]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Clone(IStream** ppstm)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, IStream**, int>)(lpVtbl[13]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetFormat([NativeTypeName("GUID *")] Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[14]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetBaseStream(ISpStreamFormat* pStream, BOOL fSetFormatToBaseStreamFormat, BOOL fWriteToBaseStream)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, ISpStreamFormat*, BOOL, BOOL, int>)(lpVtbl[15]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pStream, fSetFormatToBaseStreamFormat, fWriteToBaseStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetBaseStream(ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, ISpStreamFormat**, int>)(lpVtbl[16]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetFormat([NativeTypeName("const GUID &")] Guid* rguidFormatIdOfConvertedStream, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatExOfConvertedStream)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[17]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), rguidFormatIdOfConvertedStream, pWaveFormatExOfConvertedStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT ResetSeekPosition()
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, int>)(lpVtbl[18]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT ScaleConvertedToBaseOffset([NativeTypeName("ULONGLONG")] ulong ullOffsetConvertedStream, [NativeTypeName("ULONGLONG *")] ulong* pullOffsetBaseStream)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, ulong, ulong*, int>)(lpVtbl[19]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ullOffsetConvertedStream, pullOffsetBaseStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT ScaleBaseToConvertedOffset([NativeTypeName("ULONGLONG")] ulong ullOffsetBaseStream, [NativeTypeName("ULONGLONG *")] ulong* pullOffsetConvertedStream)
        {
            return ((delegate* unmanaged<ISpStreamFormatConverter*, ulong, ulong*, int>)(lpVtbl[20]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ullOffsetBaseStream, pullOffsetConvertedStream);
        }
    }
}
