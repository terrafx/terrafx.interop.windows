// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8895B1C6-B41F-4C1C-A562-0D564250836F")]
    [NativeTypeName("struct IPreviewHandler : IUnknown")]
    public unsafe partial struct IPreviewHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPreviewHandler*, Guid*, void**, int>)(lpVtbl[0]))((IPreviewHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPreviewHandler*, uint>)(lpVtbl[1]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPreviewHandler*, uint>)(lpVtbl[2]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("const RECT *")] RECT* prc)
        {
            return ((delegate* unmanaged<IPreviewHandler*, IntPtr, RECT*, int>)(lpVtbl[3]))((IPreviewHandler*)Unsafe.AsPointer(ref this), hwnd, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRect([NativeTypeName("const RECT *")] RECT* prc)
        {
            return ((delegate* unmanaged<IPreviewHandler*, RECT*, int>)(lpVtbl[4]))((IPreviewHandler*)Unsafe.AsPointer(ref this), prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoPreview()
        {
            return ((delegate* unmanaged<IPreviewHandler*, int>)(lpVtbl[5]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unload()
        {
            return ((delegate* unmanaged<IPreviewHandler*, int>)(lpVtbl[6]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFocus()
        {
            return ((delegate* unmanaged<IPreviewHandler*, int>)(lpVtbl[7]))((IPreviewHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryFocus([NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return ((delegate* unmanaged<IPreviewHandler*, IntPtr*, int>)(lpVtbl[8]))((IPreviewHandler*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorW(MSG* pmsg)
        {
            return ((delegate* unmanaged<IPreviewHandler*, MSG*, int>)(lpVtbl[9]))((IPreviewHandler*)Unsafe.AsPointer(ref this), pmsg);
        }
    }
}
