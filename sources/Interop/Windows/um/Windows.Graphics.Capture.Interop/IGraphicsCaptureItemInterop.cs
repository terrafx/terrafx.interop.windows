// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Windows.Graphics.Capture.Interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3628E81B-3CAC-4C60-B7F4-23CE0E0C3356")]
    [NativeTypeName("struct IGraphicsCaptureItemInterop : IUnknown")]
    public unsafe partial struct IGraphicsCaptureItemInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, Guid*, void**, int>)(lpVtbl[0]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, uint>)(lpVtbl[1]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, uint>)(lpVtbl[2]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateForWindow([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** result)
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[3]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), window, riid, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateForMonitor([NativeTypeName("HMONITOR")] IntPtr monitor, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** result)
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[4]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), monitor, riid, result);
        }
    }
}
