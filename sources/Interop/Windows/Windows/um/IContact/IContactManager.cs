// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("AD553D98-DEB1-474A-8E17-FC0C2075B738")]
    [NativeTypeName("struct IContactManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IContactManager : IContactManager.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContactManager*, Guid*, void**, int>)(lpVtbl[0]))((IContactManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContactManager*, uint>)(lpVtbl[1]))((IContactManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContactManager*, uint>)(lpVtbl[2]))((IContactManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszAppName, [NativeTypeName("LPCWSTR")] ushort* pszAppVersion)
        {
            return ((delegate* unmanaged<IContactManager*, ushort*, ushort*, int>)(lpVtbl[3]))((IContactManager*)Unsafe.AsPointer(ref this), pszAppName, pszAppVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Load([NativeTypeName("LPCWSTR")] ushort* pszContactID, IContact** ppContact)
        {
            return ((delegate* unmanaged<IContactManager*, ushort*, IContact**, int>)(lpVtbl[4]))((IContactManager*)Unsafe.AsPointer(ref this), pszContactID, ppContact);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MergeContactIDs([NativeTypeName("LPCWSTR")] ushort* pszNewContactID, [NativeTypeName("LPCWSTR")] ushort* pszOldContactID)
        {
            return ((delegate* unmanaged<IContactManager*, ushort*, ushort*, int>)(lpVtbl[5]))((IContactManager*)Unsafe.AsPointer(ref this), pszNewContactID, pszOldContactID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetMeContact(IContact** ppMeContact)
        {
            return ((delegate* unmanaged<IContactManager*, IContact**, int>)(lpVtbl[6]))((IContactManager*)Unsafe.AsPointer(ref this), ppMeContact);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetMeContact(IContact* pMeContact)
        {
            return ((delegate* unmanaged<IContactManager*, IContact*, int>)(lpVtbl[7]))((IContactManager*)Unsafe.AsPointer(ref this), pMeContact);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetContactCollection(IContactCollection** ppContactCollection)
        {
            return ((delegate* unmanaged<IContactManager*, IContactCollection**, int>)(lpVtbl[8]))((IContactManager*)Unsafe.AsPointer(ref this), ppContactCollection);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Initialize([NativeTypeName("LPCWSTR")] ushort* pszAppName, [NativeTypeName("LPCWSTR")] ushort* pszAppVersion);

            [VtblIndex(4)]
            HRESULT Load([NativeTypeName("LPCWSTR")] ushort* pszContactID, IContact** ppContact);

            [VtblIndex(5)]
            HRESULT MergeContactIDs([NativeTypeName("LPCWSTR")] ushort* pszNewContactID, [NativeTypeName("LPCWSTR")] ushort* pszOldContactID);

            [VtblIndex(6)]
            HRESULT GetMeContact(IContact** ppMeContact);

            [VtblIndex(7)]
            HRESULT SetMeContact(IContact* pMeContact);

            [VtblIndex(8)]
            HRESULT GetContactCollection(IContactCollection** ppContactCollection);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, ushort*, ushort*, int> Initialize;

            [NativeTypeName("HRESULT (LPCWSTR, IContact **) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, ushort*, IContact**, int> Load;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, ushort*, ushort*, int> MergeContactIDs;

            [NativeTypeName("HRESULT (IContact **) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, IContact**, int> GetMeContact;

            [NativeTypeName("HRESULT (IContact *) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, IContact*, int> SetMeContact;

            [NativeTypeName("HRESULT (IContactCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactManager*, IContactCollection**, int> GetContactCollection;
        }
    }
}
