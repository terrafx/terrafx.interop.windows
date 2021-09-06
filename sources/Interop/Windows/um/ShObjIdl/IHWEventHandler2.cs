// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFCC809F-295D-42E8-9FFC-424B33C487E6")]
    [NativeTypeName("struct IHWEventHandler2 : IHWEventHandler")]
    public unsafe partial struct IHWEventHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHWEventHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHWEventHandler2*, uint>)(lpVtbl[1]))((IHWEventHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHWEventHandler2*, uint>)(lpVtbl[2]))((IHWEventHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPCWSTR")] ushort* pszParams)
        {
            return ((delegate* unmanaged<IHWEventHandler2*, ushort*, int>)(lpVtbl[3]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), pszParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandleEvent([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType)
        {
            return ((delegate* unmanaged<IHWEventHandler2*, ushort*, ushort*, ushort*, int>)(lpVtbl[4]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandleEventWithContent([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType, [NativeTypeName("LPCWSTR")] ushort* pszContentTypeHandler, IDataObject* pdataobject)
        {
            return ((delegate* unmanaged<IHWEventHandler2*, ushort*, ushort*, ushort*, ushort*, IDataObject*, int>)(lpVtbl[5]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType, pszContentTypeHandler, pdataobject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandleEventWithHWND([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType, [NativeTypeName("HWND")] IntPtr hwndOwner)
        {
            return ((delegate* unmanaged<IHWEventHandler2*, ushort*, ushort*, ushort*, IntPtr, int>)(lpVtbl[6]))((IHWEventHandler2*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType, hwndOwner);
        }
    }
}
