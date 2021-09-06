// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7EBFDD87-AD18-11D3-A4C5-00C04F72D6B8")]
    [NativeTypeName("struct ITravelLogEntry : IUnknown")]
    public unsafe partial struct ITravelLogEntry
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITravelLogEntry*, Guid*, void**, int>)(lpVtbl[0]))((ITravelLogEntry*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITravelLogEntry*, uint>)(lpVtbl[1]))((ITravelLogEntry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITravelLogEntry*, uint>)(lpVtbl[2]))((ITravelLogEntry*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTitle([NativeTypeName("LPWSTR *")] ushort** ppszTitle)
        {
            return ((delegate* unmanaged<ITravelLogEntry*, ushort**, int>)(lpVtbl[3]))((ITravelLogEntry*)Unsafe.AsPointer(ref this), ppszTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL)
        {
            return ((delegate* unmanaged<ITravelLogEntry*, ushort**, int>)(lpVtbl[4]))((ITravelLogEntry*)Unsafe.AsPointer(ref this), ppszURL);
        }
    }
}
