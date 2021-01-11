// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct Locator<Fn>
        where Fn : unmanaged, Locator<Fn>.IRoMetaDataLocator
    {
        void** lpVtbl;
        internal Fn _fn;

        public Locator(Fn fn)
        {
            _fn = fn;
            lpVtbl = vtblForType;
        }

        static void** vtblForType;
        static Locator()
        {
            vtblForType = (void**) RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Locator<Fn>), sizeof(void*) * 2);
            vtblForType[0] = (delegate* unmanaged<void***, ushort*, IRoSimpleMetaDataBuilder*, int>) &Locator.LocateThunk;
            vtblForType[1] = (delegate* <void***, ushort*, IRoSimpleMetaDataBuilder*, int>) &Locate;
        }
        
        static int Locate(void*** @this, ushort* nameElement, IRoSimpleMetaDataBuilder* metaDataDestination)
        {
            var locator = (Locator<Fn>*) (@this);
            return locator->_fn.Locate(nameElement, metaDataDestination);
        }

        public interface IRoMetaDataLocator
        {
            int Locate(ushort* nameElement, IRoSimpleMetaDataBuilder* metaDataDestination);
        }
    }

    internal unsafe class Locator
    {
        [UnmanagedCallersOnly]
        internal static int LocateThunk(void*** @this, ushort* nameElement, IRoSimpleMetaDataBuilder* metaDataDestination)
        {
            void** locatorVtbl = *@this;
            return ((delegate*<void***, ushort*, IRoSimpleMetaDataBuilder*, int>) locatorVtbl[1])(@this, nameElement, metaDataDestination);
        }
    }
}
