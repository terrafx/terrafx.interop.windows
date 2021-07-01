// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9E5530C5-7034-48B4-BB46-0B8A6EFC8E36")]
    [NativeTypeName("struct IVMRFilterConfig : IUnknown")]
    public unsafe partial struct IVMRFilterConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, Guid*, void**, int>)(lpVtbl[0]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint>)(lpVtbl[1]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint>)(lpVtbl[2]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetImageCompositor(IVMRImageCompositor* lpVMRImgCompositor)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, IVMRImageCompositor*, int>)(lpVtbl[3]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), lpVMRImgCompositor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNumberOfStreams([NativeTypeName("DWORD")] uint dwMaxStreams)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint, int>)(lpVtbl[4]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), dwMaxStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwMaxStreams)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint*, int>)(lpVtbl[5]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), pdwMaxStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint, int>)(lpVtbl[6]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderingPrefs([NativeTypeName("DWORD *")] uint* pdwRenderFlags)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint*, int>)(lpVtbl[7]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), pdwRenderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderingMode([NativeTypeName("DWORD")] uint Mode)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint, int>)(lpVtbl[8]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderingMode([NativeTypeName("DWORD *")] uint* pMode)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint*, int>)(lpVtbl[9]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), pMode);
        }
    }
}
