// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("99EACBA7-E073-43B6-A896-55AFE48A0833")]
    [NativeTypeName("struct IContactManagerInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IContactManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContactManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IContactManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContactManagerInterop*, uint>)(lpVtbl[1]))((IContactManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContactManagerInterop*, uint>)(lpVtbl[2]))((IContactManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ShowContactCardForWindow([NativeTypeName("HWND")] IntPtr appWindow, IUnknown* contact, [NativeTypeName("const RECT *")] RECT* selection, FLYOUT_PLACEMENT preferredPlacement)
        {
            return ((delegate* unmanaged<IContactManagerInterop*, IntPtr, IUnknown*, RECT*, FLYOUT_PLACEMENT, int>)(lpVtbl[3]))((IContactManagerInterop*)Unsafe.AsPointer(ref this), appWindow, contact, selection, preferredPlacement);
        }
    }
}
