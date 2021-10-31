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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSourceBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, uint>)(lpVtbl[1]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, uint>)(lpVtbl[2]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public BOOL GetUpdating()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, int>)(lpVtbl[3]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetBuffered(IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, IMFMediaTimeRange**, int>)(lpVtbl[4]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public double GetTimeStampOffset()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double>)(lpVtbl[5]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetTimeStampOffset(double offset)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double, int>)(lpVtbl[6]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public double GetAppendWindowStart()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double>)(lpVtbl[7]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetAppendWindowStart(double time)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double, int>)(lpVtbl[8]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public double GetAppendWindowEnd()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double>)(lpVtbl[9]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetAppendWindowEnd(double time)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double, int>)(lpVtbl[10]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Append([NativeTypeName("const BYTE *")] byte* pData, [NativeTypeName("DWORD")] uint len)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, byte*, uint, int>)(lpVtbl[11]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), pData, len);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AppendByteStream(IMFByteStream* pStream, [NativeTypeName("DWORDLONG *")] ulong* pMaxLen)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)(lpVtbl[12]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), pStream, pMaxLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Abort()
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, int>)(lpVtbl[13]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Remove(double start, double end)
        {
            return ((delegate* unmanaged<IMFSourceBuffer*, double, double, int>)(lpVtbl[14]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), start, end);
        }
    }
}
