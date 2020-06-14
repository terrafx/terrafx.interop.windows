// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("678A932C-EA71-4446-9B41-78FDA6280A29")]
    public unsafe partial struct ISpStreamFormatConverter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, Guid*, void**, int>)(lpVtbl[0]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, uint>)(lpVtbl[1]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, uint>)(lpVtbl[2]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, void*, uint, uint*, int>)(lpVtbl[3]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, void*, uint, uint*, int>)(lpVtbl[4]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, uint, int>)(lpVtbl[8]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, int>)(lpVtbl[9]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, STATSTG*, uint, int>)(lpVtbl[12]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, IStream**, int>)(lpVtbl[13]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormat([NativeTypeName("GUID *")] Guid* pguidFormatId, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppCoMemWaveFormatEx)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[14]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBaseStream([NativeTypeName("ISpStreamFormat *")] ISpStreamFormat* pStream, [NativeTypeName("BOOL")] int fSetFormatToBaseStreamFormat, [NativeTypeName("BOOL")] int fWriteToBaseStream)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, ISpStreamFormat*, int, int, int>)(lpVtbl[15]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pStream, fSetFormatToBaseStreamFormat, fWriteToBaseStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBaseStream([NativeTypeName("ISpStreamFormat **")] ISpStreamFormat** ppStream)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, ISpStreamFormat**, int>)(lpVtbl[16]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ppStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFormat([NativeTypeName("const GUID &")] Guid* rguidFormatIdOfConvertedStream, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatExOfConvertedStream)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[17]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), rguidFormatIdOfConvertedStream, pWaveFormatExOfConvertedStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int ResetSeekPosition()
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, int>)(lpVtbl[18]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ScaleConvertedToBaseOffset([NativeTypeName("ULONGLONG")] ulong ullOffsetConvertedStream, [NativeTypeName("ULONGLONG *")] ulong* pullOffsetBaseStream)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, ulong, ulong*, int>)(lpVtbl[19]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ullOffsetConvertedStream, pullOffsetBaseStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int ScaleBaseToConvertedOffset([NativeTypeName("ULONGLONG")] ulong ullOffsetBaseStream, [NativeTypeName("ULONGLONG *")] ulong* pullOffsetConvertedStream)
        {
            return ((delegate* stdcall<ISpStreamFormatConverter*, ulong, ulong*, int>)(lpVtbl[20]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ullOffsetBaseStream, pullOffsetConvertedStream);
        }
    }
}
