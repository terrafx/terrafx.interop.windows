// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36B73880-C2C8-11CF-8B46-00805F6CEF60")]
    [NativeTypeName("struct IMediaSeeking : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMediaSeeking : IMediaSeeking.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaSeeking*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSeeking*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaSeeking*, uint>)(lpVtbl[1]))((IMediaSeeking*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaSeeking*, uint>)(lpVtbl[2]))((IMediaSeeking*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pCapabilities)
        {
            return ((delegate* unmanaged<IMediaSeeking*, uint*, int>)(lpVtbl[3]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CheckCapabilities([NativeTypeName("DWORD *")] uint* pCapabilities)
        {
            return ((delegate* unmanaged<IMediaSeeking*, uint*, int>)(lpVtbl[4]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT IsFormatSupported([NativeTypeName("const GUID *")] Guid* pFormat)
        {
            return ((delegate* unmanaged<IMediaSeeking*, Guid*, int>)(lpVtbl[5]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT QueryPreferredFormat(Guid* pFormat)
        {
            return ((delegate* unmanaged<IMediaSeeking*, Guid*, int>)(lpVtbl[6]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetTimeFormat(Guid* pFormat)
        {
            return ((delegate* unmanaged<IMediaSeeking*, Guid*, int>)(lpVtbl[7]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT IsUsingTimeFormat([NativeTypeName("const GUID *")] Guid* pFormat)
        {
            return ((delegate* unmanaged<IMediaSeeking*, Guid*, int>)(lpVtbl[8]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetTimeFormat([NativeTypeName("const GUID *")] Guid* pFormat)
        {
            return ((delegate* unmanaged<IMediaSeeking*, Guid*, int>)(lpVtbl[9]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDuration([NativeTypeName("LONGLONG *")] long* pDuration)
        {
            return ((delegate* unmanaged<IMediaSeeking*, long*, int>)(lpVtbl[10]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStopPosition([NativeTypeName("LONGLONG *")] long* pStop)
        {
            return ((delegate* unmanaged<IMediaSeeking*, long*, int>)(lpVtbl[11]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetCurrentPosition([NativeTypeName("LONGLONG *")] long* pCurrent)
        {
            return ((delegate* unmanaged<IMediaSeeking*, long*, int>)(lpVtbl[12]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT ConvertTimeFormat([NativeTypeName("LONGLONG *")] long* pTarget, [NativeTypeName("const GUID *")] Guid* pTargetFormat, [NativeTypeName("LONGLONG")] long Source, [NativeTypeName("const GUID *")] Guid* pSourceFormat)
        {
            return ((delegate* unmanaged<IMediaSeeking*, long*, Guid*, long, Guid*, int>)(lpVtbl[13]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pTarget, pTargetFormat, Source, pSourceFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetPositions([NativeTypeName("LONGLONG *")] long* pCurrent, [NativeTypeName("DWORD")] uint dwCurrentFlags, [NativeTypeName("LONGLONG *")] long* pStop, [NativeTypeName("DWORD")] uint dwStopFlags)
        {
            return ((delegate* unmanaged<IMediaSeeking*, long*, uint, long*, uint, int>)(lpVtbl[14]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCurrent, dwCurrentFlags, pStop, dwStopFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetPositions([NativeTypeName("LONGLONG *")] long* pCurrent, [NativeTypeName("LONGLONG *")] long* pStop)
        {
            return ((delegate* unmanaged<IMediaSeeking*, long*, long*, int>)(lpVtbl[15]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pCurrent, pStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetAvailable([NativeTypeName("LONGLONG *")] long* pEarliest, [NativeTypeName("LONGLONG *")] long* pLatest)
        {
            return ((delegate* unmanaged<IMediaSeeking*, long*, long*, int>)(lpVtbl[16]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pEarliest, pLatest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetRate(double dRate)
        {
            return ((delegate* unmanaged<IMediaSeeking*, double, int>)(lpVtbl[17]))((IMediaSeeking*)Unsafe.AsPointer(ref this), dRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetRate(double* pdRate)
        {
            return ((delegate* unmanaged<IMediaSeeking*, double*, int>)(lpVtbl[18]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pdRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetPreroll([NativeTypeName("LONGLONG *")] long* pllPreroll)
        {
            return ((delegate* unmanaged<IMediaSeeking*, long*, int>)(lpVtbl[19]))((IMediaSeeking*)Unsafe.AsPointer(ref this), pllPreroll);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pCapabilities);

            [VtblIndex(4)]
            HRESULT CheckCapabilities([NativeTypeName("DWORD *")] uint* pCapabilities);

            [VtblIndex(5)]
            HRESULT IsFormatSupported([NativeTypeName("const GUID *")] Guid* pFormat);

            [VtblIndex(6)]
            HRESULT QueryPreferredFormat(Guid* pFormat);

            [VtblIndex(7)]
            HRESULT GetTimeFormat(Guid* pFormat);

            [VtblIndex(8)]
            HRESULT IsUsingTimeFormat([NativeTypeName("const GUID *")] Guid* pFormat);

            [VtblIndex(9)]
            HRESULT SetTimeFormat([NativeTypeName("const GUID *")] Guid* pFormat);

            [VtblIndex(10)]
            HRESULT GetDuration([NativeTypeName("LONGLONG *")] long* pDuration);

            [VtblIndex(11)]
            HRESULT GetStopPosition([NativeTypeName("LONGLONG *")] long* pStop);

            [VtblIndex(12)]
            HRESULT GetCurrentPosition([NativeTypeName("LONGLONG *")] long* pCurrent);

            [VtblIndex(13)]
            HRESULT ConvertTimeFormat([NativeTypeName("LONGLONG *")] long* pTarget, [NativeTypeName("const GUID *")] Guid* pTargetFormat, [NativeTypeName("LONGLONG")] long Source, [NativeTypeName("const GUID *")] Guid* pSourceFormat);

            [VtblIndex(14)]
            HRESULT SetPositions([NativeTypeName("LONGLONG *")] long* pCurrent, [NativeTypeName("DWORD")] uint dwCurrentFlags, [NativeTypeName("LONGLONG *")] long* pStop, [NativeTypeName("DWORD")] uint dwStopFlags);

            [VtblIndex(15)]
            HRESULT GetPositions([NativeTypeName("LONGLONG *")] long* pCurrent, [NativeTypeName("LONGLONG *")] long* pStop);

            [VtblIndex(16)]
            HRESULT GetAvailable([NativeTypeName("LONGLONG *")] long* pEarliest, [NativeTypeName("LONGLONG *")] long* pLatest);

            [VtblIndex(17)]
            HRESULT SetRate(double dRate);

            [VtblIndex(18)]
            HRESULT GetRate(double* pdRate);

            [VtblIndex(19)]
            HRESULT GetPreroll([NativeTypeName("LONGLONG *")] long* pllPreroll);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, uint*, int> GetCapabilities;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, uint*, int> CheckCapabilities;

            [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, Guid*, int> IsFormatSupported;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, Guid*, int> QueryPreferredFormat;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, Guid*, int> GetTimeFormat;

            [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, Guid*, int> IsUsingTimeFormat;

            [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, Guid*, int> SetTimeFormat;

            [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, long*, int> GetDuration;

            [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, long*, int> GetStopPosition;

            [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, long*, int> GetCurrentPosition;

            [NativeTypeName("HRESULT (LONGLONG *, const GUID *, LONGLONG, const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, long*, Guid*, long, Guid*, int> ConvertTimeFormat;

            [NativeTypeName("HRESULT (LONGLONG *, DWORD, LONGLONG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, long*, uint, long*, uint, int> SetPositions;

            [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, long*, long*, int> GetPositions;

            [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, long*, long*, int> GetAvailable;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, double, int> SetRate;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, double*, int> GetRate;

            [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaSeeking*, long*, int> GetPreroll;
        }
    }
}
