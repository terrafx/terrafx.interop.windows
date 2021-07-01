// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1449D9AB-13CF-4687-AA3E-8D8B18574396")]
    [NativeTypeName("struct ITfSystemLangBarItemSink : IUnknown")]
    public unsafe partial struct ITfSystemLangBarItemSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemSink*, uint>)(lpVtbl[1]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemSink*, uint>)(lpVtbl[2]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitMenu(ITfMenu* pMenu)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemSink*, ITfMenu*, int>)(lpVtbl[3]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this), pMenu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnMenuSelect([NativeTypeName("UINT")] uint wID)
        {
            return ((delegate* unmanaged<ITfSystemLangBarItemSink*, uint, int>)(lpVtbl[4]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this), wID);
        }
    }
}
