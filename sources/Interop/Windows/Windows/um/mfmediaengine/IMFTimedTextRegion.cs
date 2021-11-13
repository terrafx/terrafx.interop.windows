// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0")]
    [Guid("C8D22AFC-BC47-4BDF-9B04-787E49CE3F58")]
    [NativeTypeName("struct IMFTimedTextRegion : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedTextRegion : IMFTimedTextRegion.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, uint>)(lpVtbl[1]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, uint>)(lpVtbl[2]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, ushort**, int>)(lpVtbl[3]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPosition(double* pX, double* pY, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[4]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pX, pY, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetExtent(double* pWidth, double* pHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[5]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pWidth, pHeight, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetBackgroundColor(MFARGB* bgColor)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, MFARGB*, int>)(lpVtbl[6]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), bgColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetWritingMode(MF_TIMED_TEXT_WRITING_MODE* writingMode)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_WRITING_MODE*, int>)(lpVtbl[7]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), writingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetDisplayAlignment(MF_TIMED_TEXT_DISPLAY_ALIGNMENT* displayAlign)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_DISPLAY_ALIGNMENT*, int>)(lpVtbl[8]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), displayAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetLineHeight(double* pLineHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[9]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pLineHeight, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetClipOverflow(BOOL* clipOverflow)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, BOOL*, int>)(lpVtbl[10]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), clipOverflow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetPadding(double* before, double* start, double* after, double* end, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, double*, double*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[11]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), before, start, after, end, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetWrap(BOOL* wrap)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, BOOL*, int>)(lpVtbl[12]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), wrap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetZIndex([NativeTypeName("INT32 *")] int* zIndex)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, int*, int>)(lpVtbl[13]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), zIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetScrollMode(MF_TIMED_TEXT_SCROLL_MODE* scrollMode)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_SCROLL_MODE*, int>)(lpVtbl[14]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), scrollMode);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

            [VtblIndex(4)]
            HRESULT GetPosition(double* pX, double* pY, MF_TIMED_TEXT_UNIT_TYPE* unitType);

            [VtblIndex(5)]
            HRESULT GetExtent(double* pWidth, double* pHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType);

            [VtblIndex(6)]
            HRESULT GetBackgroundColor(MFARGB* bgColor);

            [VtblIndex(7)]
            HRESULT GetWritingMode(MF_TIMED_TEXT_WRITING_MODE* writingMode);

            [VtblIndex(8)]
            HRESULT GetDisplayAlignment(MF_TIMED_TEXT_DISPLAY_ALIGNMENT* displayAlign);

            [VtblIndex(9)]
            HRESULT GetLineHeight(double* pLineHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType);

            [VtblIndex(10)]
            HRESULT GetClipOverflow(BOOL* clipOverflow);

            [VtblIndex(11)]
            HRESULT GetPadding(double* before, double* start, double* after, double* end, MF_TIMED_TEXT_UNIT_TYPE* unitType);

            [VtblIndex(12)]
            HRESULT GetWrap(BOOL* wrap);

            [VtblIndex(13)]
            HRESULT GetZIndex([NativeTypeName("INT32 *")] int* zIndex);

            [VtblIndex(14)]
            HRESULT GetScrollMode(MF_TIMED_TEXT_SCROLL_MODE* scrollMode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, ushort**, int> GetName;

            [NativeTypeName("HRESULT (double *, double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int> GetPosition;

            [NativeTypeName("HRESULT (double *, double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int> GetExtent;

            [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, MFARGB*, int> GetBackgroundColor;

            [NativeTypeName("HRESULT (MF_TIMED_TEXT_WRITING_MODE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_WRITING_MODE*, int> GetWritingMode;

            [NativeTypeName("HRESULT (MF_TIMED_TEXT_DISPLAY_ALIGNMENT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_DISPLAY_ALIGNMENT*, int> GetDisplayAlignment;

            [NativeTypeName("HRESULT (double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int> GetLineHeight;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, BOOL*, int> GetClipOverflow;

            [NativeTypeName("HRESULT (double *, double *, double *, double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, double*, double*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int> GetPadding;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, BOOL*, int> GetWrap;

            [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, int*, int> GetZIndex;

            [NativeTypeName("HRESULT (MF_TIMED_TEXT_SCROLL_MODE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_SCROLL_MODE*, int> GetScrollMode;
        }
    }
}
