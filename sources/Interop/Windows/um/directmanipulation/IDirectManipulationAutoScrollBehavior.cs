// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D5954D4-2003-4356-9B31-D051C9FF0AF7")]
    [NativeTypeName("struct IDirectManipulationAutoScrollBehavior : IUnknown")]
    public unsafe partial struct IDirectManipulationAutoScrollBehavior
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationAutoScrollBehavior*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationAutoScrollBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationAutoScrollBehavior*, uint>)(lpVtbl[1]))((IDirectManipulationAutoScrollBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationAutoScrollBehavior*, uint>)(lpVtbl[2]))((IDirectManipulationAutoScrollBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetConfiguration(DIRECTMANIPULATION_MOTION_TYPES motionTypes, DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION scrollMotion)
        {
            return ((delegate* unmanaged[Stdcall]<IDirectManipulationAutoScrollBehavior*, DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION, int>)(lpVtbl[3]))((IDirectManipulationAutoScrollBehavior*)Unsafe.AsPointer(ref this), motionTypes, scrollMotion);
        }
    }
}
