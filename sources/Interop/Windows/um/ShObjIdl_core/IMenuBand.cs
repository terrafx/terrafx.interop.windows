// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("568804CD-CBD7-11D0-9816-00C04FD91972")]
    [NativeTypeName("struct IMenuBand : IUnknown")]
    public unsafe partial struct IMenuBand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMenuBand*, Guid*, void**, int>)(lpVtbl[0]))((IMenuBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMenuBand*, uint>)(lpVtbl[1]))((IMenuBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMenuBand*, uint>)(lpVtbl[2]))((IMenuBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsMenuMessage(MSG* pmsg)
        {
            return ((delegate* unmanaged<IMenuBand*, MSG*, int>)(lpVtbl[3]))((IMenuBand*)Unsafe.AsPointer(ref this), pmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateMenuMessage(MSG* pmsg, [NativeTypeName("LRESULT *")] nint* plRet)
        {
            return ((delegate* unmanaged<IMenuBand*, MSG*, nint*, int>)(lpVtbl[4]))((IMenuBand*)Unsafe.AsPointer(ref this), pmsg, plRet);
        }
    }
}
