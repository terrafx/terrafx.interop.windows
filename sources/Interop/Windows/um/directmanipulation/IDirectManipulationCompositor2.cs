// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D38C7822-F1CB-43CB-B4B9-AC0C767A412E")]
    [NativeTypeName("struct IDirectManipulationCompositor2 : IDirectManipulationCompositor")]
    public unsafe partial struct IDirectManipulationCompositor2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationCompositor2*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationCompositor2*, uint>)(lpVtbl[1]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationCompositor2*, uint>)(lpVtbl[2]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddContent(IDirectManipulationContent* content, IUnknown* device, IUnknown* parentVisual, IUnknown* childVisual)
        {
            return ((delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationContent*, IUnknown*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), content, device, parentVisual, childVisual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveContent(IDirectManipulationContent* content)
        {
            return ((delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationContent*, int>)(lpVtbl[4]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), content);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUpdateManager(IDirectManipulationUpdateManager* updateManager)
        {
            return ((delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationUpdateManager*, int>)(lpVtbl[5]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), updateManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* unmanaged<IDirectManipulationCompositor2*, int>)(lpVtbl[6]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddContentWithCrossProcessChaining(IDirectManipulationPrimaryContent* content, IUnknown* device, IUnknown* parentVisual, IUnknown* childVisual)
        {
            return ((delegate* unmanaged<IDirectManipulationCompositor2*, IDirectManipulationPrimaryContent*, IUnknown*, IUnknown*, IUnknown*, int>)(lpVtbl[7]))((IDirectManipulationCompositor2*)Unsafe.AsPointer(ref this), content, device, parentVisual, childVisual);
        }
    }
}
