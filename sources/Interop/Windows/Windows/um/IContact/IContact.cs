// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("F941B671-BDA7-4F77-884A-F46462F226A7")]
[NativeTypeName("struct IContact : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContact : IContact.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContact*, Guid*, void**, int>)(lpVtbl[0]))((IContact*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContact*, uint>)(lpVtbl[1]))((IContact*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContact*, uint>)(lpVtbl[2]))((IContact*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContactID([NativeTypeName("LPWSTR")] ushort* pszContactID, [NativeTypeName("DWORD")] uint cchContactID, [NativeTypeName("DWORD *")] uint* pdwcchContactIDRequired)
    {
        return ((delegate* unmanaged<IContact*, ushort*, uint, uint*, int>)(lpVtbl[3]))((IContact*)Unsafe.AsPointer(ref this), pszContactID, cchContactID, pdwcchContactIDRequired);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPath([NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint cchPath, [NativeTypeName("DWORD *")] uint* pdwcchPathRequired)
    {
        return ((delegate* unmanaged<IContact*, ushort*, uint, uint*, int>)(lpVtbl[4]))((IContact*)Unsafe.AsPointer(ref this), pszPath, cchPath, pdwcchPathRequired);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CommitChanges([NativeTypeName("DWORD")] uint dwCommitFlags)
    {
        return ((delegate* unmanaged<IContact*, uint, int>)(lpVtbl[5]))((IContact*)Unsafe.AsPointer(ref this), dwCommitFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetContactID([NativeTypeName("LPWSTR")] ushort* pszContactID, [NativeTypeName("DWORD")] uint cchContactID, [NativeTypeName("DWORD *")] uint* pdwcchContactIDRequired);

        [VtblIndex(4)]
        HRESULT GetPath([NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint cchPath, [NativeTypeName("DWORD *")] uint* pdwcchPathRequired);

        [VtblIndex(5)]
        HRESULT CommitChanges([NativeTypeName("DWORD")] uint dwCommitFlags);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> GetContactID;

        [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> GetPath;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CommitChanges;
    }
}
