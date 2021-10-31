// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E6FDD21A-163F-4975-9C8C-A69F1BA37034")]
    [NativeTypeName("struct IFileDialogCustomize : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFileDialogCustomize
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, Guid*, void**, int>)(lpVtbl[0]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint>)(lpVtbl[1]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint>)(lpVtbl[2]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT EnableOpenDropDown([NativeTypeName("DWORD")] uint dwIDCtl)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, int>)(lpVtbl[3]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddMenu([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int>)(lpVtbl[4]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddPushButton([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int>)(lpVtbl[5]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AddComboBox([NativeTypeName("DWORD")] uint dwIDCtl)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, int>)(lpVtbl[6]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddRadioButtonList([NativeTypeName("DWORD")] uint dwIDCtl)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, int>)(lpVtbl[7]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AddCheckButton([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel, BOOL bChecked)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, BOOL, int>)(lpVtbl[8]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel, bChecked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AddEditBox([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int>)(lpVtbl[9]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT AddSeparator([NativeTypeName("DWORD")] uint dwIDCtl)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, int>)(lpVtbl[10]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT AddText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int>)(lpVtbl[11]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetControlLabel([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int>)(lpVtbl[12]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetControlState([NativeTypeName("DWORD")] uint dwIDCtl, CDCONTROLSTATEF* pdwState)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, CDCONTROLSTATEF*, int>)(lpVtbl[13]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pdwState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetControlState([NativeTypeName("DWORD")] uint dwIDCtl, CDCONTROLSTATEF dwState)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, CDCONTROLSTATEF, int>)(lpVtbl[14]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetEditBoxText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("WCHAR **")] ushort** ppszText)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort**, int>)(lpVtbl[15]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, ppszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetEditBoxText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszText)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int>)(lpVtbl[16]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetCheckButtonState([NativeTypeName("DWORD")] uint dwIDCtl, BOOL* pbChecked)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, BOOL*, int>)(lpVtbl[17]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pbChecked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetCheckButtonState([NativeTypeName("DWORD")] uint dwIDCtl, BOOL bChecked)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, BOOL, int>)(lpVtbl[18]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, bChecked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT AddControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, ushort*, int>)(lpVtbl[19]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem, pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT RemoveControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, int>)(lpVtbl[20]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT RemoveAllControlItems([NativeTypeName("DWORD")] uint dwIDCtl)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, int>)(lpVtbl[21]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetControlItemState([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, CDCONTROLSTATEF* pdwState)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, CDCONTROLSTATEF*, int>)(lpVtbl[22]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem, pdwState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetControlItemState([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, CDCONTROLSTATEF dwState)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, CDCONTROLSTATEF, int>)(lpVtbl[23]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem, dwState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetSelectedControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD *")] uint* pdwIDItem)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint*, int>)(lpVtbl[24]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pdwIDItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetSelectedControlItem([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, int>)(lpVtbl[25]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT StartVisualGroup([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, ushort*, int>)(lpVtbl[26]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT EndVisualGroup()
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, int>)(lpVtbl[27]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT MakeProminent([NativeTypeName("DWORD")] uint dwIDCtl)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, int>)(lpVtbl[28]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SetControlItemText([NativeTypeName("DWORD")] uint dwIDCtl, [NativeTypeName("DWORD")] uint dwIDItem, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileDialogCustomize*, uint, uint, ushort*, int>)(lpVtbl[29]))((IFileDialogCustomize*)Unsafe.AsPointer(ref this), dwIDCtl, dwIDItem, pszLabel);
        }
    }
}
