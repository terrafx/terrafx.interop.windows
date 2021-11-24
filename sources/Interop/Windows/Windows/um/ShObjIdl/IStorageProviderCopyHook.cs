// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("7BF992A9-AF7A-4DBA-B2E5-4D080B1ECBC6")]
[NativeTypeName("struct IStorageProviderCopyHook : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorageProviderCopyHook : IStorageProviderCopyHook.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageProviderCopyHook*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderCopyHook*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageProviderCopyHook*, uint>)(lpVtbl[1]))((IStorageProviderCopyHook*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderCopyHook*, uint>)(lpVtbl[2]))((IStorageProviderCopyHook*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CopyCallback(HWND hwnd, uint operation, uint flags, [NativeTypeName("LPCWSTR")] ushort* srcFile, [NativeTypeName("DWORD")] uint srcAttribs, [NativeTypeName("LPCWSTR")] ushort* destFile, [NativeTypeName("DWORD")] uint destAttribs, uint* result)
    {
        return ((delegate* unmanaged<IStorageProviderCopyHook*, HWND, uint, uint, ushort*, uint, ushort*, uint, uint*, int>)(lpVtbl[3]))((IStorageProviderCopyHook*)Unsafe.AsPointer(ref this), hwnd, operation, flags, srcFile, srcAttribs, destFile, destAttribs, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CopyCallback(HWND hwnd, uint operation, uint flags, [NativeTypeName("LPCWSTR")] ushort* srcFile, [NativeTypeName("DWORD")] uint srcAttribs, [NativeTypeName("LPCWSTR")] ushort* destFile, [NativeTypeName("DWORD")] uint destAttribs, uint* result);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IStorageProviderCopyHook*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IStorageProviderCopyHook*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IStorageProviderCopyHook*, uint> Release;

        [NativeTypeName("HRESULT (HWND, UINT, UINT, LPCWSTR, DWORD, LPCWSTR, DWORD, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IStorageProviderCopyHook*, HWND, uint, uint, ushort*, uint, ushort*, uint, uint*, int> CopyCallback;
    }
}
