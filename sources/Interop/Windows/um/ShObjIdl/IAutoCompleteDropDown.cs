// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3CD141F4-3C6A-11D2-BCAA-00C04FD929DB")]
    [NativeTypeName("struct IAutoCompleteDropDown : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAutoCompleteDropDown
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAutoCompleteDropDown*, Guid*, void**, int>)(lpVtbl[0]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAutoCompleteDropDown*, uint>)(lpVtbl[1]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAutoCompleteDropDown*, uint>)(lpVtbl[2]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDropDownStatus([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPWSTR *")] ushort** ppwszString)
        {
            return ((delegate* unmanaged<IAutoCompleteDropDown*, uint*, ushort**, int>)(lpVtbl[3]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this), pdwFlags, ppwszString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ResetEnumerator()
        {
            return ((delegate* unmanaged<IAutoCompleteDropDown*, int>)(lpVtbl[4]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this));
        }
    }
}
