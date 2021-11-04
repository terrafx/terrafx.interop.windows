// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IFullScreenVideoEx : IFullScreenVideo")]
    [NativeInheritance("IFullScreenVideo")]
    public unsafe partial struct IFullScreenVideoEx : IFullScreenVideoEx.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, Guid*, void**, int>)(lpVtbl[0]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, uint>)(lpVtbl[1]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, uint>)(lpVtbl[2]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CountModes([NativeTypeName("long *")] int* pModes)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[3]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetModeInfo([NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight, [NativeTypeName("long *")] int* pDepth)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int*, int*, int*, int>)(lpVtbl[4]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode, pWidth, pHeight, pDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCurrentMode([NativeTypeName("long *")] int* pMode)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[5]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsModeAvailable([NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[6]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsModeEnabled([NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[7]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetEnabled([NativeTypeName("long")] int Mode, [NativeTypeName("long")] int bEnabled)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int, int>)(lpVtbl[8]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode, bEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[9]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pClipFactor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetClipFactor([NativeTypeName("long")] int ClipFactor)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[10]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), ClipFactor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetMessageDrain(HWND hwnd)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, HWND, int>)(lpVtbl[11]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetMessageDrain(HWND* hwnd)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, HWND*, int>)(lpVtbl[12]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetMonitor([NativeTypeName("long")] int Monitor)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[13]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Monitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetMonitor([NativeTypeName("long *")] int* Monitor)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[14]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Monitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT HideOnDeactivate([NativeTypeName("long")] int Hide)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[15]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Hide);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT IsHideOnDeactivate()
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int>)(lpVtbl[16]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, ushort*, int>)(lpVtbl[17]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), strCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, ushort**, int>)(lpVtbl[18]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pstrCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetDefault()
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int>)(lpVtbl[19]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetAcceleratorTable(HWND hwnd, HACCEL hAccel)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, HWND, HACCEL, int>)(lpVtbl[20]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd, hAccel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetAcceleratorTable(HWND* phwnd, HACCEL* phAccel)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, HWND*, HACCEL*, int>)(lpVtbl[21]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), phwnd, phAccel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT KeepPixelAspectRatio([NativeTypeName("long")] int KeepAspect)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[22]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), KeepAspect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT IsKeepPixelAspectRatio([NativeTypeName("long *")] int* pKeepAspect)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[23]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pKeepAspect);
        }

        public interface Interface : IFullScreenVideo.Interface
        {
            [VtblIndex(20)]
            HRESULT SetAcceleratorTable(HWND hwnd, HACCEL hAccel);

            [VtblIndex(21)]
            HRESULT GetAcceleratorTable(HWND* phwnd, HACCEL* phAccel);

            [VtblIndex(22)]
            HRESULT KeepPixelAspectRatio([NativeTypeName("long")] int KeepAspect);

            [VtblIndex(23)]
            HRESULT IsKeepPixelAspectRatio([NativeTypeName("long *")] int* pKeepAspect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, uint> Release;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int*, int> CountModes;

            [NativeTypeName("HRESULT (long, long *, long *, long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int, int*, int*, int*, int> GetModeInfo;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int*, int> GetCurrentMode;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int, int> IsModeAvailable;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int, int> IsModeEnabled;

            [NativeTypeName("HRESULT (long, long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int, int, int> SetEnabled;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int*, int> GetClipFactor;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int, int> SetClipFactor;

            [NativeTypeName("HRESULT (HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, HWND, int> SetMessageDrain;

            [NativeTypeName("HRESULT (HWND *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, HWND*, int> GetMessageDrain;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int, int> SetMonitor;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int*, int> GetMonitor;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int, int> HideOnDeactivate;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int> IsHideOnDeactivate;

            [NativeTypeName("HRESULT (BSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, ushort*, int> SetCaption;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, ushort**, int> GetCaption;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int> SetDefault;

            [NativeTypeName("HRESULT (HWND, HACCEL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, HWND, HACCEL, int> SetAcceleratorTable;

            [NativeTypeName("HRESULT (HWND *, HACCEL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, HWND*, HACCEL*, int> GetAcceleratorTable;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int, int> KeepPixelAspectRatio;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideoEx*, int*, int> IsKeepPixelAspectRatio;
        }
    }
}
