// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1FB73D0-EC3A-4BA2-B512-8CDB9187B6D1")]
    [NativeTypeName("struct IHWEventHandler : IUnknown")]
    public unsafe partial struct IHWEventHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHWEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IHWEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHWEventHandler*, uint>)(lpVtbl[1]))((IHWEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHWEventHandler*, uint>)(lpVtbl[2]))((IHWEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPCWSTR")] ushort* pszParams)
        {
            return ((delegate* unmanaged<IHWEventHandler*, ushort*, int>)(lpVtbl[3]))((IHWEventHandler*)Unsafe.AsPointer(ref this), pszParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandleEvent([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType)
        {
            return ((delegate* unmanaged<IHWEventHandler*, ushort*, ushort*, ushort*, int>)(lpVtbl[4]))((IHWEventHandler*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandleEventWithContent([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszAltDeviceID, [NativeTypeName("LPCWSTR")] ushort* pszEventType, [NativeTypeName("LPCWSTR")] ushort* pszContentTypeHandler, IDataObject* pdataobject)
        {
            return ((delegate* unmanaged<IHWEventHandler*, ushort*, ushort*, ushort*, ushort*, IDataObject*, int>)(lpVtbl[5]))((IHWEventHandler*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType, pszContentTypeHandler, pdataobject);
        }
    }
}
