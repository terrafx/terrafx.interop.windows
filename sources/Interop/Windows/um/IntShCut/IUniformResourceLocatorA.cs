// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBF23B80-E3F0-101B-8488-00AA003E56F8")]
    [NativeTypeName("struct IUniformResourceLocatorA : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUniformResourceLocatorA
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUniformResourceLocatorA*, Guid*, void**, int>)(lpVtbl[0]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUniformResourceLocatorA*, uint>)(lpVtbl[1]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUniformResourceLocatorA*, uint>)(lpVtbl[2]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetURL([NativeTypeName("LPCSTR")] sbyte* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags)
        {
            return ((delegate* unmanaged<IUniformResourceLocatorA*, sbyte*, uint, int>)(lpVtbl[3]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this), pcszURL, dwInFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetURL([NativeTypeName("LPSTR *")] sbyte** ppszURL)
        {
            return ((delegate* unmanaged<IUniformResourceLocatorA*, sbyte**, int>)(lpVtbl[4]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this), ppszURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT InvokeCommand([NativeTypeName("PURLINVOKECOMMANDINFOA")] URLINVOKECOMMANDINFOA* purlici)
        {
            return ((delegate* unmanaged<IUniformResourceLocatorA*, URLINVOKECOMMANDINFOA*, int>)(lpVtbl[5]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this), purlici);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUniformResourceLocatorA*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUniformResourceLocatorA*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUniformResourceLocatorA*, uint> Release;

            [NativeTypeName("HRESULT (LPCSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IUniformResourceLocatorA*, sbyte*, uint, int> SetURL;

            [NativeTypeName("HRESULT (LPSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IUniformResourceLocatorA*, sbyte**, int> GetURL;

            [NativeTypeName("HRESULT (PURLINVOKECOMMANDINFOA) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IUniformResourceLocatorA*, URLINVOKECOMMANDINFOA*, int> InvokeCommand;
        }
    }
}
