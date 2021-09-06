// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C594F9F-9F30-47A1-979A-C9E83D3D0A06")]
    [NativeTypeName("struct IApplicationDocumentLists : IUnknown")]
    public unsafe partial struct IApplicationDocumentLists
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, uint>)(lpVtbl[1]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, uint>)(lpVtbl[2]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID)
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, ushort*, int>)(lpVtbl[3]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), pszAppID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetList(APPDOCLISTTYPE listtype, [NativeTypeName("UINT")] uint cItemsDesired, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IApplicationDocumentLists*, APPDOCLISTTYPE, uint, Guid*, void**, int>)(lpVtbl[4]))((IApplicationDocumentLists*)Unsafe.AsPointer(ref this), listtype, cItemsDesired, riid, ppv);
        }
    }
}
