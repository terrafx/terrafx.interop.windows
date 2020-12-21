// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FA1005E9-3D16-484C-BFC9-62B61E56EC4E")]
    [NativeTypeName("struct IDirectManipulationManager2 : IDirectManipulationManager")]
    public unsafe partial struct IDirectManipulationManager2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, uint>)(lpVtbl[1]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, uint>)(lpVtbl[2]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("HWND")] IntPtr window)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, IntPtr, int>)(lpVtbl[3]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate([NativeTypeName("HWND")] IntPtr window)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, IntPtr, int>)(lpVtbl[4]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterHitTestTarget([NativeTypeName("HWND")] IntPtr window, [NativeTypeName("HWND")] IntPtr hitTestWindow, DIRECTMANIPULATION_HITTEST_TYPE type)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, IntPtr, IntPtr, DIRECTMANIPULATION_HITTEST_TYPE, int>)(lpVtbl[5]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), window, hitTestWindow, type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessInput([NativeTypeName("const MSG *")] MSG* message, [NativeTypeName("BOOL *")] int* handled)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, MSG*, int*, int>)(lpVtbl[6]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), message, handled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdateManager([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, Guid*, void**, int>)(lpVtbl[7]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateViewport([NativeTypeName("IDirectManipulationFrameInfoProvider *")] IDirectManipulationFrameInfoProvider* frameInfo, [NativeTypeName("HWND")] IntPtr window, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, IDirectManipulationFrameInfoProvider*, IntPtr, Guid*, void**, int>)(lpVtbl[8]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), frameInfo, window, riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContent([NativeTypeName("IDirectManipulationFrameInfoProvider *")] IDirectManipulationFrameInfoProvider* frameInfo, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, IDirectManipulationFrameInfoProvider*, Guid*, Guid*, void**, int>)(lpVtbl[9]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), frameInfo, clsid, riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBehavior([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationManager2*, Guid*, Guid*, void**, int>)(lpVtbl[10]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), clsid, riid, @object);
        }
    }
}
