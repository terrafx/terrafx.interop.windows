// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBF5D3B4-70C7-4163-9322-5A6F660D6FBC")]
    [NativeTypeName("struct IDirectManipulationManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectManipulationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, uint>)(lpVtbl[1]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, uint>)(lpVtbl[2]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr window)
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, IntPtr, int>)(lpVtbl[3]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate([NativeTypeName("HWND")] IntPtr window)
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, IntPtr, int>)(lpVtbl[4]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterHitTestTarget([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("HWND")] IntPtr hitTestWindow, DIRECTMANIPULATION_HITTEST_TYPE type)
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, IntPtr, IntPtr, DIRECTMANIPULATION_HITTEST_TYPE, int>)(lpVtbl[5]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), window, hitTestWindow, type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessInput([NativeTypeName("const MSG *")] MSG* message, [NativeTypeName("BOOL *")] int* handled)
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, MSG*, int*, int>)(lpVtbl[6]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), message, handled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdateManager([NativeTypeName("const IID &")] Guid* riid, void** @object)
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, Guid*, void**, int>)(lpVtbl[7]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreateViewport(IDirectManipulationFrameInfoProvider* frameInfo, [NativeTypeName("HWND")] IntPtr window, [NativeTypeName("const IID &")] Guid* riid, void** @object)
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, IDirectManipulationFrameInfoProvider*, IntPtr, Guid*, void**, int>)(lpVtbl[8]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), frameInfo, window, riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContent(IDirectManipulationFrameInfoProvider* frameInfo, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, void** @object)
        {
            return ((delegate* unmanaged<IDirectManipulationManager*, IDirectManipulationFrameInfoProvider*, Guid*, Guid*, void**, int>)(lpVtbl[9]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), frameInfo, clsid, riid, @object);
        }
    }
}
