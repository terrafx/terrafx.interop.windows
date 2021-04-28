// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F941B671-BDA7-4F77-884A-F46462F226A7")]
    [NativeTypeName("struct IContact : IUnknown")]
    public unsafe partial struct IContact
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IContact*, Guid*, void**, int>)(lpVtbl[0]))((IContact*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContact*, uint>)(lpVtbl[1]))((IContact*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContact*, uint>)(lpVtbl[2]))((IContact*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContactID([NativeTypeName("LPWSTR")] ushort* pszContactID, [NativeTypeName("DWORD")] uint cchContactID, [NativeTypeName("DWORD *")] uint* pdwcchContactIDRequired)
        {
            return ((delegate* unmanaged<IContact*, ushort*, uint, uint*, int>)(lpVtbl[3]))((IContact*)Unsafe.AsPointer(ref this), pszContactID, cchContactID, pdwcchContactIDRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint cchPath, [NativeTypeName("DWORD *")] uint* pdwcchPathRequired)
        {
            return ((delegate* unmanaged<IContact*, ushort*, uint, uint*, int>)(lpVtbl[4]))((IContact*)Unsafe.AsPointer(ref this), pszPath, cchPath, pdwcchPathRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitChanges([NativeTypeName("DWORD")] uint dwCommitFlags)
        {
            return ((delegate* unmanaged<IContact*, uint, int>)(lpVtbl[5]))((IContact*)Unsafe.AsPointer(ref this), dwCommitFlags);
        }
    }
}
