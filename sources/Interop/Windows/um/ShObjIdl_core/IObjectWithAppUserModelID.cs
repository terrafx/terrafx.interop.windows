// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36DB0196-9665-46D1-9BA7-D3709EECF9ED")]
    [NativeTypeName("struct IObjectWithAppUserModelID : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IObjectWithAppUserModelID
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectWithAppUserModelID*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectWithAppUserModelID*, uint>)(lpVtbl[1]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectWithAppUserModelID*, uint>)(lpVtbl[2]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID)
        {
            return ((delegate* unmanaged<IObjectWithAppUserModelID*, ushort*, int>)(lpVtbl[3]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this), pszAppID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppID([NativeTypeName("LPWSTR *")] ushort** ppszAppID)
        {
            return ((delegate* unmanaged<IObjectWithAppUserModelID*, ushort**, int>)(lpVtbl[4]))((IObjectWithAppUserModelID*)Unsafe.AsPointer(ref this), ppszAppID);
        }
    }
}
