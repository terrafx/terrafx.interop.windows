// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBF5D3B4-70C7-4163-9322-5A6F660D6FBC")]
    [NativeTypeName("struct IDirectManipulationManager : IUnknown")]
    public unsafe partial struct IDirectManipulationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectManipulationManager*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectManipulationManager*, uint>)(lpVtbl[1]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectManipulationManager*, uint>)(lpVtbl[2]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr window)
        {
            return ((delegate* stdcall<IDirectManipulationManager*, IntPtr, int>)(lpVtbl[3]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate([NativeTypeName("HWND")] IntPtr window)
        {
            return ((delegate* stdcall<IDirectManipulationManager*, IntPtr, int>)(lpVtbl[4]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterHitTestTarget([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("HWND")] IntPtr hitTestWindow, DIRECTMANIPULATION_HITTEST_TYPE type)
        {
            return ((delegate* stdcall<IDirectManipulationManager*, IntPtr, IntPtr, DIRECTMANIPULATION_HITTEST_TYPE, int>)(lpVtbl[5]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), window, hitTestWindow, type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessInput([NativeTypeName("const MSG *")] MSG* message, [NativeTypeName("BOOL *")] int* handled)
        {
            return ((delegate* stdcall<IDirectManipulationManager*, MSG*, int*, int>)(lpVtbl[6]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), message, handled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdateManager([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* stdcall<IDirectManipulationManager*, Guid*, void**, int>)(lpVtbl[7]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateViewport([NativeTypeName("IDirectManipulationFrameInfoProvider *")] IDirectManipulationFrameInfoProvider* frameInfo, [NativeTypeName("HWND")] IntPtr window, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* stdcall<IDirectManipulationManager*, IDirectManipulationFrameInfoProvider*, IntPtr, Guid*, void**, int>)(lpVtbl[8]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), frameInfo, window, riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContent([NativeTypeName("IDirectManipulationFrameInfoProvider *")] IDirectManipulationFrameInfoProvider* frameInfo, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* stdcall<IDirectManipulationManager*, IDirectManipulationFrameInfoProvider*, Guid*, Guid*, void**, int>)(lpVtbl[9]))((IDirectManipulationManager*)Unsafe.AsPointer(ref this), frameInfo, clsid, riid, @object);
        }
    }
}
