// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA1EA135-19DF-11D7-A6D2-00065B84435C")]
    [NativeTypeName("struct ITfUIElementMgr : IUnknown")]
    public unsafe partial struct ITfUIElementMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfUIElementMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfUIElementMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfUIElementMgr*, uint>)(lpVtbl[1]))((ITfUIElementMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfUIElementMgr*, uint>)(lpVtbl[2]))((ITfUIElementMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUIElement(ITfUIElement* pElement, [NativeTypeName("BOOL *")] int* pbShow, [NativeTypeName("DWORD *")] uint* pdwUIElementId)
        {
            return ((delegate* unmanaged<ITfUIElementMgr*, ITfUIElement*, int*, uint*, int>)(lpVtbl[3]))((ITfUIElementMgr*)Unsafe.AsPointer(ref this), pElement, pbShow, pdwUIElementId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateUIElement([NativeTypeName("DWORD")] uint dwUIElementId)
        {
            return ((delegate* unmanaged<ITfUIElementMgr*, uint, int>)(lpVtbl[4]))((ITfUIElementMgr*)Unsafe.AsPointer(ref this), dwUIElementId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndUIElement([NativeTypeName("DWORD")] uint dwUIElementId)
        {
            return ((delegate* unmanaged<ITfUIElementMgr*, uint, int>)(lpVtbl[5]))((ITfUIElementMgr*)Unsafe.AsPointer(ref this), dwUIElementId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUIElement([NativeTypeName("DWORD")] uint dwUIELementId, ITfUIElement** ppElement)
        {
            return ((delegate* unmanaged<ITfUIElementMgr*, uint, ITfUIElement**, int>)(lpVtbl[6]))((ITfUIElementMgr*)Unsafe.AsPointer(ref this), dwUIELementId, ppElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumUIElements(IEnumTfUIElements** ppEnum)
        {
            return ((delegate* unmanaged<ITfUIElementMgr*, IEnumTfUIElements**, int>)(lpVtbl[7]))((ITfUIElementMgr*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
