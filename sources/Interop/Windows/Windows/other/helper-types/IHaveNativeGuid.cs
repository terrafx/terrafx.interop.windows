// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop;

public interface IHaveNativeGuid
{
#if NET6_0
    [RequiresPreviewFeatures]
#endif
    static abstract ref readonly Guid GUID { get; }
}
