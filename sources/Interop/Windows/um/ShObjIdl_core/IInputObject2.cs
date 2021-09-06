// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6915C085-510B-44CD-94AF-28DFA56CF92B")]
    [NativeTypeName("struct IInputObject2 : IInputObject")]
    public unsafe partial struct IInputObject2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInputObject2*, Guid*, void**, int>)(lpVtbl[0]))((IInputObject2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInputObject2*, uint>)(lpVtbl[1]))((IInputObject2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInputObject2*, uint>)(lpVtbl[2]))((IInputObject2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UIActivateIO([NativeTypeName("BOOL")] int fActivate, MSG* pMsg)
        {
            return ((delegate* unmanaged<IInputObject2*, int, MSG*, int>)(lpVtbl[3]))((IInputObject2*)Unsafe.AsPointer(ref this), fActivate, pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasFocusIO()
        {
            return ((delegate* unmanaged<IInputObject2*, int>)(lpVtbl[4]))((IInputObject2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorIO(MSG* pMsg)
        {
            return ((delegate* unmanaged<IInputObject2*, MSG*, int>)(lpVtbl[5]))((IInputObject2*)Unsafe.AsPointer(ref this), pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorGlobal(MSG* pMsg)
        {
            return ((delegate* unmanaged<IInputObject2*, MSG*, int>)(lpVtbl[6]))((IInputObject2*)Unsafe.AsPointer(ref this), pMsg);
        }
    }
}
