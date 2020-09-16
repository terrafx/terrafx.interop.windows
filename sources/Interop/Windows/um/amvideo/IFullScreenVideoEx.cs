// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IFullScreenVideoEx : IFullScreenVideo")]
    public unsafe partial struct IFullScreenVideoEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, Guid*, void**, int>)(lpVtbl[0]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, uint>)(lpVtbl[1]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, uint>)(lpVtbl[2]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CountModes([NativeTypeName("long *")] int* pModes)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[3]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetModeInfo([NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight, [NativeTypeName("long *")] int* pDepth)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int*, int*, int*, int>)(lpVtbl[4]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode, pWidth, pHeight, pDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentMode([NativeTypeName("long *")] int* pMode)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[5]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsModeAvailable([NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[6]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsModeEnabled([NativeTypeName("long")] int Mode)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[7]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEnabled([NativeTypeName("long")] int Mode, [NativeTypeName("long")] int bEnabled)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int, int>)(lpVtbl[8]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Mode, bEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipFactor([NativeTypeName("long *")] int* pClipFactor)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[9]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pClipFactor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipFactor([NativeTypeName("long")] int ClipFactor)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[10]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), ClipFactor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMessageDrain([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, IntPtr, int>)(lpVtbl[11]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMessageDrain([NativeTypeName("HWND *")] IntPtr* hwnd)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, IntPtr*, int>)(lpVtbl[12]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMonitor([NativeTypeName("long")] int Monitor)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[13]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Monitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMonitor([NativeTypeName("long *")] int* Monitor)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[14]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Monitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HideOnDeactivate([NativeTypeName("long")] int Hide)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[15]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), Hide);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsHideOnDeactivate()
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int>)(lpVtbl[16]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCaption([NativeTypeName("BSTR")] ushort* strCaption)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, ushort*, int>)(lpVtbl[17]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), strCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCaption([NativeTypeName("BSTR *")] ushort** pstrCaption)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, ushort**, int>)(lpVtbl[18]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pstrCaption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefault()
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int>)(lpVtbl[19]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAcceleratorTable([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HACCEL")] IntPtr hAccel)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, IntPtr, IntPtr, int>)(lpVtbl[20]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), hwnd, hAccel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAcceleratorTable([NativeTypeName("HWND *")] IntPtr* phwnd, [NativeTypeName("HACCEL *")] IntPtr* phAccel)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, IntPtr*, IntPtr*, int>)(lpVtbl[21]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), phwnd, phAccel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int KeepPixelAspectRatio([NativeTypeName("long")] int KeepAspect)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int, int>)(lpVtbl[22]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), KeepAspect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsKeepPixelAspectRatio([NativeTypeName("long *")] int* pKeepAspect)
        {
            return ((delegate* unmanaged<IFullScreenVideoEx*, int*, int>)(lpVtbl[23]))((IFullScreenVideoEx*)Unsafe.AsPointer(ref this), pKeepAspect);
        }
    }
}
