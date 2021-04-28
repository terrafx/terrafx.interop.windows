// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD553D98-DEB1-474A-8E17-FC0C2075B738")]
    [NativeTypeName("struct IContactManager : IUnknown")]
    public unsafe partial struct IContactManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IContactManager*, Guid*, void**, int>)(lpVtbl[0]))((IContactManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContactManager*, uint>)(lpVtbl[1]))((IContactManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContactManager*, uint>)(lpVtbl[2]))((IContactManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPCWSTR")] ushort* pszAppName, [NativeTypeName("LPCWSTR")] ushort* pszAppVersion)
        {
            return ((delegate* unmanaged<IContactManager*, ushort*, ushort*, int>)(lpVtbl[3]))((IContactManager*)Unsafe.AsPointer(ref this), pszAppName, pszAppVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPCWSTR")] ushort* pszContactID, [NativeTypeName("IContact **")] IContact** ppContact)
        {
            return ((delegate* unmanaged<IContactManager*, ushort*, IContact**, int>)(lpVtbl[4]))((IContactManager*)Unsafe.AsPointer(ref this), pszContactID, ppContact);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MergeContactIDs([NativeTypeName("LPCWSTR")] ushort* pszNewContactID, [NativeTypeName("LPCWSTR")] ushort* pszOldContactID)
        {
            return ((delegate* unmanaged<IContactManager*, ushort*, ushort*, int>)(lpVtbl[5]))((IContactManager*)Unsafe.AsPointer(ref this), pszNewContactID, pszOldContactID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMeContact([NativeTypeName("IContact **")] IContact** ppMeContact)
        {
            return ((delegate* unmanaged<IContactManager*, IContact**, int>)(lpVtbl[6]))((IContactManager*)Unsafe.AsPointer(ref this), ppMeContact);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMeContact([NativeTypeName("IContact *")] IContact* pMeContact)
        {
            return ((delegate* unmanaged<IContactManager*, IContact*, int>)(lpVtbl[7]))((IContactManager*)Unsafe.AsPointer(ref this), pMeContact);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContactCollection([NativeTypeName("IContactCollection **")] IContactCollection** ppContactCollection)
        {
            return ((delegate* unmanaged<IContactManager*, IContactCollection**, int>)(lpVtbl[8]))((IContactManager*)Unsafe.AsPointer(ref this), ppContactCollection);
        }
    }
}
