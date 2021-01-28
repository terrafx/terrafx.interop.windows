// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45672EB9-9059-46A2-838D-4530355F6A77")]
    [NativeTypeName("struct ITfSystemDeviceTypeLangBarItem : IUnknown")]
    public unsafe partial struct ITfSystemDeviceTypeLangBarItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem*, Guid*, void**, int>)(lpVtbl[0]))((ITfSystemDeviceTypeLangBarItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem*, uint>)(lpVtbl[1]))((ITfSystemDeviceTypeLangBarItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem*, uint>)(lpVtbl[2]))((ITfSystemDeviceTypeLangBarItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconMode([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem*, uint, int>)(lpVtbl[3]))((ITfSystemDeviceTypeLangBarItem*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconMode([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem*, uint*, int>)(lpVtbl[4]))((ITfSystemDeviceTypeLangBarItem*)Unsafe.AsPointer(ref this), pdwFlags);
        }
    }
}
