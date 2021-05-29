// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E2CD3A4B-AF25-4D3D-9110-DA0E6F8EE877")]
    [NativeTypeName("struct IMFSourceBuffer : IUnknown")]
    public unsafe partial struct IMFSourceBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, uint>)(lpVtbl[1]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, uint>)(lpVtbl[2]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetUpdating()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, int>)(lpVtbl[3]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffered(IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, IMFMediaTimeRange**, int>)(lpVtbl[4]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetTimeStampOffset()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double>)(lpVtbl[5]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimeStampOffset(double offset)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double, int>)(lpVtbl[6]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetAppendWindowStart()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double>)(lpVtbl[7]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppendWindowStart(double time)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double, int>)(lpVtbl[8]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetAppendWindowEnd()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double>)(lpVtbl[9]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppendWindowEnd(double time)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double, int>)(lpVtbl[10]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Append([NativeTypeName("const BYTE *")] byte* pData, [NativeTypeName("DWORD")] uint len)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, byte*, uint, int>)(lpVtbl[11]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), pData, len);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendByteStream(IMFByteStream* pStream, [NativeTypeName("DWORDLONG *")] ulong* pMaxLen)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)(lpVtbl[12]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), pStream, pMaxLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, int>)(lpVtbl[13]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove(double start, double end)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double, double, int>)(lpVtbl[14]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), start, end);
        }
    }
}
