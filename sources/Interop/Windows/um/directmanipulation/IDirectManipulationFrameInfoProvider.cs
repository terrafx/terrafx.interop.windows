// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FB759DBA-6F4C-4C01-874E-19C8A05907F9")]
    [NativeTypeName("struct IDirectManipulationFrameInfoProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectManipulationFrameInfoProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider*, uint>)(lpVtbl[1]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider*, uint>)(lpVtbl[2]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetNextFrameInfo([NativeTypeName("ULONGLONG *")] ulong* time, [NativeTypeName("ULONGLONG *")] ulong* processTime, [NativeTypeName("ULONGLONG *")] ulong* compositionTime)
        {
            return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider*, ulong*, ulong*, ulong*, int>)(lpVtbl[3]))((IDirectManipulationFrameInfoProvider*)Unsafe.AsPointer(ref this), time, processTime, compositionTime);
        }
    }
}
