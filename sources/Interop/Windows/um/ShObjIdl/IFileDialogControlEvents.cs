// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36116642-D713-4B97-9B83-7484A9D00433")]
    [NativeTypeName("struct IFileDialogControlEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFileDialogControlEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileDialogControlEvents*, Guid*, void**, int>)(lpVtbl[0]))((IFileDialogControlEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileDialogControlEvents*, uint>)(lpVtbl[1]))((IFileDialogControlEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileDialogControlEvents*, uint>)(lpVtbl[2]))((IFileDialogControlEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnItemSelected(IFileDialogCustomize* pfdc, [NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem)
        {
            return ((delegate* unmanaged<IFileDialogControlEvents*, IFileDialogCustomize*, uint, uint, int>)(lpVtbl[3]))((IFileDialogControlEvents*)Unsafe.AsPointer(ref this), pfdc, dwIDCtl, dwIDItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnButtonClicked(IFileDialogCustomize* pfdc, [NativeTypeName("DWORD")] uint dwIDCtl)
        {
            return ((delegate* unmanaged<IFileDialogControlEvents*, IFileDialogCustomize*, uint, int>)(lpVtbl[4]))((IFileDialogControlEvents*)Unsafe.AsPointer(ref this), pfdc, dwIDCtl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnCheckButtonToggled(IFileDialogCustomize* pfdc, [NativeTypeName("DWORD")] uint dwIDCtl, BOOL bChecked)
        {
            return ((delegate* unmanaged<IFileDialogControlEvents*, IFileDialogCustomize*, uint, BOOL, int>)(lpVtbl[5]))((IFileDialogControlEvents*)Unsafe.AsPointer(ref this), pfdc, dwIDCtl, bChecked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnControlActivating(IFileDialogCustomize* pfdc, [NativeTypeName("DWORD")] uint dwIDCtl)
        {
            return ((delegate* unmanaged<IFileDialogControlEvents*, IFileDialogCustomize*, uint, int>)(lpVtbl[6]))((IFileDialogControlEvents*)Unsafe.AsPointer(ref this), pfdc, dwIDCtl);
        }
    }
}
