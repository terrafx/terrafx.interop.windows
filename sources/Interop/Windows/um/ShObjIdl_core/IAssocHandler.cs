// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F04061AC-1659-4A3F-A954-775AA57FC083")]
    [NativeTypeName("struct IAssocHandler : IUnknown")]
    public unsafe partial struct IAssocHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAssocHandler*, Guid*, void**, int>)(lpVtbl[0]))((IAssocHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAssocHandler*, uint>)(lpVtbl[1]))((IAssocHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAssocHandler*, uint>)(lpVtbl[2]))((IAssocHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** ppsz)
        {
            return ((delegate* unmanaged<IAssocHandler*, ushort**, int>)(lpVtbl[3]))((IAssocHandler*)Unsafe.AsPointer(ref this), ppsz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUIName([NativeTypeName("LPWSTR *")] ushort** ppsz)
        {
            return ((delegate* unmanaged<IAssocHandler*, ushort**, int>)(lpVtbl[4]))((IAssocHandler*)Unsafe.AsPointer(ref this), ppsz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconLocation([NativeTypeName("LPWSTR *")] ushort** ppszPath, int* pIndex)
        {
            return ((delegate* unmanaged<IAssocHandler*, ushort**, int*, int>)(lpVtbl[5]))((IAssocHandler*)Unsafe.AsPointer(ref this), ppszPath, pIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsRecommended()
        {
            return ((delegate* unmanaged<IAssocHandler*, int>)(lpVtbl[6]))((IAssocHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MakeDefault([NativeTypeName("LPCWSTR")] ushort* pszDescription)
        {
            return ((delegate* unmanaged<IAssocHandler*, ushort*, int>)(lpVtbl[7]))((IAssocHandler*)Unsafe.AsPointer(ref this), pszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke(IDataObject* pdo)
        {
            return ((delegate* unmanaged<IAssocHandler*, IDataObject*, int>)(lpVtbl[8]))((IAssocHandler*)Unsafe.AsPointer(ref this), pdo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInvoker(IDataObject* pdo, IAssocHandlerInvoker** ppInvoker)
        {
            return ((delegate* unmanaged<IAssocHandler*, IDataObject*, IAssocHandlerInvoker**, int>)(lpVtbl[9]))((IAssocHandler*)Unsafe.AsPointer(ref this), pdo, ppInvoker);
        }
    }
}
