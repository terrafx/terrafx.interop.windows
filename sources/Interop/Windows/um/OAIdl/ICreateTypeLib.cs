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
    public unsafe partial struct ICreateTypeLib
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint>)(lpVtbl[1]))((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint>)(lpVtbl[2]))((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName, TYPEKIND tkind, ICreateTypeInfo** ppCTInfo)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort*, TYPEKIND, ICreateTypeInfo**, int>)(lpVtbl[3]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), szName, tkind, ppCTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort*, int>)(lpVtbl[4]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), szName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort, ushort, int>)(lpVtbl[5]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, Guid*, int>)(lpVtbl[6]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* szDoc)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort*, int>)(lpVtbl[7]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), szDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpFileName([NativeTypeName("LPOLESTR")] ushort* szHelpFileName)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, ushort*, int>)(lpVtbl[8]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), szHelpFileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint, int>)(lpVtbl[9]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLcid([NativeTypeName("LCID")] uint lcid)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint, int>)(lpVtbl[10]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), lcid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLibFlags([NativeTypeName("UINT")] uint uLibFlags)
        {
            return ((delegate* unmanaged<ICreateTypeLib*, uint, int>)(lpVtbl[11]))((ICreateTypeLib*)Unsafe.AsPointer(ref this), uLibFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveAllChanges()
        {
            return ((delegate* unmanaged<ICreateTypeLib*, int>)(lpVtbl[12]))((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }
    }
}
