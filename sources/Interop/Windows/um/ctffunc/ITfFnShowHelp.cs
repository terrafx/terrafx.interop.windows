// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5AB1D30C-094D-4C29-8EA5-0BF59BE87BF3")]
    [NativeTypeName("struct ITfFnShowHelp : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnShowHelp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnShowHelp*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnShowHelp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnShowHelp*, uint>)(lpVtbl[1]))((ITfFnShowHelp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnShowHelp*, uint>)(lpVtbl[2]))((ITfFnShowHelp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnShowHelp*, ushort**, int>)(lpVtbl[3]))((ITfFnShowHelp*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Show(HWND hwndParent)
        {
            return ((delegate* unmanaged<ITfFnShowHelp*, HWND, int>)(lpVtbl[4]))((ITfFnShowHelp*)Unsafe.AsPointer(ref this), hwndParent);
        }
    }
}
