// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000026-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IUrlMon : IUnknown")]
    public unsafe partial struct IUrlMon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUrlMon*, Guid*, void**, int>)(lpVtbl[0]))((IUrlMon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUrlMon*, uint>)(lpVtbl[1]))((IUrlMon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUrlMon*, uint>)(lpVtbl[2]))((IUrlMon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AsyncGetClassBits([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] ushort* pszTYPE, [NativeTypeName("LPCWSTR")] ushort* pszExt, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] ushort* pszCodeBase, IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwClassContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD")] uint flags)
        {
            return ((delegate* unmanaged<IUrlMon*, Guid*, ushort*, ushort*, uint, uint, ushort*, IBindCtx*, uint, Guid*, uint, int>)(lpVtbl[3]))((IUrlMon*)Unsafe.AsPointer(ref this), rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
        }
    }
}
