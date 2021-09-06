// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC2601D7-059E-42FC-A09D-2AFD21B6D5F7")]
    [NativeTypeName("struct IDynamicHWHandler : IUnknown")]
    public unsafe partial struct IDynamicHWHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDynamicHWHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDynamicHWHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDynamicHWHandler*, uint>)(lpVtbl[1]))((IDynamicHWHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDynamicHWHandler*, uint>)(lpVtbl[2]))((IDynamicHWHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDynamicInfo([NativeTypeName("LPCWSTR")] ushort* pszDeviceID, [NativeTypeName("DWORD")] uint dwContentType, [NativeTypeName("LPWSTR *")] ushort** ppszAction)
        {
            return ((delegate* unmanaged<IDynamicHWHandler*, ushort*, uint, ushort**, int>)(lpVtbl[3]))((IDynamicHWHandler*)Unsafe.AsPointer(ref this), pszDeviceID, dwContentType, ppszAction);
        }
    }
}
