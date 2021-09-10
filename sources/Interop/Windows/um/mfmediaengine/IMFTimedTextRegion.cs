// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C8D22AFC-BC47-4BDF-9B04-787E49CE3F58")]
    [NativeTypeName("struct IMFTimedTextRegion : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedTextRegion
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, ushort**, int>)(lpVtbl[3]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPosition(double* pX, double* pY, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[4]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pX, pY, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtent(double* pWidth, double* pHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[5]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pWidth, pHeight, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor(MFARGB* bgColor)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, MFARGB*, int>)(lpVtbl[6]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), bgColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetWritingMode(MF_TIMED_TEXT_WRITING_MODE* writingMode)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_WRITING_MODE*, int>)(lpVtbl[7]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), writingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayAlignment(MF_TIMED_TEXT_DISPLAY_ALIGNMENT* displayAlign)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_DISPLAY_ALIGNMENT*, int>)(lpVtbl[8]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), displayAlign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineHeight(double* pLineHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[9]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), pLineHeight, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipOverflow([NativeTypeName("BOOL *")] int* clipOverflow)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, int*, int>)(lpVtbl[10]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), clipOverflow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetPadding(double* before, double* start, double* after, double* end, MF_TIMED_TEXT_UNIT_TYPE* unitType)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, double*, double*, double*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(lpVtbl[11]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), before, start, after, end, unitType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetWrap([NativeTypeName("BOOL *")] int* wrap)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, int*, int>)(lpVtbl[12]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), wrap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetZIndex([NativeTypeName("INT32 *")] int* zIndex)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, int*, int>)(lpVtbl[13]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), zIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetScrollMode(MF_TIMED_TEXT_SCROLL_MODE* scrollMode)
        {
            return ((delegate* unmanaged<IMFTimedTextRegion*, MF_TIMED_TEXT_SCROLL_MODE*, int>)(lpVtbl[14]))((IMFTimedTextRegion*)Unsafe.AsPointer(ref this), scrollMode);
        }
    }
}
