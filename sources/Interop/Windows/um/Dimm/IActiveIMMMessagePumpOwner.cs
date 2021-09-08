// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B5CF2CFA-8AEB-11D1-9364-0060B067B86E")]
    [NativeTypeName("struct IActiveIMMMessagePumpOwner : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IActiveIMMMessagePumpOwner
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, Guid*, void**, int>)(lpVtbl[0]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, uint>)(lpVtbl[1]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, uint>)(lpVtbl[2]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, int>)(lpVtbl[3]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int End()
        {
            return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, int>)(lpVtbl[4]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int OnTranslateMessage([NativeTypeName("const MSG *")] MSG* pMsg)
        {
            return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, MSG*, int>)(lpVtbl[5]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this), pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Pause([NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, uint*, int>)(lpVtbl[6]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this), pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Resume([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IActiveIMMMessagePumpOwner*, uint, int>)(lpVtbl[7]))((IActiveIMMMessagePumpOwner*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
