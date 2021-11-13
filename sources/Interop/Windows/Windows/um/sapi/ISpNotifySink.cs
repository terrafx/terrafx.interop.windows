// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("259684DC-37C3-11D2-9603-00C04F8EE628")]
    [NativeTypeName("struct ISpNotifySink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpNotifySink : ISpNotifySink.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpNotifySink*, Guid*, void**, int>)(lpVtbl[0]))((ISpNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpNotifySink*, uint>)(lpVtbl[1]))((ISpNotifySink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpNotifySink*, uint>)(lpVtbl[2]))((ISpNotifySink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Notify()
        {
            return ((delegate* unmanaged<ISpNotifySink*, int>)(lpVtbl[3]))((ISpNotifySink*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Notify();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpNotifySink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpNotifySink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpNotifySink*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpNotifySink*, int> Notify;
        }
    }
}
