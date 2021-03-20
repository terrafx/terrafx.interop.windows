// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A42B0C24-7F21-4ABC-99C1-8F01007F0880")]
    [NativeTypeName("struct IIdleDispatchedHandler : IUnknown")]
    public unsafe partial struct IIdleDispatchedHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IIdleDispatchedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IIdleDispatchedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IIdleDispatchedHandler*, uint>)(lpVtbl[1]))((IIdleDispatchedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IIdleDispatchedHandler*, uint>)(lpVtbl[2]))((IIdleDispatchedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("ABI::Windows::UI::Core::IIdleDispatchedHandlerArgs *")] IIdleDispatchedHandlerArgs* e)
        {
            return ((delegate* unmanaged<IIdleDispatchedHandler*, IIdleDispatchedHandlerArgs*, int>)(lpVtbl[3]))((IIdleDispatchedHandler*)Unsafe.AsPointer(ref this), e);
        }
    }
}
