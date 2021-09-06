// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("35094A87-8BB1-4237-96C6-C417EEBDB078")]
    [NativeTypeName("struct IHandlerActivationHost : IUnknown")]
    public unsafe partial struct IHandlerActivationHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHandlerActivationHost*, Guid*, void**, int>)(lpVtbl[0]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHandlerActivationHost*, uint>)(lpVtbl[1]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHandlerActivationHost*, uint>)(lpVtbl[2]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeforeCoCreateInstance([NativeTypeName("const IID &")] Guid* clsidHandler, IShellItemArray* itemsBeingActivated, IHandlerInfo* handlerInfo)
        {
            return ((delegate* unmanaged<IHandlerActivationHost*, Guid*, IShellItemArray*, IHandlerInfo*, int>)(lpVtbl[3]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this), clsidHandler, itemsBeingActivated, handlerInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeforeCreateProcess([NativeTypeName("LPCWSTR")] ushort* applicationPath, [NativeTypeName("LPCWSTR")] ushort* commandLine, IHandlerInfo* handlerInfo)
        {
            return ((delegate* unmanaged<IHandlerActivationHost*, ushort*, ushort*, IHandlerInfo*, int>)(lpVtbl[4]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this), applicationPath, commandLine, handlerInfo);
        }
    }
}
