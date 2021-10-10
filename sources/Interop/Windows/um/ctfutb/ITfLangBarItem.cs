// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73540D69-EDEB-4EE9-96C9-23AA30B25916")]
    [NativeTypeName("struct ITfLangBarItem : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfLangBarItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItem*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItem*, uint>)(lpVtbl[1]))((ITfLangBarItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItem*, uint>)(lpVtbl[2]))((ITfLangBarItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo(TF_LANGBARITEMINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItem*, TF_LANGBARITEMINFO*, int>)(lpVtbl[3]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItem*, uint*, int>)(lpVtbl[4]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<ITfLangBarItem*, int, int>)(lpVtbl[5]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
        {
            return ((delegate* unmanaged<ITfLangBarItem*, ushort**, int>)(lpVtbl[6]))((ITfLangBarItem*)Unsafe.AsPointer(ref this), pbstrToolTip);
        }
    }
}
