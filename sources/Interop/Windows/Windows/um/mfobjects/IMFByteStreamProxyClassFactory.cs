// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("A6B43F84-5C0A-42E8-A44D-B1857A76992F")]
    [NativeTypeName("struct IMFByteStreamProxyClassFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFByteStreamProxyClassFactory : IMFByteStreamProxyClassFactory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFByteStreamProxyClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFByteStreamProxyClassFactory*, uint>)(lpVtbl[1]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFByteStreamProxyClassFactory*, uint>)(lpVtbl[2]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateByteStreamProxy(IMFByteStream* pByteStream, IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFByteStreamProxyClassFactory*, IMFByteStream*, IMFAttributes*, Guid*, void**, int>)(lpVtbl[3]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this), pByteStream, pAttributes, riid, ppvObject);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateByteStreamProxy(IMFByteStream* pByteStream, IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamProxyClassFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamProxyClassFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamProxyClassFactory*, uint> Release;

            [NativeTypeName("HRESULT (IMFByteStream *, IMFAttributes *, const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamProxyClassFactory*, IMFByteStream*, IMFAttributes*, Guid*, void**, int> CreateByteStreamProxy;
        }
    }
}
