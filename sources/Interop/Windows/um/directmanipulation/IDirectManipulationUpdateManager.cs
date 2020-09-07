// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B0AE62FD-BE34-46E7-9CAA-D361FACBB9CC")]
    [NativeTypeName("struct IDirectManipulationUpdateManager : IUnknown")]
    public unsafe partial struct IDirectManipulationUpdateManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectManipulationUpdateManager*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectManipulationUpdateManager*, uint>)(lpVtbl[1]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectManipulationUpdateManager*, uint>)(lpVtbl[2]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterWaitHandleCallback([NativeTypeName("HANDLE")] IntPtr handle, [NativeTypeName("IDirectManipulationUpdateHandler *")] IDirectManipulationUpdateHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
        {
            return ((delegate* stdcall<IDirectManipulationUpdateManager*, IntPtr, IDirectManipulationUpdateHandler*, uint*, int>)(lpVtbl[3]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), handle, eventHandler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterWaitHandleCallback([NativeTypeName("DWORD")] uint cookie)
        {
            return ((delegate* stdcall<IDirectManipulationUpdateManager*, uint, int>)(lpVtbl[4]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("IDirectManipulationFrameInfoProvider *")] IDirectManipulationFrameInfoProvider* frameInfo)
        {
            return ((delegate* stdcall<IDirectManipulationUpdateManager*, IDirectManipulationFrameInfoProvider*, int>)(lpVtbl[5]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), frameInfo);
        }
    }
}
