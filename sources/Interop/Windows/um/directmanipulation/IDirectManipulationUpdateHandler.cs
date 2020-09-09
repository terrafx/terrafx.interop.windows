// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("790B6337-64F8-4FF5-A269-B32BC2AF27A7")]
    [NativeTypeName("struct IDirectManipulationUpdateHandler : IUnknown")]
    public unsafe partial struct IDirectManipulationUpdateHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectManipulationUpdateHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationUpdateHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectManipulationUpdateHandler*, uint>)(lpVtbl[1]))((IDirectManipulationUpdateHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectManipulationUpdateHandler*, uint>)(lpVtbl[2]))((IDirectManipulationUpdateHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update()
        {
            return ((delegate* stdcall<IDirectManipulationUpdateHandler*, int>)(lpVtbl[3]))((IDirectManipulationUpdateHandler*)Unsafe.AsPointer(ref this));
        }
    }
}
