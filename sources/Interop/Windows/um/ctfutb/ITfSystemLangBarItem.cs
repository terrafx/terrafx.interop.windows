// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1E13E9EC-6B33-4D4A-B5EB-8A92F029F356")]
    [NativeTypeName("struct ITfSystemLangBarItem : IUnknown")]
    public unsafe partial struct ITfSystemLangBarItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItem*, Guid*, void**, int>)(lpVtbl[0]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfSystemLangBarItem*, uint>)(lpVtbl[1]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfSystemLangBarItem*, uint>)(lpVtbl[2]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIcon([NativeTypeName("HICON")] IntPtr hIcon)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItem*, IntPtr, int>)(lpVtbl[3]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this), hIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTooltipString([NativeTypeName("WCHAR *")] ushort* pchToolTip, [NativeTypeName("ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItem*, ushort*, uint, int>)(lpVtbl[4]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this), pchToolTip, cch);
        }
    }
}
