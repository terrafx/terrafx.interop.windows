// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("101D6610-0990-11D3-8DF0-00105A2799B5")]
    [NativeTypeName("struct ITfFunctionProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfFunctionProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFunctionProvider*, Guid*, void**, int>)(lpVtbl[0]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFunctionProvider*, uint>)(lpVtbl[1]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFunctionProvider*, uint>)(lpVtbl[2]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfFunctionProvider*, Guid*, int>)(lpVtbl[3]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDesc)
        {
            return ((delegate* unmanaged<ITfFunctionProvider*, ushort**, int>)(lpVtbl[4]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this), pbstrDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetFunction([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITfFunctionProvider*, Guid*, Guid*, IUnknown**, int>)(lpVtbl[5]))((ITfFunctionProvider*)Unsafe.AsPointer(ref this), rguid, riid, ppunk);
        }
    }
}
