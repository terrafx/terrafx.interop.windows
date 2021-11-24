// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("EAC04BC0-3791-11D2-BB95-0060977B464C")]
[NativeTypeName("struct IAutoComplete2 : IAutoComplete")]
[NativeInheritance("IAutoComplete")]
public unsafe partial struct IAutoComplete2 : IAutoComplete2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public HRESULT Init(HWND hwndEdit, IUnknown* punkACL, [NativeTypeName("LPCWSTR")] ushort* pwszRegKeyPath, [NativeTypeName("LPCWSTR")] ushort* pwszQuickComplete)
    {
        return ((delegate* unmanaged<IAutoComplete2*, HWND, IUnknown*, ushort*, ushort*, int>)(lpVtbl[3]))((IAutoComplete2*)Unsafe.AsPointer(ref this), hwndEdit, punkACL, pwszRegKeyPath, pwszQuickComplete);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Enable(BOOL fEnable)
    {
        return ((delegate* unmanaged<IAutoComplete2*, BOOL, int>)(lpVtbl[4]))((IAutoComplete2*)Unsafe.AsPointer(ref this), fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOptions([NativeTypeName("DWORD")] uint dwFlag)
    {
        return ((delegate* unmanaged<IAutoComplete2*, uint, int>)(lpVtbl[5]))((IAutoComplete2*)Unsafe.AsPointer(ref this), dwFlag);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag)
    {
        return ((delegate* unmanaged<IAutoComplete2*, uint*, int>)(lpVtbl[6]))((IAutoComplete2*)Unsafe.AsPointer(ref this), pdwFlag);
    }

    public interface Interface : IAutoComplete.Interface
    {
        [VtblIndex(5)]
        HRESULT SetOptions([NativeTypeName("DWORD")] uint dwFlag);

        [VtblIndex(6)]
        HRESULT GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAutoComplete2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAutoComplete2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAutoComplete2*, uint> Release;

        [NativeTypeName("HRESULT (HWND, IUnknown *, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IAutoComplete2*, HWND, IUnknown*, ushort*, ushort*, int> Init;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IAutoComplete2*, BOOL, int> Enable;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IAutoComplete2*, uint, int> SetOptions;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAutoComplete2*, uint*, int> GetOptions;
    }
}
