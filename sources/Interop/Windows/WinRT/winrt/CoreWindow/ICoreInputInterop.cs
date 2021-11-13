// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [Guid("40BFE3E3-B75A-4479-AC96-475365749BB8")]
    [NativeTypeName("struct ICoreInputInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICoreInputInterop : ICoreInputInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreInputInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreInputInterop*, uint>)(lpVtbl[1]))((ICoreInputInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreInputInterop*, uint>)(lpVtbl[2]))((ICoreInputInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInputSource(IUnknown* value)
        {
            return ((delegate* unmanaged<ICoreInputInterop*, IUnknown*, int>)(lpVtbl[3]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT put_MessageHandled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ICoreInputInterop*, byte, int>)(lpVtbl[4]))((ICoreInputInterop*)Unsafe.AsPointer(ref this), value);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetInputSource(IUnknown* value);

            [VtblIndex(4)]
            HRESULT put_MessageHandled([NativeTypeName("boolean")] byte value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreInputInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreInputInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreInputInterop*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreInputInterop*, IUnknown*, int> SetInputSource;

            [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
            public delegate* unmanaged<ICoreInputInterop*, byte, int> put_MessageHandled;
        }
    }
}
