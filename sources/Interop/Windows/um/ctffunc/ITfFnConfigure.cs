// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("88F567C6-1757-49F8-A1B2-89234C1EEFF9")]
    [NativeTypeName("struct ITfFnConfigure : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnConfigure
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnConfigure*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnConfigure*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnConfigure*, uint>)(lpVtbl[1]))((ITfFnConfigure*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnConfigure*, uint>)(lpVtbl[2]))((ITfFnConfigure*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnConfigure*, ushort**, int>)(lpVtbl[3]))((ITfFnConfigure*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* rguidProfile)
        {
            return ((delegate* unmanaged<ITfFnConfigure*, IntPtr, ushort, Guid*, int>)(lpVtbl[4]))((ITfFnConfigure*)Unsafe.AsPointer(ref this), hwndParent, langid, rguidProfile);
        }
    }
}
