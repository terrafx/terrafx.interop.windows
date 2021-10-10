// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C0F1DB0C-3A20-405C-A303-96B6010A885F")]
    [NativeTypeName("struct ITfThreadFocusSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfThreadFocusSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, uint>)(lpVtbl[1]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, uint>)(lpVtbl[2]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetThreadFocus()
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, int>)(lpVtbl[3]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnKillThreadFocus()
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, int>)(lpVtbl[4]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
        }
    }
}
