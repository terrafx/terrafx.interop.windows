// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09083CEF-867F-4BF6-8776-DEE3A7B42FCA")]
    [NativeTypeName("struct IMFMediaEngineClassFactory2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngineClassFactory2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineClassFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory2*, uint>)(lpVtbl[1]))((IMFMediaEngineClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory2*, uint>)(lpVtbl[2]))((IMFMediaEngineClassFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateMediaKeys2([NativeTypeName("BSTR")] ushort* keySystem, [NativeTypeName("BSTR")] ushort* defaultCdmStorePath, [NativeTypeName("BSTR")] ushort* inprivateCdmStorePath, IMFMediaKeys** ppKeys)
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory2*, ushort*, ushort*, ushort*, IMFMediaKeys**, int>)(lpVtbl[3]))((IMFMediaEngineClassFactory2*)Unsafe.AsPointer(ref this), keySystem, defaultCdmStorePath, inprivateCdmStorePath, ppKeys);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineClassFactory2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineClassFactory2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineClassFactory2*, uint> Release;

            [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, IMFMediaKeys **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineClassFactory2*, ushort*, ushort*, ushort*, IMFMediaKeys**, int> CreateMediaKeys2;
        }
    }
}
