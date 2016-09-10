// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.Client
{
    using System;

    public interface IDeviceClientPipelineBuilder
    {
        IDeviceClientPipelineBuilder With(Func<IPipelineContext, IDelegatingHandler> delegatingHandlerCreator);

        IDelegatingHandler Build(IPipelineContext context);
    }
}