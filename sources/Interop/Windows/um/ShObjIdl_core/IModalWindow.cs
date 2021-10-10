// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B4DB1657-70D7-485E-8E3E-6FCB5A5C1802")]
    [NativeTypeName("struct IModalWindow : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IModalWindow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IModalWindow*, Guid*, void**, int>)(lpVtbl[0]))((IModalWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IModalWindow*, uint>)(lpVtbl[1]))((IModalWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IModalWindow*, uint>)(lpVtbl[2]))((IModalWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("HWND")] IntPtr hwndOwner)
        {
            return ((delegate* unmanaged<IModalWindow*, IntPtr, int>)(lpVtbl[3]))((IModalWindow*)Unsafe.AsPointer(ref this), hwndOwner);
        }
    }
}
