// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25297D5C-3AD4-4C9C-B5CF-E36A38512330")]
    public unsafe partial struct ICompositorInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICompositorInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositorInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICompositorInterop*, uint>)(lpVtbl[1]))((ICompositorInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICompositorInterop*, uint>)(lpVtbl[2]))((ICompositorInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompositionSurfaceForHandle([NativeTypeName("HANDLE")] IntPtr swapChain, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] void** result)
        {
            return ((delegate* stdcall<ICompositorInterop*, IntPtr, void**, int>)(lpVtbl[3]))((ICompositorInterop*)Unsafe.AsPointer(ref this), swapChain, result);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompositionSurfaceForSwapChain([NativeTypeName("IUnknown *")] IUnknown* swapChain, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] void** result)
        {
            return ((delegate* stdcall<ICompositorInterop*, IUnknown*, void**, int>)(lpVtbl[4]))((ICompositorInterop*)Unsafe.AsPointer(ref this), swapChain, result);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGraphicsDevice([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGraphicsDevice **")] void** result)
        {
            return ((delegate* stdcall<ICompositorInterop*, IUnknown*, void**, int>)(lpVtbl[5]))((ICompositorInterop*)Unsafe.AsPointer(ref this), renderingDevice, result);
        }
    }
}
