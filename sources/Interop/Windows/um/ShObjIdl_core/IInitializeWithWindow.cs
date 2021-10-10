// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3E68D4BD-7135-4D10-8018-9FB6D9F33FA1")]
    [NativeTypeName("struct IInitializeWithWindow : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInitializeWithWindow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInitializeWithWindow*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeWithWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInitializeWithWindow*, uint>)(lpVtbl[1]))((IInitializeWithWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInitializeWithWindow*, uint>)(lpVtbl[2]))((IInitializeWithWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<IInitializeWithWindow*, IntPtr, int>)(lpVtbl[3]))((IInitializeWithWindow*)Unsafe.AsPointer(ref this), hwnd);
        }
    }
}
