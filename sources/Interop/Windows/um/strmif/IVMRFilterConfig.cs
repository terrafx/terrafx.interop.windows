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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVMRFilterConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, Guid*, void**, int>)(lpVtbl[0]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint>)(lpVtbl[1]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint>)(lpVtbl[2]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetImageCompositor(IVMRImageCompositor* lpVMRImgCompositor)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, IVMRImageCompositor*, int>)(lpVtbl[3]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), lpVMRImgCompositor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetNumberOfStreams([NativeTypeName("DWORD")] uint dwMaxStreams)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint, int>)(lpVtbl[4]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), dwMaxStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwMaxStreams)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint*, int>)(lpVtbl[5]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), pdwMaxStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint, int>)(lpVtbl[6]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetRenderingPrefs([NativeTypeName("DWORD *")] uint* pdwRenderFlags)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint*, int>)(lpVtbl[7]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), pdwRenderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetRenderingMode([NativeTypeName("DWORD")] uint Mode)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint, int>)(lpVtbl[8]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), Mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetRenderingMode([NativeTypeName("DWORD *")] uint* pMode)
        {
            return ((delegate* unmanaged<IVMRFilterConfig*, uint*, int>)(lpVtbl[9]))((IVMRFilterConfig*)Unsafe.AsPointer(ref this), pMode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, uint> Release;

            [NativeTypeName("HRESULT (IVMRImageCompositor *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, IVMRImageCompositor*, int> SetImageCompositor;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, uint, int> SetNumberOfStreams;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, uint*, int> GetNumberOfStreams;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, uint, int> SetRenderingPrefs;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, uint*, int> GetRenderingPrefs;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, uint, int> SetRenderingMode;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVMRFilterConfig*, uint*, int> GetRenderingMode;
        }
    }
}
