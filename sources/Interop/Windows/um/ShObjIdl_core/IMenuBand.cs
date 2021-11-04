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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMenuBand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMenuBand*, Guid*, void**, int>)(lpVtbl[0]))((IMenuBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMenuBand*, uint>)(lpVtbl[1]))((IMenuBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMenuBand*, uint>)(lpVtbl[2]))((IMenuBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT IsMenuMessage(MSG* pmsg)
        {
            return ((delegate* unmanaged<IMenuBand*, MSG*, int>)(lpVtbl[3]))((IMenuBand*)Unsafe.AsPointer(ref this), pmsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT TranslateMenuMessage(MSG* pmsg, LRESULT* plRet)
        {
            return ((delegate* unmanaged<IMenuBand*, MSG*, LRESULT*, int>)(lpVtbl[4]))((IMenuBand*)Unsafe.AsPointer(ref this), pmsg, plRet);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMenuBand*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMenuBand*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMenuBand*, uint> Release;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMenuBand*, MSG*, int> IsMenuMessage;

            [NativeTypeName("HRESULT (MSG *, LRESULT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMenuBand*, MSG*, LRESULT*, int> TranslateMenuMessage;
        }
    }
}
