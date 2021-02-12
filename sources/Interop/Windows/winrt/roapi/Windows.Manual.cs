// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static int ActivateInstance<T>(IntPtr activatableClassId, T** instance) 
            where T : unmanaged
        {
            *instance = null;
            
            IInspectable* pInspectable;
            int hr = RoActivateInstance(activatableClassId, &pInspectable);
            if (SUCCEEDED(hr))
            {
                if (__uuidof<T>() == IID_IInspectable)
                {
                    *instance = (T*) pInspectable;
                }
                else
                {
                    hr = pInspectable->QueryInterface(__uuidof<T>(), (void**) instance);
                    pInspectable->Release();
                }
            }
            
            return hr;
        }
        
        public static int GetActivationFactory<T>(IntPtr activatableClassId, T** factory)
            where T : unmanaged
        {
            return RoGetActivationFactory(activatableClassId, __uuidof<T>(), (void**) factory);
        }
    }
}
