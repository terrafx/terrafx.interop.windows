// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IFullScreenVideo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFullScreenVideo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, Guid*, void**, int>)(lpVtbl[0]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFullScreenVideo*, uint>)(lpVtbl[1]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFullScreenVideo*, uint>)(lpVtbl[2]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CountModes([NativeTypeName("long *")] int* pModes)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int*, int>)(lpVtbl[3]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetModeInfo([NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight, [NativeTypeName("long *")] int* pDepth)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int, int*, int*, int*, int>)(lpVtbl[4]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode, pWidth, pHeight, pDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCurrentMode([NativeTypeName("long *")] int* pMode)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int*, int>)(lpVtbl[5]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsModeAvailable([NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int, int>)(lpVtbl[6]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsModeEnabled([NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int, int>)(lpVtbl[7]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetEnabled([NativeTypeName("long")] int Mode, [NativeTypeName("long")] int bEnabled)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int, int, int>)(lpVtbl[8]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Mode, bEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int*, int>)(lpVtbl[9]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pClipFactor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetClipFactor([NativeTypeName("long")] int ClipFactor)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int, int>)(lpVtbl[10]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), ClipFactor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetMessageDrain(HWND hwnd)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, HWND, int>)(lpVtbl[11]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetMessageDrain(HWND* hwnd)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, HWND*, int>)(lpVtbl[12]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetMonitor([NativeTypeName("long")] int Monitor)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int, int>)(lpVtbl[13]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Monitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetMonitor([NativeTypeName("long *")] int* Monitor)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int*, int>)(lpVtbl[14]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Monitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT HideOnDeactivate([NativeTypeName("long")] int Hide)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int, int>)(lpVtbl[15]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), Hide);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT IsHideOnDeactivate()
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int>)(lpVtbl[16]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, ushort*, int>)(lpVtbl[17]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), strCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
        {
            return ((delegate* unmanaged<IFullScreenVideo*, ushort**, int>)(lpVtbl[18]))((IFullScreenVideo*)Unsafe.AsPointer(ref this), pstrCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetDefault()
        {
            return ((delegate* unmanaged<IFullScreenVideo*, int>)(lpVtbl[19]))((IFullScreenVideo*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, uint> Release;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int*, int> CountModes;

            [NativeTypeName("HRESULT (long, long *, long *, long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int, int*, int*, int*, int> GetModeInfo;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int*, int> GetCurrentMode;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int, int> IsModeAvailable;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int, int> IsModeEnabled;

            [NativeTypeName("HRESULT (long, long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int, int, int> SetEnabled;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int*, int> GetClipFactor;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int, int> SetClipFactor;

            [NativeTypeName("HRESULT (HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, HWND, int> SetMessageDrain;

            [NativeTypeName("HRESULT (HWND *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, HWND*, int> GetMessageDrain;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int, int> SetMonitor;

            [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int*, int> GetMonitor;

            [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int, int> HideOnDeactivate;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int> IsHideOnDeactivate;

            [NativeTypeName("HRESULT (BSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, ushort*, int> SetCaption;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, ushort**, int> GetCaption;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IFullScreenVideo*, int> SetDefault;
        }
    }
}
