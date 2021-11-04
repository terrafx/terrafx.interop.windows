// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020406-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICreateTypeLib : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICreateTypeLib
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint>)(lpVtbl[1]))((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint>)(lpVtbl[2]))((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName, TYPEKIND tkind, ICreateTypeInfo** ppCTInfo)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort*, TYPEKIND, ICreateTypeInfo**, int>)(lpVtbl[3]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), szName, tkind, ppCTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort*, int>)(lpVtbl[4]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), szName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort, ushort, int>)(lpVtbl[5]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, Guid*, int>)(lpVtbl[6]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetDocString([NativeTypeName("LPOLESTR")] ushort* szDoc)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort*, int>)(lpVtbl[7]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), szDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetHelpFileName([NativeTypeName("LPOLESTR")] ushort* szHelpFileName)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort*, int>)(lpVtbl[8]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), szHelpFileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint, int>)(lpVtbl[9]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetLcid([NativeTypeName("LCID")] uint lcid)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint, int>)(lpVtbl[10]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), lcid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetLibFlags(uint uLibFlags)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint, int>)(lpVtbl[11]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), uLibFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SaveAllChanges()
        {
            return ((delegate* unmanaged<ICreateTypeLib*, int>)(lpVtbl[12]))((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, uint> Release;

            [NativeTypeName("HRESULT (LPOLESTR, TYPEKIND, ICreateTypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, ushort*, TYPEKIND, ICreateTypeInfo**, int> CreateTypeInfo;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, ushort, ushort, int> SetVersion;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, Guid*, int> SetGuid;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, ushort*, int> SetDocString;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, ushort*, int> SetHelpFileName;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, uint, int> SetHelpContext;

            [NativeTypeName("HRESULT (LCID) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, uint, int> SetLcid;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, uint, int> SetLibFlags;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ICreateTypeLib*, int> SaveAllChanges;
        }
    }
}
