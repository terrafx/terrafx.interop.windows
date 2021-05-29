// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IEObjectType
    {
        IE_EPM_OBJECT_EVENT,
        IE_EPM_OBJECT_MUTEX,
        IE_EPM_OBJECT_SEMAPHORE,
        IE_EPM_OBJECT_SHARED_MEMORY,
        IE_EPM_OBJECT_WAITABLE_TIMER,
        IE_EPM_OBJECT_FILE,
        IE_EPM_OBJECT_NAMED_PIPE,
        IE_EPM_OBJECT_REGISTRY,
    }
}
