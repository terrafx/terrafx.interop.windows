// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Windows.Graphics.Capture.Interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3628E81B-3CAC-4C60-B7F4-23CE0E0C3356")]
    [NativeTypeName("struct IGraphicsCaptureItemInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGraphicsCaptureItemInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, Guid*, void**, int>)(lpVtbl[0]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, uint>)(lpVtbl[1]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, uint>)(lpVtbl[2]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateForWindow([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("const IID &")] Guid* riid, void** result)
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[3]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), window, riid, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateForMonitor([NativeTypeName("HMONITOR")] IntPtr monitor, [NativeTypeName("const IID &")] Guid* riid, void** result)
        {
            return ((delegate* unmanaged<IGraphicsCaptureItemInterop*, IntPtr, Guid*, void**, int>)(lpVtbl[4]))((IGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), monitor, riid, result);
        }
    }
}
