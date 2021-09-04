// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6332DEBF-87B5-4670-90C0-5E57B408A49E")]
    [NativeTypeName("struct ICustomDestinationList : IUnknown")]
    public unsafe partial struct ICustomDestinationList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICustomDestinationList*, Guid*, void**, int>)(lpVtbl[0]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICustomDestinationList*, uint>)(lpVtbl[1]))((ICustomDestinationList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICustomDestinationList*, uint>)(lpVtbl[2]))((ICustomDestinationList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID)
        {
            return ((delegate* unmanaged<ICustomDestinationList*, ushort*, int>)(lpVtbl[3]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), pszAppID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginList([NativeTypeName("UINT *")] uint* pcMinSlots, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ICustomDestinationList*, uint*, Guid*, void**, int>)(lpVtbl[4]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), pcMinSlots, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendCategory([NativeTypeName("LPCWSTR")] ushort* pszCategory, IObjectArray* poa)
        {
            return ((delegate* unmanaged<ICustomDestinationList*, ushort*, IObjectArray*, int>)(lpVtbl[5]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), pszCategory, poa);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendKnownCategory(KNOWNDESTCATEGORY category)
        {
            return ((delegate* unmanaged<ICustomDestinationList*, KNOWNDESTCATEGORY, int>)(lpVtbl[6]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), category);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddUserTasks(IObjectArray* poa)
        {
            return ((delegate* unmanaged<ICustomDestinationList*, IObjectArray*, int>)(lpVtbl[7]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), poa);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitList()
        {
            return ((delegate* unmanaged<ICustomDestinationList*, int>)(lpVtbl[8]))((ICustomDestinationList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRemovedDestinations([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ICustomDestinationList*, Guid*, void**, int>)(lpVtbl[9]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteList([NativeTypeName("LPCWSTR")] ushort* pszAppID)
        {
            return ((delegate* unmanaged<ICustomDestinationList*, ushort*, int>)(lpVtbl[10]))((ICustomDestinationList*)Unsafe.AsPointer(ref this), pszAppID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AbortList()
        {
            return ((delegate* unmanaged<ICustomDestinationList*, int>)(lpVtbl[11]))((ICustomDestinationList*)Unsafe.AsPointer(ref this));
        }
    }
}
