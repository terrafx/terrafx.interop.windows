// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("12E3CCA9-7518-44C5-A5E7-BA5A79CB929E")]
    [NativeTypeName("struct ISpStream : ISpStreamFormat")]
    public unsafe partial struct ISpStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpStream*, uint>)(lpVtbl[1]))((ISpStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpStream*, uint>)(lpVtbl[2]))((ISpStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<ISpStream*, void*, uint, uint*, int>)(lpVtbl[3]))((ISpStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<ISpStream*, void*, uint, uint*, int>)(lpVtbl[4]))((ISpStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<ISpStream*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((ISpStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* unmanaged<ISpStream*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ISpStream*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* unmanaged<ISpStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ISpStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<ISpStream*, uint, int>)(lpVtbl[8]))((ISpStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* unmanaged<ISpStream*, int>)(lpVtbl[9]))((ISpStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<ISpStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((ISpStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<ISpStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((ISpStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<ISpStream*, STATSTG*, uint, int>)(lpVtbl[12]))((ISpStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IStream** ppstm)
        {
            return ((delegate* unmanaged<ISpStream*, IStream**, int>)(lpVtbl[13]))((ISpStream*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormat([NativeTypeName("GUID *")] Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpStream*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[14]))((ISpStream*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBaseStream(IStream* pStream, [NativeTypeName("const GUID &")] Guid* rguidFormat, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpStream*, IStream*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[15]))((ISpStream*)Unsafe.AsPointer(ref this), pStream, rguidFormat, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBaseStream(IStream** ppStream)
        {
            return ((delegate* unmanaged<ISpStream*, IStream**, int>)(lpVtbl[16]))((ISpStream*)Unsafe.AsPointer(ref this), ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BindToFile([NativeTypeName("LPCWSTR")] ushort* pszFileName, SPFILEMODE eMode, [NativeTypeName("const GUID *")] Guid* pFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx, [NativeTypeName("ULONGLONG")] ulong ullEventInterest)
        {
            return ((delegate* unmanaged<ISpStream*, ushort*, SPFILEMODE, Guid*, WAVEFORMATEX*, ulong, int>)(lpVtbl[17]))((ISpStream*)Unsafe.AsPointer(ref this), pszFileName, eMode, pFormatId, pWaveFormatEx, ullEventInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<ISpStream*, int>)(lpVtbl[18]))((ISpStream*)Unsafe.AsPointer(ref this));
        }
    }
}
