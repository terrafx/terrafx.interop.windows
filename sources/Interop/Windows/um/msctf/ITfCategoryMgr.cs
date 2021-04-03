// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3ACEFB5-F69D-4905-938F-FCADCF4BE830")]
    [NativeTypeName("struct ITfCategoryMgr : IUnknown")]
    public unsafe partial struct ITfCategoryMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, uint>)(lpVtbl[1]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, uint>)(lpVtbl[2]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterCategory([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* rcatid, [NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, Guid*, Guid*, int>)(lpVtbl[3]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rclsid, rcatid, rguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterCategory([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* rcatid, [NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, Guid*, Guid*, int>)(lpVtbl[4]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rclsid, rcatid, rguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumCategoriesInItem([NativeTypeName("const GUID &")] Guid* rguid, IEnumGUID** ppEnum)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, IEnumGUID**, int>)(lpVtbl[5]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rguid, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumItemsInCategory([NativeTypeName("const GUID &")] Guid* rcatid, IEnumGUID** ppEnum)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, IEnumGUID**, int>)(lpVtbl[6]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rcatid, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindClosestCategory([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("GUID *")] Guid* pcatid, [NativeTypeName("const GUID **")] Guid** ppcatidList, [NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, Guid*, Guid**, uint, int>)(lpVtbl[7]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rguid, pcatid, ppcatidList, ulCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterGUIDDescription([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("const WCHAR *")] ushort* pchDesc, [NativeTypeName("ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, Guid*, ushort*, uint, int>)(lpVtbl[8]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rclsid, rguid, pchDesc, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterGUIDDescription([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, Guid*, int>)(lpVtbl[9]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rclsid, rguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUIDDescription([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("BSTR *")] ushort** pbstrDesc)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, ushort**, int>)(lpVtbl[10]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rguid, pbstrDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterGUIDDWORD([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("DWORD")] uint dw)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, Guid*, uint, int>)(lpVtbl[11]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rclsid, rguid, dw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterGUIDDWORD([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* rguid)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, Guid*, int>)(lpVtbl[12]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rclsid, rguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUIDDWORD([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("DWORD *")] uint* pdw)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, uint*, int>)(lpVtbl[13]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rguid, pdw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterGUID([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("TfGuidAtom *")] uint* pguidatom)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, Guid*, uint*, int>)(lpVtbl[14]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), rguid, pguidatom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("TfGuidAtom")] uint guidatom, [NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, uint, Guid*, int>)(lpVtbl[15]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), guidatom, pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqualTfGuidAtom([NativeTypeName("TfGuidAtom")] uint guidatom, [NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return ((delegate* unmanaged<ITfCategoryMgr*, uint, Guid*, int*, int>)(lpVtbl[16]))((ITfCategoryMgr*)Unsafe.AsPointer(ref this), guidatom, rguid, pfEqual);
        }
    }
}
