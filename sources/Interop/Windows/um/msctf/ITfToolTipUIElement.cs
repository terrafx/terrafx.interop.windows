// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("52B18B5C-555D-46B2-B00A-FA680144FBDB")]
    [NativeTypeName("struct ITfToolTipUIElement : ITfUIElement")]
    public unsafe partial struct ITfToolTipUIElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfToolTipUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfToolTipUIElement*, uint>)(lpVtbl[1]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfToolTipUIElement*, uint>)(lpVtbl[2]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
        {
            return ((delegate* unmanaged<ITfToolTipUIElement*, ushort**, int>)(lpVtbl[3]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfToolTipUIElement*, Guid*, int>)(lpVtbl[4]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int bShow)
        {
            return ((delegate* unmanaged<ITfToolTipUIElement*, int, int>)(lpVtbl[5]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), bShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsShown([NativeTypeName("BOOL *")] int* pbShow)
        {
            return ((delegate* unmanaged<ITfToolTipUIElement*, int*, int>)(lpVtbl[6]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), pbShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("BSTR *")] ushort** pstr)
        {
            return ((delegate* unmanaged<ITfToolTipUIElement*, ushort**, int>)(lpVtbl[7]))((ITfToolTipUIElement*)Unsafe.AsPointer(ref this), pstr);
        }
    }
}
