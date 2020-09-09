// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B89962CB-3D89-442B-BB58-5098FA0F9F16")]
    [NativeTypeName("struct IDirectManipulationContent : IUnknown")]
    public unsafe partial struct IDirectManipulationContent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectManipulationContent*, uint>)(lpVtbl[1]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectManipulationContent*, uint>)(lpVtbl[2]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContentRect([NativeTypeName("RECT *")] RECT* contentSize)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, RECT*, int>)(lpVtbl[3]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), contentSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContentRect([NativeTypeName("const RECT *")] RECT* contentSize)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, RECT*, int>)(lpVtbl[4]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), contentSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewport([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, Guid*, void**, int>)(lpVtbl[5]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), riid, @object);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTag([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** @object, [NativeTypeName("UINT32 *")] uint* id)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, Guid*, void**, uint*, int>)(lpVtbl[6]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), riid, @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTag([NativeTypeName("IUnknown *")] IUnknown* @object, [NativeTypeName("UINT32")] uint id)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, IUnknown*, uint, int>)(lpVtbl[7]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), @object, id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputTransform([NativeTypeName("float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, float*, uint, int>)(lpVtbl[8]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), matrix, pointCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContentTransform([NativeTypeName("float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, float*, uint, int>)(lpVtbl[9]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), matrix, pointCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SyncContentTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
        {
            return ((delegate* stdcall<IDirectManipulationContent*, float*, uint, int>)(lpVtbl[10]))((IDirectManipulationContent*)Unsafe.AsPointer(ref this), matrix, pointCount);
        }
    }
}
