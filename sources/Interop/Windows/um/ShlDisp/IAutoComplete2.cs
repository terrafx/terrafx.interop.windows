// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EAC04BC0-3791-11D2-BB95-0060977B464C")]
    [NativeTypeName("struct IAutoComplete2 : IAutoComplete")]
    [NativeInheritance("IAutoComplete")]
    public unsafe partial struct IAutoComplete2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAutoComplete2*, Guid*, void**, int>)(lpVtbl[0]))((IAutoComplete2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAutoComplete2*, uint>)(lpVtbl[1]))((IAutoComplete2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAutoComplete2*, uint>)(lpVtbl[2]))((IAutoComplete2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Init([NativeTypeName("HWND")] IntPtr hwndEdit, IUnknown* punkACL, [NativeTypeName("LPCWSTR")] ushort* pwszRegKeyPath, [NativeTypeName("LPCWSTR")] ushort* pwszQuickComplete)
        {
            return ((delegate* unmanaged<IAutoComplete2*, IntPtr, IUnknown*, ushort*, ushort*, int>)(lpVtbl[3]))((IAutoComplete2*)Unsafe.AsPointer(ref this), hwndEdit, punkACL, pwszRegKeyPath, pwszQuickComplete);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Enable([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<IAutoComplete2*, int, int>)(lpVtbl[4]))((IAutoComplete2*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetOptions([NativeTypeName("DWORD")] uint dwFlag)
        {
            return ((delegate* unmanaged<IAutoComplete2*, uint, int>)(lpVtbl[5]))((IAutoComplete2*)Unsafe.AsPointer(ref this), dwFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag)
        {
            return ((delegate* unmanaged<IAutoComplete2*, uint*, int>)(lpVtbl[6]))((IAutoComplete2*)Unsafe.AsPointer(ref this), pdwFlag);
        }
    }
}
