// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A3BD1D9-35A9-4FB3-A467-F48CAC35E2D0")]
    [NativeTypeName("struct IHomeGroup : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHomeGroup
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHomeGroup*, Guid*, void**, int>)(lpVtbl[0]))((IHomeGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHomeGroup*, uint>)(lpVtbl[1]))((IHomeGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHomeGroup*, uint>)(lpVtbl[2]))((IHomeGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int IsMember([NativeTypeName("BOOL *")] int* member)
        {
            return ((delegate* unmanaged<IHomeGroup*, int*, int>)(lpVtbl[3]))((IHomeGroup*)Unsafe.AsPointer(ref this), member);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ShowSharingWizard([NativeTypeName("HWND")] IntPtr owner, HOMEGROUPSHARINGCHOICES* sharingchoices)
        {
            return ((delegate* unmanaged<IHomeGroup*, IntPtr, HOMEGROUPSHARINGCHOICES*, int>)(lpVtbl[4]))((IHomeGroup*)Unsafe.AsPointer(ref this), owner, sharingchoices);
        }
    }
}
