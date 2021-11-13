// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("25297D5C-3AD4-4C9C-B5CF-E36A38512330")]
    [NativeTypeName("struct ICompositorInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICompositorInterop : ICompositorInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICompositorInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositorInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICompositorInterop*, uint>)(lpVtbl[1]))((ICompositorInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICompositorInterop*, uint>)(lpVtbl[2]))((ICompositorInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateCompositionSurfaceForHandle(HANDLE swapChain, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] void** result)
        {
            return ((delegate* unmanaged<ICompositorInterop*, HANDLE, void**, int>)(lpVtbl[3]))((ICompositorInterop*)Unsafe.AsPointer(ref this), swapChain, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateCompositionSurfaceForSwapChain(IUnknown* swapChain, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] void** result)
        {
            return ((delegate* unmanaged<ICompositorInterop*, IUnknown*, void**, int>)(lpVtbl[4]))((ICompositorInterop*)Unsafe.AsPointer(ref this), swapChain, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateGraphicsDevice(IUnknown* renderingDevice, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGraphicsDevice **")] void** result)
        {
            return ((delegate* unmanaged<ICompositorInterop*, IUnknown*, void**, int>)(lpVtbl[5]))((ICompositorInterop*)Unsafe.AsPointer(ref this), renderingDevice, result);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateCompositionSurfaceForHandle(HANDLE swapChain, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] void** result);

            [VtblIndex(4)]
            HRESULT CreateCompositionSurfaceForSwapChain(IUnknown* swapChain, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")] void** result);

            [VtblIndex(5)]
            HRESULT CreateGraphicsDevice(IUnknown* renderingDevice, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGraphicsDevice **")] void** result);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICompositorInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICompositorInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICompositorInterop*, uint> Release;

            [NativeTypeName("HRESULT (HANDLE, ABI::Windows::UI::Composition::ICompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ICompositorInterop*, HANDLE, void**, int> CreateCompositionSurfaceForHandle;

            [NativeTypeName("HRESULT (IUnknown *, ABI::Windows::UI::Composition::ICompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ICompositorInterop*, IUnknown*, void**, int> CreateCompositionSurfaceForSwapChain;

            [NativeTypeName("HRESULT (IUnknown *, ABI::Windows::UI::Composition::ICompositionGraphicsDevice **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ICompositorInterop*, IUnknown*, void**, int> CreateGraphicsDevice;
        }
    }
}
